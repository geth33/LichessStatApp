using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessFollowerApp
{
    public partial class ChessForm : Form, IStatInterface
    {
        public ChessForm()
        {
            InitializeComponent();
        }

        List<Panel> listPanel = new List<Panel>();

        public event Action<string, string, string> SubmitRatingComparatorEvent;
        public event Action<string, string> SubmitFollowerStatEvent;

        public event Action CancelButtonHit;
        private int apiTimeLeft;
        private int databaseTimeLeft;

        private void OnLoad(object sender, EventArgs e)
        {
            Console.WriteLine("ChessForm Load method entered");
            listPanel.Add(HomePanel);
            listPanel.Add(RatingComparatorPanel);
            listPanel.Add(ComparatorResultsPanel);
            listPanel[0].Visible = true;
        }

        public void ToggleControls(string mode)
        {
            if (mode == "FollowerStat")
            {
                FollowerStatSubmitButton.Enabled = !FollowerStatSubmitButton.Enabled;
                FollowerStatCancelButton.Enabled = !FollowerStatCancelButton.Enabled;
                FollowerStatHomeButton.Enabled = !FollowerStatHomeButton.Enabled;
            }
            else
            {
                CompareRatingsButton.Enabled = !CompareRatingsButton.Enabled;
                ComparatorCancelButton.Enabled = !ComparatorCancelButton.Enabled;
                Submit.Enabled = !Submit.Enabled;
                RatingHomeButton.Enabled = !RatingHomeButton.Enabled;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // SUBMIT RATING COMPARATOR
            if (SubmitRatingComparatorEvent != null)
            {
                ToggleControls("CompareRatings");
                SubmitRatingComparatorEvent(RatingComparatorUsername.Text, RelationBox.Text, ChessModeBox.Text);
                Console.WriteLine(RatingComparatorUsername.Text + " " + RelationBox.Text + " " + ChessModeBox.Text);
            }
        }

        private void FollowerStatSubmitButton_Click(object sender, EventArgs e)
        {
            // SUBMIT FOLLOWER RATING BUTTON
            if (SubmitFollowerStatEvent != null)
            {
                ToggleControls("FollowerStat");
                SubmitFollowerStatEvent(usernameTextbox.Text, RelationComboBox.Text);
            }
        }

        /// <summary>
        /// Method that is used to switch between the application's different pages.
        /// </summary>
        private void ChangePage(int pageNum)
        {
            switch (pageNum)
            {
                case 0:
                    {
                        HomePanel.Invoke((MethodInvoker)(() => {
                            HomePanel.Visible = true;
                            CompareRatingsButton.Enabled = true;
                            HomePanel.BringToFront();
                            ComparatorCancelButton.Enabled = false;
                        }));
                        ComparatorResultsPanel.Invoke((MethodInvoker)(() => { ComparatorResultsPanel.Visible = false; }));
                        FollowerStatsResultsPanel.Invoke((MethodInvoker)(() => { FollowerStatsResultsPanel.Visible = false; }));
                        FollowerStatsPanel.Invoke((MethodInvoker)(() => { FollowerStatsPanel.Visible = false; }));
                        RatingComparatorPanel.Invoke((MethodInvoker)(() => { RatingComparatorPanel.Visible = false; }));
                        break;
                    }
                case 1:
                    {
                        HomePanel.Invoke((MethodInvoker)(() => { HomePanel.Visible = false; }));
                        RatingComparatorPanel.Invoke((MethodInvoker)(() => {
                            RatingComparatorPanel.Enabled = true;
                            RatingComparatorPanel.Visible = true;
                            RatingComparatorPanel.BringToFront();
                        }));
                        ComparatorResultsPanel.Invoke((MethodInvoker)(() => { ComparatorResultsPanel.Visible = false; }));
                        break;
                    }
                case 2:
                    {
                        RatingComparatorPanel.Invoke((MethodInvoker)(() => { RatingComparatorPanel.Visible = false;
                            ToggleControls("RatingComparator");
                        }));
                        ComparatorResultsPanel.Invoke((MethodInvoker)(() => { ComparatorResultsPanel.Visible = true; }));
                        break;
                    }
                case 3:
                    {
                        HomePanel.Invoke((MethodInvoker)(() => { HomePanel.Visible = false; }));
                        FollowerStatsPanel.Invoke((MethodInvoker)(() => {
                            FollowerStatsPanel.Visible = true;
                            FollowerStatsPanel.BringToFront();
                            FollowerStatsPanel.Enabled = true;
                            FollowerStatCancelButton.Enabled = false;
                        }));
                        FollowerStatsResultsPanel.Invoke((MethodInvoker)(() => { FollowerStatsResultsPanel.Visible = false; }));
                        break;
                    }
                case 4:
                    {
                        FollowerStatsPanel.Invoke((MethodInvoker)(() => { FollowerStatsPanel.Visible = false;
                            ToggleControls("FollowerStat");
                        }));
                        FollowerStatsResultsPanel.Invoke((MethodInvoker)(() => { FollowerStatsResultsPanel.Visible = true;
                        }));
                        break;
                    }

            }

        }

        /// <summary>
        /// Sets up the results page for the StatComparator mode
        /// </summary>
        public void SetupStatComparatorPage(string username, string relation, string variant, int percentage,int numUsersPlayVariant, int followerCount, int averageRating, int userRating, Link ratingLink, int lowestRating, string lowestName)
        {
            RatingComparatorPanel.Invoke((MethodInvoker)(() => {
                RatingComparatorTimer.Stop();
                RatingComparatorProgressLabel.Visible = false;
            }));
            ComparatorResultsPanel.Invoke((MethodInvoker)(() => {
                ComparatorResultsPanel.Visible = true;
                Title.Text = char.ToUpper(username[0]) + username.Substring(1) + "'s";
                FollowerLabel.Text = followerCount + " " + relation;
                ComparatorStatementLabel1.Text = username + " has a better " + variant + " rating";
                if (relation == "Following")
                {
                    ComparatorStatementLabel2.Text = "than " + percentage + "% of those they follow.";
                }
                else
                {
                    ComparatorStatementLabel2.Text = "than " + percentage + "% of their followers.";
                }
                PlayerCountLabel.Text = "# of " + relation +  " that have " + variant +  " ratings: " + numUsersPlayVariant;
                UsernameRatingLabel.Text = username + "'s " + variant +  " rating: " + userRating;
                AvgRatingLabel.Text = "Average " + variant +  " rating: " + averageRating;
                string spaceString = "                             ";
                string ratingOutputString = GetOutputString(ratingLink, false, spaceString);
                HighestRatingLabel.Text = "Highest " + variant +  " rating: " + ratingOutputString;
                LowestRatingLabel.Text = "Lowest " + variant +  " rating: " + lowestRating + " (" + lowestName + ")";
            }));
            ChangePage(2);
        }

        /// <summary>
        /// Sets up the results page for the FollowerStats mode
        /// </summary>
        public void SetupFollowerStatPage(string username, string relationship, int followerCount, Link mostActiveLinkRoot, Link mostTvLinkRoot, Link countryLinkRoot, Dictionary<int, int> ratingMap)
        {
            FollowerStatsPanel.Invoke((MethodInvoker)(() => {
                FollowerStatTimer.Stop();
                FollowerStatProgressLabel.Visible = false;
            }));
            FollowerStatsResultsPanel.Invoke((MethodInvoker)(() => {
                FollowerStatsResultsPanel.Visible = true;
                TitleUsernameLabel.Text = char.ToUpper(username[0]) + username.Substring(1) + "'s";
                FollowerStatFollowersLabel.Text = followerCount + " " + relationship;
                string tvOutputString = GetOutputString(mostTvLinkRoot, true, "");
                string timePlayedOutputString = GetOutputString(mostActiveLinkRoot, true, "");
                string countryOutputString = GetOutputString(countryLinkRoot, false, "");
                FollowerStatCountryLabel.Text = "Most popular countries: \n" + countryOutputString;
                TVLabel.Text = "Most time on TV: \n" + tvOutputString;
                TimePlayedLabel.Text = "Most time played: \n" + timePlayedOutputString;
                RatingChart.Series.Clear();
                RatingChart.ChartAreas.Clear();
                RatingChart.Legends.Clear();
                RatingChart.ChartAreas.Add("ChartArea1");
                RatingChart.Series.Add("Frequency");
                foreach (int key in ratingMap.Keys)
                {
                    if ((ratingMap[key] != 0 || key < 2000) && relationship == "Followers")
                    {
                        RatingChart.Series["Frequency"].Points.AddXY(key, ratingMap[key]);
                    }
                    else if ((ratingMap[key] != 0 || key > 1400) && relationship == "Following")
                    {
                        RatingChart.Series["Frequency"].Points.AddXY(key, ratingMap[key]);
                    }
                }
            }));
            ChangePage(4);
        }

        private string GetOutputString(Link currLink, bool isTimeRelated, string spaceString)
        {
            if (currLink.data == 0)
            {
                return "";
            }
            else if (currLink.next == null)
            {
                if (!isTimeRelated)
                {
                    return currLink.name + " (" + currLink.data + ")\n";
                }
                return currLink.name + " (" + ConvertToDatimeFormat(currLink.data) + ")\n";
            }
            else if (currLink.next.next == null)
            {
                if (!isTimeRelated)
                {
                    return currLink.name + " (" + currLink.data + ")\n" + spaceString + currLink.next.name + " (" + currLink.next.data + ")\n";
                }
                return currLink.name + " (" + ConvertToDatimeFormat(currLink.data) + ")\n" + currLink.next.name + " (" + ConvertToDatimeFormat(currLink.next.data) + ")\n"; 
            }
            else
            {
                if (!isTimeRelated)
                {
                    return currLink.name + " (" + currLink.data + ")\n" + spaceString + currLink.next.name + " (" + currLink.next.data + ")\n" + spaceString + currLink.next.next.name + " (" + currLink.next.next.data + ")\n";
                }
                return currLink.name + " (" + ConvertToDatimeFormat(currLink.data) + ")\n" + currLink.next.name + " (" + ConvertToDatimeFormat(currLink.next.data) + ")\n"  + currLink.next.next.name + " (" + ConvertToDatimeFormat(currLink.next.next.data) + ")\n";
            }
        }

        private string ConvertToDatimeFormat(int data)
        {
            TimeSpan timePlaying = TimeSpan.FromSeconds(data);
            return string.Format("{0:%d}d {0:%h}h {0:%m}m", timePlaying);
        }


        //****** CODE BELOW IS USED FOR NAVIGATION PURPOSES ONLY ********
        private void CompareRatingsButton_Click(object sender, EventArgs e)
        {
            ChangePage(1);
        }

        private void FollowerStatsButton_Click(object sender, EventArgs e)
        {
            ChangePage(3);
        }

        private void FollowerStatResultsHomeButton_Click(object sender, EventArgs e)
        {
            ChangePage(0);
        }

        private void ComparatorResultHomeButton_Click(object sender, EventArgs e)
        {
            ChangePage(0);
        }

        private void ComparatorResultsBackButton_Click(object sender, EventArgs e)
        {
            ChangePage(1);
        }

        private void FollowerStatResultsBackButton_Click(object sender, EventArgs e)
        {
            ChangePage(3);
        }

        private void FollowerStatHomeButton_Click(object sender, EventArgs e)
        {
            ChangePage(0);
        }

        private void RatingHomeButton_Click(object sender, EventArgs e)
        {
            ChangePage(0);
        }

        public void StartTimer(int timeEstimate, string operationType)
        {
            Console.WriteLine("StartTimer entered");
            if (operationType == "FollowerStat")
            {
                FollowerStatsPanel.Invoke((MethodInvoker)(() => {
                    FollowerStatTimer.Start();
                    FollowerStatProgressLabel.Visible = true;
                    TimeSpan timeLeft = TimeSpan.FromSeconds(timeEstimate);
                    FollowerStatProgressLabel.Text = "Gathering data from lichess API. Estimated time: " + string.Format("{0:%m}m {0:%s}s", timeLeft);
                    apiTimeLeft = timeEstimate;
                    databaseTimeLeft = apiTimeLeft / 5;
                }));
            }
            else
            {
                RatingComparatorPanel.Invoke((MethodInvoker)(() => {
                    RatingComparatorTimer.Start();
                    RatingComparatorProgressLabel.Visible = true;
                    TimeSpan timeLeft = TimeSpan.FromSeconds(timeEstimate);
                    RatingComparatorProgressLabel.Text = "Gathering data from lichess API. Estimated time: " + string.Format("{0:%m}m {0:%s}s", timeLeft);
                    apiTimeLeft = timeEstimate;
                    databaseTimeLeft = apiTimeLeft / 4;
                }));
            }
        }

        private void FollowerStatTimer_Tick(object sender, EventArgs e)
        {
            if (apiTimeLeft != 0)
            {
                apiTimeLeft--;
                TimeSpan timeLeft = TimeSpan.FromSeconds(apiTimeLeft);
                FollowerStatProgressLabel.Text = "Gathering data from lichess API. Estimated time: " + string.Format("{0:%m}m {0:%s}s", timeLeft);
            }
            else
            { 
                if (databaseTimeLeft != 0)
                {
                    databaseTimeLeft--;
                    TimeSpan timeLeft = TimeSpan.FromSeconds(databaseTimeLeft);
                    FollowerStatProgressLabel.Text = "Inserting data into database. Estimated time: " + string.Format("{0:%m}m {0:%s}s", timeLeft);
                }
            }
        }

        private void RatingComparatorTimer_Tick(object sender, EventArgs e)
        {
            if (apiTimeLeft != 0)
            {
                apiTimeLeft--;
                TimeSpan timePlaying = TimeSpan.FromSeconds(apiTimeLeft);
                RatingComparatorProgressLabel.Text = "Gathering data from lichess API. Estimated time: " + string.Format("{0:%m}m {0:%s}s", timePlaying);
            }
            else
            {
                if (databaseTimeLeft != 0)
                {
                    databaseTimeLeft--;
                    TimeSpan timePlaying = TimeSpan.FromSeconds(databaseTimeLeft);
                    RatingComparatorProgressLabel.Text = "Inserting data into database. Estimated time: " + string.Format("{0:%m}m {0:%s}s", timePlaying);
                }
            }
        }
        private void FollowerStatCancelButton_Click(object sender, EventArgs e)
        {
            FollowerStatsPanel.Invoke((MethodInvoker)(() => {
                FollowerStatTimer.Stop();
                FollowerStatProgressLabel.Visible = false;
            }));
            if (CancelButtonHit != null)
            {
                CancelButtonHit();
            }
        }

        private void ComparatorCancelButton_Click(object sender, EventArgs e)
        {
            RatingComparatorPanel.Invoke((MethodInvoker)(() => {
                RatingComparatorTimer.Stop();
                RatingComparatorProgressLabel.Visible = false;
            }));
            if (CancelButtonHit != null)
            {
                CancelButtonHit();
            }
        }
    }


}
