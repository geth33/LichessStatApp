using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessFollowerApp
{
    class Controller
    {
        /// <summary>
        /// For canceling the current operation
        /// </summary>
        private CancellationTokenSource tokenSource = new CancellationTokenSource();

        /// <summary>
        /// Connection string to the MySQL DB
        /// </summary>
        private static MySqlConnection dbConn;

        /// <summary>
        /// Reference to the view which we will update.
        /// </summary>
        IStatInterface window;

        /// <summary>
        /// Lichess username that the user wants to search with.
        /// </summary>
        private string username;

        /// <summary>
        /// Relationship indicating either the username's followers or those the username follow's.
        /// </summary>
        private string relationship;

        /// <summary>
        /// Type of chess game format (type of standard chess or type of variant chess)
        /// </summary>
        private string gameMode;

        /// <summary>
        /// Current table we are working on.
        /// </summary>
        private string currTable;

        /// <summary>
        /// Basic profile data about the selected user we will be doing calculations on. 
        /// </summary>
        private int followerCount, usernameRating;

        /// <summary>
        /// Keeps track of current lowest value of respective category. Used to reduce the amount of calls that we make trying to update the various link structures.
        /// </summary>
        private int currLowestTv, currLowestActive, currLowestRating;

        /// <summary>
        /// Dictionary that keeps track of how many players are from each country.
        /// </summary>
        private Dictionary<string, int> countryMap;

        /// <summary>
        /// Rating tiers that govern which rated players we care about.
        /// </summary>
        private int lowestRatingTier = 800, highestRatingTier = 2400;

        private Dictionary<string,string> celebrityPlayerDictionary = new Dictionary<string, string>();

        public Controller(IStatInterface chessWindow)
        {
            window = chessWindow;
            InitializeDB();
            window.SubmitRatingComparatorEvent += CompareRatingsMode;
            window.SubmitFollowerStatEvent += FollowerStatsMode;
            window.CancelButtonHit += Cancel;
            celebrityPlayerDictionary.Add("agadmator", "table11");
            celebrityPlayerDictionary.Add("chess-network", "table12");
            celebrityPlayerDictionary.Add("drnykterstein", "table13");
            celebrityPlayerDictionary.Add("penguingim1", "table14");
            celebrityPlayerDictionary.Add("alireza2003", "table15");
        }

        /// <summary>
        /// Cancels the current action by canceling the current TokenSources 
        /// </summary>
        private void Cancel()
        {
            if (tokenSource != null)
            {
                tokenSource.Cancel();
            }
        }

        /// <summary>
        /// Checks if input values are non-empty then proceeds to call the method that initializes the program.
        /// </summary>
        /// <param name="username"> username of the account we want to search with</param>
        /// <param name="relationship"> Either "follower" or "following" in relation to this username</param>
        /// <param name="gameMode"> The chess game mode we want to get data about</param>
        private void CompareRatingsMode(string username, string relationship, string gameMode)
        {
                if (username == "" || relationship == "" || gameMode == "")
                {
                    MessageBox.Show("Please fill out all fields.");
                    window.ToggleControls("CompareRating");
                    return;
                }
                this.username = username;
                this.relationship = relationship;
                this.gameMode = NormalizeGameMode(gameMode);
                InitializeProgram("CompareRatings");
        }
        /// <summary>
        /// Checks if input values are non-empty then proceeds to call the method that initializes the program.
        /// </summary>
        /// <param name="username"> username of the account we want to search with</param>
        /// <param name="relationship"> Either "follower" or "following" in relation to this username</param>
        private void FollowerStatsMode(string username, string relationship)
        {
                if (username == "" || relationship == ""){
                MessageBox.Show("Please fill out all fields.");
                window.ToggleControls("FollowerStat");
                return;
                }
            this.username = username;
            this.relationship = relationship;
            InitializeProgram("FollowerStat");
        }

        /// <summary>
        /// Initializes the program by seeing if our selected user is elligible, selecting the database table we will insert info into,
        /// insert the data into this table, and call the method which will perform calculations on that data.
        /// </summary>
        /// <param name="mode"></param>
        private async void InitializeProgram(string mode)
        {
            tokenSource = new CancellationTokenSource();
            bool thrownInFindUserData = false;
            try {
            if (!CheckForInternetConnection()){
                MessageBox.Show("You are not connected to the internet.");
                window.ToggleControls(mode);
                return;
            }
            // Get profile data on the user we will be gathering follower/following data from.
                await FindUserData(mode, tokenSource.Token);
                if (followerCount == 0)
                {
                    MessageBox.Show("Error: "+ username + " either has no " + relationship + " or they simply do not exist.");
                    window.ToggleControls(mode);
                    return;
                }
                if (tokenSource.Token.IsCancellationRequested)
                {
                    thrownInFindUserData = true;
                    tokenSource.Token.ThrowIfCancellationRequested();
                }
            // Check if selected user has too high of a follower/following count. This is to make sure we don't crash lichess servers.
            /*if (followerCount > 100 && !celebrityPlayerDictionary.ContainsKey(username)){
                MessageBox.Show("The user you selected has too high of a " + relationship + " count.\n Try choosing with less than 100 " + relationship + ".");
                    window.ToggleControls(mode);
                return;
            }*/
                window.StartTimer(followerCount / 17, mode);
                if (SelectDatabaseTable(tokenSource.Token))
                {
                    // If we had to select a new table to insert stuff into, we now get the data.
                    await PopulateDatabase(tokenSource.Token);
                }
                tokenSource.Token.ThrowIfCancellationRequested();
                // Do the calculations for the mode the user selected.
                if (mode == "FollowerStat")
                {
                    CalculateFollowerStats();
                }
                else
                {
                    CompareRatings();
                }
            }
            catch (OperationCanceledException)
            {
                window.ToggleControls(mode);
                if (!thrownInFindUserData)
                {
                    DeleteDatabaseEntry();
                }
                return;
            }
        }

        /// <summary>
        /// Calculates all the Follower Stats that will be displayed from selecting the "Follower Stats" mode.
        /// </summary>
        private void CalculateFollowerStats()
        {
            // various linked list roots that will keep track of the top 3 links for each type of data we want to collect
            // Ex.: Players with most time on lichess's TV, most active players on the site, ect. 
            Link countryLinkRoot = new Link(), mostTvLinkRoot = new Link(), mostActiveLinkRoot = new Link();
            // Dictionary to count how many players are in each rating bracket Ex.: 1500 rtg: 10 users, 1600 rtg: 15 users
            Dictionary<int, int> ratingMap = new Dictionary<int, int>();
            countryMap = new Dictionary<string, int>();
            currLowestTv = 0; currLowestActive = 0;
            for (int offset = 0; offset < 1700; offset += 100){
                // add into rating map rating entries 800, 900, ...., 2400. 
                ratingMap.Add(lowestRatingTier + offset, 0);
            }

            // Get all the entered user's follower/following data from the database
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + currTable, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            // If reader has rows, database has the data needed for this request
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    JObject perfs = JObject.Parse(reader["perfs"].ToString());
                    string playTimeString = reader["play_time"]?.ToString() ?? "";
                    string username = reader["username"].ToString();
                    string country = reader["country"]?.ToString() ?? "";
                    string ratingString = (string) perfs.SelectToken("blitz.rating");
                    var numGamesPlayed = perfs.SelectToken("blitz.games");
                    // If the current user has a valid rating and has played atleast 3 games, we add them to our ratingMap. 
                    if (ratingString != null && numGamesPlayed != null && (int)numGamesPlayed > 3){
                        int rating = Convert.ToInt32(ratingString);
                        if (rating < highestRatingTier){
                            if (rating < lowestRatingTier){
                                // Unfortunately, to update the ratingMap Dictionary we must remove the original and then add it back in with new data. 
                                int newData = ++ratingMap[lowestRatingTier];
                                ratingMap.Remove(lowestRatingTier);
                                ratingMap.Add(lowestRatingTier, newData);
                            }
                            else{
                                string stringRating = rating.ToString();
                                string replacedStr;
                                // case where rating is 800 or 900
                                if (stringRating.Length == 3){
                                    replacedStr = stringRating.Substring(0, 1) + "00";
                                }
                                else{
                                    replacedStr = stringRating.Substring(0, 2) + "00";
                                }
                                int newRating = Convert.ToInt32(replacedStr);
                                int newData = ++ratingMap[newRating];
                                ratingMap.Remove(newRating);
                                ratingMap.Add(newRating, newData);
                            }
                        }
                        else{
                            int newData = ++ratingMap[highestRatingTier];
                            ratingMap.Remove(highestRatingTier);
                            ratingMap.Add(highestRatingTier, newData);
                        }
                    }
                    if (country != ""){
                        // check if we already have the country in the dictionary and update accordingly.
                        if (!countryMap.ContainsKey(country)){
                            countryMap.Add(country, 1);
                        }
                        else{
                            int countryData = countryMap[country] + 1;
                            countryMap.Remove(country);
                            countryMap.Add(country, countryData);
                        }
                    }
                    if (playTimeString != ""){
                        // get the total times the current user has played and/or been on tv 
                        JObject playTime = JObject.Parse(playTimeString);
                        int tvTime = (int)playTime.GetValue("tv");
                        int totalPlayTime = (int)playTime.GetValue("total");

                        // check if this user's time is less than the current lowest link. 
                        // There are only 3 links so if this registers as true, the program won't have to traverse many links to update.  
                        if (currLowestActive < totalPlayTime){
                            UpdateList(mostActiveLinkRoot, totalPlayTime, username, "active");
                        }
                        if (currLowestTv < tvTime){
                            UpdateList(mostTvLinkRoot, tvTime, username, "tv");
                        }
                    }
                }
            }
            else{
                // This appears to be an entry that has no data in the database.  
                MessageBox.Show("Something went wrong from collecting data from database.");
                if (dbConn.State == System.Data.ConnectionState.Open)
                {
                    dbConn.Close();
                }
                //Delete its value from database so it will be overwritten
                DeleteDatabaseEntry();
                window.ToggleControls("FollowerStat");
                return;
            }
            // Iterate over countryMap to find what the top 3 most frequent countries are.
            foreach (string key in countryMap.Keys){
                UpdateList(countryLinkRoot, countryMap[key], key, "country");
            }
            reader.Close();
            dbConn.Close();
            window.SetupFollowerStatPage(username, relationship, followerCount, mostActiveLinkRoot, mostTvLinkRoot, countryLinkRoot, ratingMap);
        }

        /// <summary>
        /// Updates the passed in link if the passed in data is greater than the data of this link or its descendents.
        /// Easily the ugliest code in this program. In retrospect I believe I should have used recursion to implement updating the links. 
        /// This still performs well, though. 
        /// </summary>
        /// <param name="rootLink">The root link for this data type</param>
        /// <param name="data">The number ascribed to this link. Ex.: TV time, current country count, etc.</param>
        /// <param name="username">The name of the user who is associated with this data</param>
        /// <param name="listType">The type of list we are looking at. Ex: most active list, most TV time list, etc.</param>
        private void UpdateList(Link rootLink, int data, string username, string listType)
        {
            // if data == 0, then this link has no value yet.
            if (rootLink.data == 0){
                rootLink.data = data;
                rootLink.name = username;
            }
            // check if the new data is larger than this root link's data
            else if (rootLink.data < data){
                int tempData = rootLink.data;
                string tempName = rootLink.name;
                rootLink.data = data;
                rootLink.name = username;
                if (rootLink.next != null){
                    UpdateChain(rootLink.next, tempData, tempName, listType, 2);
                }
                else{
                    Link newLink = new Link(tempData, tempName);
                    rootLink.next = newLink;
                }
            }
            // check if the next link to the root is null
            else if (rootLink.next == null){
                Link newLink = new Link(data, username);
                rootLink.next = newLink;
            }
            // if not, check if this new data is larger than this link's data
            else if (rootLink.next.data < data){
                int tempData = rootLink.next.data;
                string tempName = rootLink.next.name;
                rootLink.next.data = data;
                rootLink.next.name = username;
                if (rootLink.next.next != null){
                    UpdateChain(rootLink.next, tempData, tempName, listType, 3);
                }
                else{
                    rootLink.next.next = new Link(tempData, tempName);
                    if (listType == "active" || listType == "rating"){
                        currLowestActive = rootLink.next.next.data;
                        currLowestRating = rootLink.next.next.data;
                    }
                    else if (listType == "tv"){
                        currLowestTv = rootLink.next.next.data;
                    }
                }
            }
            // if we get here, we know that this data is larger than our last link (it exceeded the current "currLowest____" for this listType)
            else{
                if (listType == "country" && rootLink.next.next != null) {
                    if (rootLink.next.next.data < data){
                        rootLink.next.next = new Link(data, username);
                    }
                }
                else{
                    // this link is null so we can just make a new link
                    rootLink.next.next = new Link(data, username);
                    // update currLowests for different list types.
                    if (listType == "active" || listType == "rating"){
                        currLowestActive = rootLink.next.next.data;
                        currLowestRating = rootLink.next.next.data;
                    }
                    else if (listType == "tv"){
                        currLowestTv = rootLink.next.next.data;
                    }
                }
            }
        }

        /// <summary>
        /// Percolates up through the link chain and updates values accordingly. 
        /// </summary>
        /// <param name="rootLink">The root link for this data type</param>
        /// <param name="data">The number ascribed to this link. Ex.: TV time, current country count, etc.</param>
        /// <param name="username">The name of the user who is associated with this data</param>
        /// <param name="listType">The type of list we are looking at. Ex: most active list, most TV time list, etc.</param>
        /// <param name="level"> How far down in the link chain we are</param>
        private void UpdateChain(Link currLink, int data, string username, string listType, int level)
        {
            if (level == 3){
                currLink.next = new Link(data, username);
                // update currLowests for each list type.
                if (listType == "active" || listType == "rating"){
                    currLowestActive = currLink.next.data;
                    currLowestRating = currLink.next.data;
                }
                else if (listType == "tv"){
                    currLowestTv = currLink.next.data;
                }
            }
            else{
                int tempData = currLink.data;
                string tempName = currLink.name;
                currLink.data = data;
                currLink.name = username;
                UpdateChain(currLink, tempData, tempName, listType, ++level);
            }
        }
        /// <summary>
        /// Compares the different rating of the inputted user that will be displayed as a result from selecting the "Compare" mode.
        /// </summary>
        private void CompareRatings()
        {
            // variables to count averageRating of following/followers and percentage of followers/following the user has a better rating than.
            int averageRating = 0, percentage = 0;
            // num users that are following/followers that play the gameMode, users that have lower rating than inputted user
            double usersWithLowerRating = 0, numUsersPlayVariant = 0;
            currLowestRating = 0;
            string lowestRatedUser = "N/A";
            Link ratingLink = new Link();
            Dictionary<string, int> ratingMap = new Dictionary<string, int>();
            ratingMap.Add(lowestRatedUser, 0);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + currTable, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            // If reader has rows, database has the data needed for this request
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    JObject perfs = JObject.Parse(reader["perfs"].ToString());
                    string currUsername = reader["username"].ToString();
                    string ratingString = (string) perfs.SelectToken(gameMode + ".rating");
                    var numGamesPlayed = perfs.SelectToken(gameMode + ".games");
                    if (ratingString != null && numGamesPlayed != null && (int) numGamesPlayed > 3)
                    {
                        int rating = Convert.ToInt32(ratingString);
                        if (currLowestRating < rating)
                        {
                            UpdateList(ratingLink, rating, currUsername, "rating");
                        }
                        if (averageRating == 0 || ratingMap[lowestRatedUser] > rating)
                        {
                            lowestRatedUser = currUsername;
                            if (!ratingMap.ContainsKey(currUsername))
                            {
                                ratingMap.Add(currUsername, rating);
                            }
                        }
                        if (rating < usernameRating)
                        {
                            usersWithLowerRating++;
                        }
                        averageRating += rating;
                        numUsersPlayVariant++;
                    }
                }
            }
            else
            {
                // This appears to be an entry that has no data in the database.
                MessageBox.Show("Something went wrong from collecting data from database.");
                if (dbConn.State == System.Data.ConnectionState.Open)
                {
                    dbConn.Close();
                }
                //Delete its value from database so it will be overwritten
                DeleteDatabaseEntry();
                window.ToggleControls("CompareRating");
                return;
            }
            reader.Close();
            dbConn.Close();
            if (numUsersPlayVariant != 0)
            {
                averageRating /= (int) numUsersPlayVariant;
                percentage = (int)(usersWithLowerRating / numUsersPlayVariant * 100);
            }
            window.SetupStatComparatorPage(username, relationship, gameMode, percentage, (int) numUsersPlayVariant, followerCount, averageRating, usernameRating, ratingLink, ratingMap[lowestRatedUser], lowestRatedUser);
            
        }

        /// <summary>
        /// Get the follower count and the rating of the inputted username.
        /// </summary>
        /// <param name="dataRequestType"> Says which mode we are in</param>
        /// <returns></returns>
        private async Task FindUserData(string dataRequestType, CancellationToken token)
        {
            try{
                using (HttpClient client = CreateClient()){
                    // Compose and send the request.
                    using (var request = new HttpRequestMessage(HttpMethod.Get, "api/user/" + username)){
                        // Create response that has username and relationship in URI.
                        //HttpResponseMessage response = await client.SendAsync(request, tokenSource);
                        HttpResponseMessage response = await client.SendAsync(request, tokenSource.Token);
                        token.ThrowIfCancellationRequested();
                        // Deal with the response
                        if (response.IsSuccessStatusCode){
                            String result = await response.Content.ReadAsStringAsync();
                            string[] lines = result.Split(new string[] { "\n" }, StringSplitOptions.None);
                            foreach (string s in lines){
                                if (s.Length > 1){
                                    JObject userData = JObject.Parse(s);
                                    // if we are in the compare ratings mode, get the rating
                                    if (dataRequestType == "CompareRatings"){
                                        var userRating = userData.SelectToken("perfs." + gameMode + ".rating");
                                        if (userRating != null){
                                            usernameRating = (int)userRating;
                                        }
                                        else{
                                            usernameRating = 0;
                                        }
                                    }
                                    followerCount = (int) userData.GetValue("nb" + relationship);
                                }
                            }
                        }
                        else{
                        }
                        token.ThrowIfCancellationRequested();
                    }
                }
            }
            catch (TaskCanceledException ex){
                Console.WriteLine("Task cancelled in FindUserData method");
                token.ThrowIfCancellationRequested();
            }
        }

        /// <summary>
        /// Turns the gamemode text in the form to correct syntax for requests to lichess API
        /// </summary>
        /// <returns> API friendly version of the inputted gameMode</returns>
        private string NormalizeGameMode(string gameMode)
        {
            switch (gameMode) {
                case "King of the Hill":
                    return "kingOfTheHill";
                case "Racing Kings":
                    return "racingKings";
                case "Three Check":
                    return "threeCheck";
                default:
                    return gameMode.ToLower();
            } 
        }

        /// <summary>
        /// Chooses the database table that will contain the data from the inputted username and relationship  
        /// </summary>
        /// <returns>If a database entry that contains the username and relationship already is populated, returns true.</returns>
        private bool SelectDatabaseTable(CancellationToken token)
        {
            // check if we already have this search in the database
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM table_master where player_username=@username AND relationship=@relationship", dbConn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@relationship", relationship);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            // If reader has rows, database has the data needed for this request
            if (reader.HasRows){
                while (reader.Read()){
                    currTable = reader["table_name"].ToString();
                }
                reader.Close();
                dbConn.Close();
                return false;
            }
            // If it does not, we must find which table in database we will populate with new data.
            else{
                reader.Close();
                // DateTime variable we will use to find oldest entry in table_master.
                DateTime time = new DateTime(9999,1,1);
                cmd = new MySqlCommand("SELECT * FROM table_master", dbConn);
                reader = cmd.ExecuteReader();
                while (reader.Read()){
                    // If the username is null, then this table is completely empty and we can just use this one
                    if (reader["player_username"].ToString() == ""){
                        currTable = reader["table_name"].ToString();
                        break;
                    }
                    // We want the data table we populate with new info to be the oldest entry in table_master. 
                    // We will check the date times for each table in table_master and pick the oldest.
                    if ((DateTime)reader["date_created"] < time && (!celebrityPlayerDictionary.ContainsKey(reader["player_username"].ToString()))){
                        currTable = reader["table_name"].ToString();
                        time = (DateTime)reader["date_created"];
                    }
                }
                reader.Close();
                // update table_master with new playername, date, and relationship for this new data
                cmd = new MySqlCommand("UPDATE table_master set player_username=@username, date_created=@time, relationship=@relationship where table_name=@table", dbConn);
                // sanitize variables
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@relationship", relationship);
                cmd.Parameters.AddWithValue("@time", DateTime.Now);
                cmd.Parameters.AddWithValue("@table", currTable);
                cmd.ExecuteNonQuery();
                dbConn.Close();
                // We clear that data previously stored in this tablebase we selected.
                DeleteDatabaseTable();
                if (token.IsCancellationRequested)
                {
                    DeleteDatabaseEntry();
                    token.ThrowIfCancellationRequested();
                }
            }
            return true;
        }

        /// <summary>
        /// Deletes all data related to this cancelled request from the table master
        /// </summary>
        private void DeleteDatabaseEntry()
        {
            // check if we are deleting a celebrity to avoid deleting them.
            if (!celebrityPlayerDictionary.ContainsKey(username))
            {
                dbConn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM table_master WHERE table_name= '" + currTable + "'", dbConn);
                cmd.ExecuteNonQuery();
                string query = string.Format("INSERT INTO table_master(table_name, player_username, date_created, relationship) values('{0}', {1}, {2}, {3})", currTable, ToDBNull(null), ToDBNull(null), ToDBNull(null));
                cmd = new MySqlCommand(query, dbConn);
                cmd.ExecuteNonQuery();
                dbConn.Close();
            }
        }

        /// <summary>
        /// Deletes all data from currTable
        /// </summary>
        private void DeleteDatabaseTable()
        {
            dbConn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM " + currTable, dbConn);
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        /// <summary>
        /// Checks if the user has connection to internet.
        /// </summary>
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Populates a database table with the requested data. 
        /// </summary>
        private async Task<string> PopulateDatabase(CancellationToken token)
        {
            try
            {
                using (HttpClient client = CreateClient())
                {
                    using (var request = new HttpRequestMessage(HttpMethod.Get, "api/user/" + username + "/" + relationship.ToLower()))
                    {
                        // Create response that has username and relationship in URI.
                        HttpResponseMessage response = await client.SendAsync(request, tokenSource.Token);
                        token.ThrowIfCancellationRequested();
                        // Deal with the response
                        if (response.IsSuccessStatusCode)
                        {
                            String result = await response.Content.ReadAsStringAsync();
                            string[] lines = result.Split(new string[] { "\n" }, StringSplitOptions.None);
                            // insert items into database
                            foreach (string s in lines)
                            {
                                // If cancellation token is requested to end (user presses "stop"), delete the new entry we made to table_master table for this request.
                                if (token.IsCancellationRequested)
                                {
                                    DeleteDatabaseEntry();
                                    token.ThrowIfCancellationRequested();
                                }
                                if (s.Length > 1)
                                {
                                    JObject userData = JObject.Parse(s);
                                    dbConn.Open();
                                    string query = string.Format("INSERT INTO {0}(username,perfs,play_time,country) values('{1}', '{2}', '{3}', {4})", currTable, userData["id"], userData["perfs"], userData["playTime"], ToDBNull(userData.SelectToken("profile.country")));

                                    MySqlCommand cmd = new MySqlCommand(query, dbConn);
                                    cmd.ExecuteNonQuery();
                                    dbConn.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("There was an error with populating the database. " + "\n" + "Reason: " + response.ReasonPhrase);
                        }
                    }
                }
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("task cancelled in PopulateDatabase.");
            }
            return "";
        }

        /// <summary>
        /// Checks if the passed in value is null and return DB-friendly version of null if it is.
        /// </summary>
        public static object ToDBNull(object value)
        {
            if (null != value)
                return "'" + value + "'";
            
            return "NULL";
        }

        /// <summary>
        /// Initiliazes the MySQL database I will be inserting data into.
        /// </summary>
        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            // Removed password & database for security reasons. 
            //builder.Password = ;
            //builder.Database = ;

            string connString = builder.ToString();

            builder = null;

            dbConn = new MySqlConnection(connString);
        }

        /// <summary>
        /// Creates an HttpClient for communicating with the server.
        /// </summary>
        private HttpClient CreateClient()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://lichess.org/");
            client.Timeout = TimeSpan.FromMinutes(60);

            // Tell the server that the client will accept this particular type of response data
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/x-ndjson");
            // Removed lichess token ID for security reasons
            //client.DefaultRequestHeaders.Add("Authorization", "Bearer AZun8rp2LcQ680sx");

            // There is more client configuration to do, depending on the request.
            return client;
        }

        // ** UNUSED CODE THAT I PLAN TO USE ON NEXT PROJECT. Works with data from API as it comes in instead of waiting for all data to come in before processing it. **
        /*private static T DeserializeJsonFromStream<T>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
                return default(T);

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                var searchResult = js.Deserialize<T>(jtr);
                return searchResult;
            }
        }

        private static async Task<string> StreamToStringAsync(Stream stream)
        {
            string content = null;

            if (stream != null)
                using (var sr = new StreamReader(stream))
                    content = await sr.ReadToEndAsync();

            return content;
        }*/
    }

}
