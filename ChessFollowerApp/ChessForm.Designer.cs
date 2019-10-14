namespace ChessFollowerApp
{
    partial class ChessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessForm));
            this.RatingComparatorPanel = new System.Windows.Forms.Panel();
            this.RatingComparatorProgressLabel = new System.Windows.Forms.Label();
            this.RatingHomeButton = new System.Windows.Forms.Button();
            this.ComparatorCancelButton = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.ChessModeBox = new System.Windows.Forms.ComboBox();
            this.RelationBox = new System.Windows.Forms.ComboBox();
            this.RatingComparatorUsername = new System.Windows.Forms.TextBox();
            this.chessModeLabel = new System.Windows.Forms.Label();
            this.relationToUserLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.RatingComparatorTitle = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.FollowerStatsButton = new System.Windows.Forms.Button();
            this.CompareRatingsButton = new System.Windows.Forms.Button();
            this.HomeTitle2 = new System.Windows.Forms.Label();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.FollowerStatsPanel = new System.Windows.Forms.Panel();
            this.FollowerStatProgressLabel = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.FollowerStatHomeButton = new System.Windows.Forms.Button();
            this.FollowerStatCancelButton = new System.Windows.Forms.Button();
            this.FollowerStatSubmitButton = new System.Windows.Forms.Button();
            this.RelationComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComparatorResultsPanel = new System.Windows.Forms.Panel();
            this.PlayerCountLabel = new System.Windows.Forms.Label();
            this.LowestRatingLabel = new System.Windows.Forms.Label();
            this.FollowerLabel = new System.Windows.Forms.Label();
            this.HighestRatingLabel = new System.Windows.Forms.Label();
            this.AvgRatingLabel = new System.Windows.Forms.Label();
            this.UsernameRatingLabel = new System.Windows.Forms.Label();
            this.ComparatorStatementLabel2 = new System.Windows.Forms.Label();
            this.ComparatorStatementLabel1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ComparatorResultsBackButton = new System.Windows.Forms.Button();
            this.ComparatorResultHomeButton = new System.Windows.Forms.Button();
            this.ComparatorResultsTitle = new System.Windows.Forms.Label();
            this.FollowerStatsResultsPanel = new System.Windows.Forms.Panel();
            this.TimePlayedLabel = new System.Windows.Forms.Label();
            this.TVLabel = new System.Windows.Forms.Label();
            this.MostRecentLabel = new System.Windows.Forms.Label();
            this.TitleUsernameLabel = new System.Windows.Forms.Label();
            this.FollowerStatCountryLabel = new System.Windows.Forms.Label();
            this.FollowerStatFollowersLabel = new System.Windows.Forms.Label();
            this.RatingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FollowerStatResultsBackButton = new System.Windows.Forms.Button();
            this.FollowerStatResultsHomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FollowerStatTimer = new System.Windows.Forms.Timer(this.components);
            this.RatingComparatorTimer = new System.Windows.Forms.Timer(this.components);
            this.RatingComparatorPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.FollowerStatsPanel.SuspendLayout();
            this.ComparatorResultsPanel.SuspendLayout();
            this.FollowerStatsResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // RatingComparatorPanel
            // 
            this.RatingComparatorPanel.BackgroundImage = global::ChessFollowerApp.Properties.Resources.lichessHomeV2;
            this.RatingComparatorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RatingComparatorPanel.Controls.Add(this.RatingComparatorProgressLabel);
            this.RatingComparatorPanel.Controls.Add(this.RatingHomeButton);
            this.RatingComparatorPanel.Controls.Add(this.ComparatorCancelButton);
            this.RatingComparatorPanel.Controls.Add(this.Submit);
            this.RatingComparatorPanel.Controls.Add(this.ChessModeBox);
            this.RatingComparatorPanel.Controls.Add(this.RelationBox);
            this.RatingComparatorPanel.Controls.Add(this.RatingComparatorUsername);
            this.RatingComparatorPanel.Controls.Add(this.chessModeLabel);
            this.RatingComparatorPanel.Controls.Add(this.relationToUserLabel);
            this.RatingComparatorPanel.Controls.Add(this.usernameLabel);
            this.RatingComparatorPanel.Controls.Add(this.RatingComparatorTitle);
            this.RatingComparatorPanel.Location = new System.Drawing.Point(2, 1);
            this.RatingComparatorPanel.Name = "RatingComparatorPanel";
            this.RatingComparatorPanel.Size = new System.Drawing.Size(1387, 1113);
            this.RatingComparatorPanel.TabIndex = 11;
            this.RatingComparatorPanel.Visible = false;
            // 
            // RatingComparatorProgressLabel
            // 
            this.RatingComparatorProgressLabel.AutoSize = true;
            this.RatingComparatorProgressLabel.Location = new System.Drawing.Point(409, 754);
            this.RatingComparatorProgressLabel.Name = "RatingComparatorProgressLabel";
            this.RatingComparatorProgressLabel.Size = new System.Drawing.Size(258, 32);
            this.RatingComparatorProgressLabel.TabIndex = 17;
            this.RatingComparatorProgressLabel.Text = "Current progress....";
            this.RatingComparatorProgressLabel.Visible = false;
            // 
            // RatingHomeButton
            // 
            this.RatingHomeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingHomeButton.Location = new System.Drawing.Point(574, 950);
            this.RatingHomeButton.Name = "RatingHomeButton";
            this.RatingHomeButton.Size = new System.Drawing.Size(251, 84);
            this.RatingHomeButton.TabIndex = 13;
            this.RatingHomeButton.Text = "Home";
            this.RatingHomeButton.UseVisualStyleBackColor = true;
            this.RatingHomeButton.Click += new System.EventHandler(this.RatingHomeButton_Click);
            // 
            // ComparatorCancelButton
            // 
            this.ComparatorCancelButton.Enabled = false;
            this.ComparatorCancelButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparatorCancelButton.Location = new System.Drawing.Point(762, 837);
            this.ComparatorCancelButton.Name = "ComparatorCancelButton";
            this.ComparatorCancelButton.Size = new System.Drawing.Size(251, 84);
            this.ComparatorCancelButton.TabIndex = 12;
            this.ComparatorCancelButton.Text = "Cancel";
            this.ComparatorCancelButton.UseVisualStyleBackColor = true;
            this.ComparatorCancelButton.Click += new System.EventHandler(this.ComparatorCancelButton_Click);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(379, 837);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(251, 84);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // ChessModeBox
            // 
            this.ChessModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChessModeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChessModeBox.FormattingEnabled = true;
            this.ChessModeBox.Items.AddRange(new object[] {
            "Bullet",
            "Blitz",
            "Rapid",
            "Classical",
            "Correspondence",
            "Puzzle",
            "Crazyhouse",
            "Chess960",
            "King of the Hill",
            "Three Check",
            "Antichess",
            "Atomic",
            "Horde",
            "Racing Kings"});
            this.ChessModeBox.Location = new System.Drawing.Point(631, 632);
            this.ChessModeBox.Name = "ChessModeBox";
            this.ChessModeBox.Size = new System.Drawing.Size(501, 57);
            this.ChessModeBox.TabIndex = 10;
            // 
            // RelationBox
            // 
            this.RelationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelationBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationBox.FormattingEnabled = true;
            this.RelationBox.Items.AddRange(new object[] {
            "Followers",
            "Following"});
            this.RelationBox.Location = new System.Drawing.Point(631, 461);
            this.RelationBox.Name = "RelationBox";
            this.RelationBox.Size = new System.Drawing.Size(501, 57);
            this.RelationBox.TabIndex = 9;
            // 
            // RatingComparatorUsername
            // 
            this.RatingComparatorUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingComparatorUsername.Location = new System.Drawing.Point(631, 285);
            this.RatingComparatorUsername.Name = "RatingComparatorUsername";
            this.RatingComparatorUsername.Size = new System.Drawing.Size(501, 56);
            this.RatingComparatorUsername.TabIndex = 6;
            // 
            // chessModeLabel
            // 
            this.chessModeLabel.AutoSize = true;
            this.chessModeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chessModeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chessModeLabel.Location = new System.Drawing.Point(213, 632);
            this.chessModeLabel.Name = "chessModeLabel";
            this.chessModeLabel.Size = new System.Drawing.Size(285, 49);
            this.chessModeLabel.TabIndex = 5;
            this.chessModeLabel.Text = "Chess mode:";
            // 
            // relationToUserLabel
            // 
            this.relationToUserLabel.AutoSize = true;
            this.relationToUserLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.relationToUserLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationToUserLabel.Location = new System.Drawing.Point(138, 461);
            this.relationToUserLabel.Name = "relationToUserLabel";
            this.relationToUserLabel.Size = new System.Drawing.Size(360, 49);
            this.relationToUserLabel.TabIndex = 4;
            this.relationToUserLabel.Text = "Relation to user:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(255, 285);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(243, 49);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username:";
            // 
            // RatingComparatorTitle
            // 
            this.RatingComparatorTitle.AutoSize = true;
            this.RatingComparatorTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RatingComparatorTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RatingComparatorTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingComparatorTitle.Location = new System.Drawing.Point(401, 61);
            this.RatingComparatorTitle.Name = "RatingComparatorTitle";
            this.RatingComparatorTitle.Size = new System.Drawing.Size(681, 84);
            this.RatingComparatorTitle.TabIndex = 2;
            this.RatingComparatorTitle.Text = "Rating Comparator";
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.HomePanel.BackgroundImage = global::ChessFollowerApp.Properties.Resources.lichessHomeV2;
            this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePanel.Controls.Add(this.FollowerStatsButton);
            this.HomePanel.Controls.Add(this.CompareRatingsButton);
            this.HomePanel.Controls.Add(this.HomeTitle2);
            this.HomePanel.Controls.Add(this.HomeTitle);
            this.HomePanel.Location = new System.Drawing.Point(1, 1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1385, 1110);
            this.HomePanel.TabIndex = 15;
            // 
            // FollowerStatsButton
            // 
            this.FollowerStatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowerStatsButton.Location = new System.Drawing.Point(825, 533);
            this.FollowerStatsButton.Name = "FollowerStatsButton";
            this.FollowerStatsButton.Size = new System.Drawing.Size(388, 104);
            this.FollowerStatsButton.TabIndex = 10;
            this.FollowerStatsButton.Text = "Follower Stats";
            this.FollowerStatsButton.UseVisualStyleBackColor = true;
            this.FollowerStatsButton.Click += new System.EventHandler(this.FollowerStatsButton_Click);
            // 
            // CompareRatingsButton
            // 
            this.CompareRatingsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareRatingsButton.Location = new System.Drawing.Point(261, 533);
            this.CompareRatingsButton.Name = "CompareRatingsButton";
            this.CompareRatingsButton.Size = new System.Drawing.Size(388, 104);
            this.CompareRatingsButton.TabIndex = 5;
            this.CompareRatingsButton.Text = "Compare Ratings";
            this.CompareRatingsButton.UseVisualStyleBackColor = true;
            this.CompareRatingsButton.Click += new System.EventHandler(this.CompareRatingsButton_Click);
            // 
            // HomeTitle2
            // 
            this.HomeTitle2.AutoSize = true;
            this.HomeTitle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HomeTitle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeTitle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle2.Location = new System.Drawing.Point(367, 204);
            this.HomeTitle2.Name = "HomeTitle2";
            this.HomeTitle2.Size = new System.Drawing.Size(637, 84);
            this.HomeTitle2.TabIndex = 4;
            this.HomeTitle2.Text = "Follower Stat App";
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HomeTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(379, 82);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(616, 84);
            this.HomeTitle.TabIndex = 3;
            this.HomeTitle.Text = "Unofficial Lichess";
            // 
            // FollowerStatsPanel
            // 
            this.FollowerStatsPanel.BackgroundImage = global::ChessFollowerApp.Properties.Resources.lichessHomeV2;
            this.FollowerStatsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FollowerStatsPanel.Controls.Add(this.FollowerStatProgressLabel);
            this.FollowerStatsPanel.Controls.Add(this.progressBar2);
            this.FollowerStatsPanel.Controls.Add(this.FollowerStatHomeButton);
            this.FollowerStatsPanel.Controls.Add(this.FollowerStatCancelButton);
            this.FollowerStatsPanel.Controls.Add(this.FollowerStatSubmitButton);
            this.FollowerStatsPanel.Controls.Add(this.RelationComboBox);
            this.FollowerStatsPanel.Controls.Add(this.usernameTextbox);
            this.FollowerStatsPanel.Controls.Add(this.label2);
            this.FollowerStatsPanel.Controls.Add(this.label3);
            this.FollowerStatsPanel.Controls.Add(this.label4);
            this.FollowerStatsPanel.Location = new System.Drawing.Point(5, 1);
            this.FollowerStatsPanel.Name = "FollowerStatsPanel";
            this.FollowerStatsPanel.Size = new System.Drawing.Size(1387, 1113);
            this.FollowerStatsPanel.TabIndex = 14;
            this.FollowerStatsPanel.Visible = false;
            // 
            // FollowerStatProgressLabel
            // 
            this.FollowerStatProgressLabel.AutoSize = true;
            this.FollowerStatProgressLabel.Location = new System.Drawing.Point(362, 635);
            this.FollowerStatProgressLabel.Name = "FollowerStatProgressLabel";
            this.FollowerStatProgressLabel.Size = new System.Drawing.Size(258, 32);
            this.FollowerStatProgressLabel.TabIndex = 16;
            this.FollowerStatProgressLabel.Text = "Current progress....";
            this.FollowerStatProgressLabel.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(289, 829);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(0, 0);
            this.progressBar2.TabIndex = 15;
            // 
            // FollowerStatHomeButton
            // 
            this.FollowerStatHomeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowerStatHomeButton.Location = new System.Drawing.Point(570, 855);
            this.FollowerStatHomeButton.Name = "FollowerStatHomeButton";
            this.FollowerStatHomeButton.Size = new System.Drawing.Size(251, 84);
            this.FollowerStatHomeButton.TabIndex = 13;
            this.FollowerStatHomeButton.Text = "Home";
            this.FollowerStatHomeButton.UseVisualStyleBackColor = true;
            this.FollowerStatHomeButton.Click += new System.EventHandler(this.FollowerStatHomeButton_Click);
            // 
            // FollowerStatCancelButton
            // 
            this.FollowerStatCancelButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowerStatCancelButton.Location = new System.Drawing.Point(761, 708);
            this.FollowerStatCancelButton.Name = "FollowerStatCancelButton";
            this.FollowerStatCancelButton.Size = new System.Drawing.Size(251, 84);
            this.FollowerStatCancelButton.TabIndex = 12;
            this.FollowerStatCancelButton.Text = "Cancel";
            this.FollowerStatCancelButton.UseVisualStyleBackColor = true;
            this.FollowerStatCancelButton.Click += new System.EventHandler(this.FollowerStatCancelButton_Click);
            // 
            // FollowerStatSubmitButton
            // 
            this.FollowerStatSubmitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowerStatSubmitButton.Location = new System.Drawing.Point(368, 708);
            this.FollowerStatSubmitButton.Name = "FollowerStatSubmitButton";
            this.FollowerStatSubmitButton.Size = new System.Drawing.Size(251, 84);
            this.FollowerStatSubmitButton.TabIndex = 11;
            this.FollowerStatSubmitButton.Text = "Submit";
            this.FollowerStatSubmitButton.UseVisualStyleBackColor = true;
            this.FollowerStatSubmitButton.Click += new System.EventHandler(this.FollowerStatSubmitButton_Click);
            // 
            // RelationComboBox
            // 
            this.RelationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelationComboBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationComboBox.FormattingEnabled = true;
            this.RelationComboBox.Items.AddRange(new object[] {
            "Followers",
            "Following"});
            this.RelationComboBox.Location = new System.Drawing.Point(631, 461);
            this.RelationComboBox.Name = "RelationComboBox";
            this.RelationComboBox.Size = new System.Drawing.Size(501, 57);
            this.RelationComboBox.TabIndex = 9;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(631, 285);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(501, 56);
            this.usernameTextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Relation to user:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(998, 84);
            this.label4.TabIndex = 2;
            this.label4.Text = "Follower/Following Statistics";
            // 
            // ComparatorResultsPanel
            // 
            this.ComparatorResultsPanel.Controls.Add(this.PlayerCountLabel);
            this.ComparatorResultsPanel.Controls.Add(this.LowestRatingLabel);
            this.ComparatorResultsPanel.Controls.Add(this.FollowerLabel);
            this.ComparatorResultsPanel.Controls.Add(this.HighestRatingLabel);
            this.ComparatorResultsPanel.Controls.Add(this.AvgRatingLabel);
            this.ComparatorResultsPanel.Controls.Add(this.UsernameRatingLabel);
            this.ComparatorResultsPanel.Controls.Add(this.ComparatorStatementLabel2);
            this.ComparatorResultsPanel.Controls.Add(this.ComparatorStatementLabel1);
            this.ComparatorResultsPanel.Controls.Add(this.Title);
            this.ComparatorResultsPanel.Controls.Add(this.ComparatorResultsBackButton);
            this.ComparatorResultsPanel.Controls.Add(this.ComparatorResultHomeButton);
            this.ComparatorResultsPanel.Controls.Add(this.ComparatorResultsTitle);
            this.ComparatorResultsPanel.Location = new System.Drawing.Point(2, 4);
            this.ComparatorResultsPanel.Name = "ComparatorResultsPanel";
            this.ComparatorResultsPanel.Size = new System.Drawing.Size(1387, 1116);
            this.ComparatorResultsPanel.TabIndex = 14;
            this.ComparatorResultsPanel.Visible = false;
            // 
            // PlayerCountLabel
            // 
            this.PlayerCountLabel.AutoSize = true;
            this.PlayerCountLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCountLabel.Location = new System.Drawing.Point(199, 497);
            this.PlayerCountLabel.Name = "PlayerCountLabel";
            this.PlayerCountLabel.Size = new System.Drawing.Size(493, 42);
            this.PlayerCountLabel.TabIndex = 32;
            this.PlayerCountLabel.Text = "# of Followers with ratings:";
            // 
            // LowestRatingLabel
            // 
            this.LowestRatingLabel.AutoSize = true;
            this.LowestRatingLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowestRatingLabel.Location = new System.Drawing.Point(233, 894);
            this.LowestRatingLabel.Name = "LowestRatingLabel";
            this.LowestRatingLabel.Size = new System.Drawing.Size(408, 42);
            this.LowestRatingLabel.TabIndex = 31;
            this.LowestRatingLabel.Text = "Lowest ______ rating:";
            // 
            // FollowerLabel
            // 
            this.FollowerLabel.AutoSize = true;
            this.FollowerLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowerLabel.Location = new System.Drawing.Point(559, 185);
            this.FollowerLabel.Name = "FollowerLabel";
            this.FollowerLabel.Size = new System.Drawing.Size(329, 60);
            this.FollowerLabel.TabIndex = 30;
            this.FollowerLabel.Text = "__ Followers";
            // 
            // HighestRatingLabel
            // 
            this.HighestRatingLabel.AutoSize = true;
            this.HighestRatingLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestRatingLabel.Location = new System.Drawing.Point(223, 730);
            this.HighestRatingLabel.Name = "HighestRatingLabel";
            this.HighestRatingLabel.Size = new System.Drawing.Size(418, 42);
            this.HighestRatingLabel.TabIndex = 29;
            this.HighestRatingLabel.Text = "Highest ______ rating:";
            // 
            // AvgRatingLabel
            // 
            this.AvgRatingLabel.AutoSize = true;
            this.AvgRatingLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgRatingLabel.Location = new System.Drawing.Point(310, 652);
            this.AvgRatingLabel.Name = "AvgRatingLabel";
            this.AvgRatingLabel.Size = new System.Drawing.Size(331, 42);
            this.AvgRatingLabel.TabIndex = 28;
            this.AvgRatingLabel.Text = "Avg _____ rating:";
            // 
            // UsernameRatingLabel
            // 
            this.UsernameRatingLabel.AutoSize = true;
            this.UsernameRatingLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameRatingLabel.Location = new System.Drawing.Point(296, 571);
            this.UsernameRatingLabel.Name = "UsernameRatingLabel";
            this.UsernameRatingLabel.Size = new System.Drawing.Size(345, 42);
            this.UsernameRatingLabel.TabIndex = 27;
            this.UsernameRatingLabel.Text = "Username\'s rating:";
            // 
            // ComparatorStatementLabel2
            // 
            this.ComparatorStatementLabel2.AutoSize = true;
            this.ComparatorStatementLabel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparatorStatementLabel2.Location = new System.Drawing.Point(384, 376);
            this.ComparatorStatementLabel2.Name = "ComparatorStatementLabel2";
            this.ComparatorStatementLabel2.Size = new System.Drawing.Size(647, 49);
            this.ComparatorStatementLabel2.TabIndex = 26;
            this.ComparatorStatementLabel2.Text = "than ____ % of their _______.";
            // 
            // ComparatorStatementLabel1
            // 
            this.ComparatorStatementLabel1.AutoSize = true;
            this.ComparatorStatementLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparatorStatementLabel1.Location = new System.Drawing.Point(294, 290);
            this.ComparatorStatementLabel1.Name = "ComparatorStatementLabel1";
            this.ComparatorStatementLabel1.Size = new System.Drawing.Size(677, 49);
            this.ComparatorStatementLabel1.TabIndex = 25;
            this.ComparatorStatementLabel1.Text = "_____ has a better _____ rating";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(555, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(434, 84);
            this.Title.TabIndex = 24;
            this.Title.Text = "Username\'s";
            // 
            // ComparatorResultsBackButton
            // 
            this.ComparatorResultsBackButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparatorResultsBackButton.Location = new System.Drawing.Point(303, 986);
            this.ComparatorResultsBackButton.Name = "ComparatorResultsBackButton";
            this.ComparatorResultsBackButton.Size = new System.Drawing.Size(251, 84);
            this.ComparatorResultsBackButton.TabIndex = 16;
            this.ComparatorResultsBackButton.Text = "Back";
            this.ComparatorResultsBackButton.UseVisualStyleBackColor = true;
            this.ComparatorResultsBackButton.Click += new System.EventHandler(this.ComparatorResultsBackButton_Click);
            // 
            // ComparatorResultHomeButton
            // 
            this.ComparatorResultHomeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparatorResultHomeButton.Location = new System.Drawing.Point(637, 986);
            this.ComparatorResultHomeButton.Name = "ComparatorResultHomeButton";
            this.ComparatorResultHomeButton.Size = new System.Drawing.Size(251, 84);
            this.ComparatorResultHomeButton.TabIndex = 14;
            this.ComparatorResultHomeButton.Text = "Home";
            this.ComparatorResultHomeButton.UseVisualStyleBackColor = true;
            this.ComparatorResultHomeButton.Click += new System.EventHandler(this.ComparatorResultHomeButton_Click);
            // 
            // ComparatorResultsTitle
            // 
            this.ComparatorResultsTitle.AutoSize = true;
            this.ComparatorResultsTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ComparatorResultsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComparatorResultsTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparatorResultsTitle.Location = new System.Drawing.Point(379, 82);
            this.ComparatorResultsTitle.Name = "ComparatorResultsTitle";
            this.ComparatorResultsTitle.Size = new System.Drawing.Size(709, 84);
            this.ComparatorResultsTitle.TabIndex = 3;
            this.ComparatorResultsTitle.Text = "Comparator Results";
            // 
            // FollowerStatsResultsPanel
            // 
            this.FollowerStatsResultsPanel.Controls.Add(this.TimePlayedLabel);
            this.FollowerStatsResultsPanel.Controls.Add(this.TVLabel);
            this.FollowerStatsResultsPanel.Controls.Add(this.MostRecentLabel);
            this.FollowerStatsResultsPanel.Controls.Add(this.TitleUsernameLabel);
            this.FollowerStatsResultsPanel.Controls.Add(this.FollowerStatCountryLabel);
            this.FollowerStatsResultsPanel.Controls.Add(this.FollowerStatFollowersLabel);
            this.FollowerStatsResultsPanel.Controls.Add(this.RatingChart);
            this.FollowerStatsResultsPanel.Controls.Add(this.FollowerStatResultsBackButton);
            this.FollowerStatsResultsPanel.Controls.Add(this.FollowerStatResultsHomeButton);
            this.FollowerStatsResultsPanel.Controls.Add(this.label1);
            this.FollowerStatsResultsPanel.Location = new System.Drawing.Point(1, 1);
            this.FollowerStatsResultsPanel.Name = "FollowerStatsResultsPanel";
            this.FollowerStatsResultsPanel.Size = new System.Drawing.Size(1387, 1113);
            this.FollowerStatsResultsPanel.TabIndex = 15;
            this.FollowerStatsResultsPanel.Visible = false;
            // 
            // TimePlayedLabel
            // 
            this.TimePlayedLabel.AutoSize = true;
            this.TimePlayedLabel.Location = new System.Drawing.Point(35, 687);
            this.TimePlayedLabel.Name = "TimePlayedLabel";
            this.TimePlayedLabel.Size = new System.Drawing.Size(237, 32);
            this.TimePlayedLabel.TabIndex = 26;
            this.TimePlayedLabel.Text = "Most time played:";
            // 
            // TVLabel
            // 
            this.TVLabel.AutoSize = true;
            this.TVLabel.Location = new System.Drawing.Point(35, 514);
            this.TVLabel.Name = "TVLabel";
            this.TVLabel.Size = new System.Drawing.Size(227, 32);
            this.TVLabel.TabIndex = 25;
            this.TVLabel.Text = "Most time on TV:";
            // 
            // MostRecentLabel
            // 
            this.MostRecentLabel.AutoSize = true;
            this.MostRecentLabel.Location = new System.Drawing.Point(35, 465);
            this.MostRecentLabel.Name = "MostRecentLabel";
            this.MostRecentLabel.Size = new System.Drawing.Size(0, 32);
            this.MostRecentLabel.TabIndex = 24;
            // 
            // TitleUsernameLabel
            // 
            this.TitleUsernameLabel.AutoSize = true;
            this.TitleUsernameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleUsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleUsernameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleUsernameLabel.Location = new System.Drawing.Point(484, 11);
            this.TitleUsernameLabel.Name = "TitleUsernameLabel";
            this.TitleUsernameLabel.Size = new System.Drawing.Size(434, 84);
            this.TitleUsernameLabel.TabIndex = 23;
            this.TitleUsernameLabel.Text = "Username\'s";
            // 
            // FollowerStatCountryLabel
            // 
            this.FollowerStatCountryLabel.AutoSize = true;
            this.FollowerStatCountryLabel.Location = new System.Drawing.Point(35, 348);
            this.FollowerStatCountryLabel.Name = "FollowerStatCountryLabel";
            this.FollowerStatCountryLabel.Size = new System.Drawing.Size(334, 32);
            this.FollowerStatCountryLabel.TabIndex = 19;
            this.FollowerStatCountryLabel.Text = "Most Common Countries:\r\n";
            // 
            // FollowerStatFollowersLabel
            // 
            this.FollowerStatFollowersLabel.AutoSize = true;
            this.FollowerStatFollowersLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowerStatFollowersLabel.Location = new System.Drawing.Point(527, 215);
            this.FollowerStatFollowersLabel.Name = "FollowerStatFollowersLabel";
            this.FollowerStatFollowersLabel.Size = new System.Drawing.Size(329, 60);
            this.FollowerStatFollowersLabel.TabIndex = 18;
            this.FollowerStatFollowersLabel.Text = "__ Followers";
            // 
            // RatingChart
            // 
            chartArea1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 80F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 10F;
            this.RatingChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "RatingLegend";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingChart.Legends.Add(legend1);
            this.RatingChart.Location = new System.Drawing.Point(426, 303);
            this.RatingChart.Name = "RatingChart";
            this.RatingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            this.RatingChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Gray,
        System.Drawing.Color.Silver};
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "RatingLegend";
            series1.Name = "Frequency";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ShadowOffset = 4;
            this.RatingChart.Series.Add(series1);
            this.RatingChart.Size = new System.Drawing.Size(939, 592);
            this.RatingChart.TabIndex = 16;
            this.RatingChart.Text = "chart1";
            title1.Name = "Average Rating";
            title1.Text = "Average Blitz Rating";
            this.RatingChart.Titles.Add(title1);
            // 
            // FollowerStatResultsBackButton
            // 
            this.FollowerStatResultsBackButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowerStatResultsBackButton.Location = new System.Drawing.Point(376, 955);
            this.FollowerStatResultsBackButton.Name = "FollowerStatResultsBackButton";
            this.FollowerStatResultsBackButton.Size = new System.Drawing.Size(251, 84);
            this.FollowerStatResultsBackButton.TabIndex = 15;
            this.FollowerStatResultsBackButton.Text = "Back";
            this.FollowerStatResultsBackButton.UseVisualStyleBackColor = true;
            this.FollowerStatResultsBackButton.Click += new System.EventHandler(this.FollowerStatResultsBackButton_Click);
            // 
            // FollowerStatResultsHomeButton
            // 
            this.FollowerStatResultsHomeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowerStatResultsHomeButton.Location = new System.Drawing.Point(771, 955);
            this.FollowerStatResultsHomeButton.Name = "FollowerStatResultsHomeButton";
            this.FollowerStatResultsHomeButton.Size = new System.Drawing.Size(251, 84);
            this.FollowerStatResultsHomeButton.TabIndex = 14;
            this.FollowerStatResultsHomeButton.Text = "Home";
            this.FollowerStatResultsHomeButton.UseVisualStyleBackColor = true;
            this.FollowerStatResultsHomeButton.Click += new System.EventHandler(this.FollowerStatResultsHomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 84);
            this.label1.TabIndex = 3;
            this.label1.Text = "Follower Stat Results";
            // 
            // FollowerStatTimer
            // 
            this.FollowerStatTimer.Interval = 1000;
            this.FollowerStatTimer.Tick += new System.EventHandler(this.FollowerStatTimer_Tick);
            // 
            // RatingComparatorTimer
            // 
            this.RatingComparatorTimer.Interval = 1000;
            this.RatingComparatorTimer.Tick += new System.EventHandler(this.RatingComparatorTimer_Tick);
            // 
            // ChessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ChessFollowerApp.Properties.Resources.lichessHomeV2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1355, 1025);
            this.Controls.Add(this.FollowerStatsResultsPanel);
            this.Controls.Add(this.ComparatorResultsPanel);
            this.Controls.Add(this.RatingComparatorPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.FollowerStatsPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(5600, 1400);
            this.MinimumSize = new System.Drawing.Size(1387, 1113);
            this.Name = "ChessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichessFollowerStats";
            this.RatingComparatorPanel.ResumeLayout(false);
            this.RatingComparatorPanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.FollowerStatsPanel.ResumeLayout(false);
            this.FollowerStatsPanel.PerformLayout();
            this.ComparatorResultsPanel.ResumeLayout(false);
            this.ComparatorResultsPanel.PerformLayout();
            this.FollowerStatsResultsPanel.ResumeLayout(false);
            this.FollowerStatsResultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel RatingComparatorPanel;
        private System.Windows.Forms.Label RatingComparatorTitle;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label relationToUserLabel;
        private System.Windows.Forms.Label chessModeLabel;
        private System.Windows.Forms.TextBox RatingComparatorUsername;
        private System.Windows.Forms.ComboBox RelationBox;
        private System.Windows.Forms.ComboBox ChessModeBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button ComparatorCancelButton;
        private System.Windows.Forms.Button RatingHomeButton;
        private System.Windows.Forms.Panel ComparatorResultsPanel;
        private System.Windows.Forms.Label ComparatorResultsTitle;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.Button FollowerStatsButton;
        private System.Windows.Forms.Button CompareRatingsButton;
        private System.Windows.Forms.Label HomeTitle2;
        private System.Windows.Forms.Panel FollowerStatsPanel;
        private System.Windows.Forms.Button FollowerStatHomeButton;
        private System.Windows.Forms.Button FollowerStatCancelButton;
        private System.Windows.Forms.Button FollowerStatSubmitButton;
        private System.Windows.Forms.ComboBox RelationComboBox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel FollowerStatsResultsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FollowerStatResultsHomeButton;
        private System.Windows.Forms.Button ComparatorResultHomeButton;
        private System.Windows.Forms.Button ComparatorResultsBackButton;
        private System.Windows.Forms.Button FollowerStatResultsBackButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart RatingChart;
        private System.Windows.Forms.Label FollowerStatCountryLabel;
        private System.Windows.Forms.Label FollowerStatFollowersLabel;
        private System.Windows.Forms.Label FollowerLabel;
        private System.Windows.Forms.Label HighestRatingLabel;
        private System.Windows.Forms.Label AvgRatingLabel;
        private System.Windows.Forms.Label UsernameRatingLabel;
        private System.Windows.Forms.Label ComparatorStatementLabel2;
        private System.Windows.Forms.Label ComparatorStatementLabel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TitleUsernameLabel;
        private System.Windows.Forms.Label LowestRatingLabel;
        private System.Windows.Forms.Label PlayerCountLabel;
        private System.Windows.Forms.Label TVLabel;
        private System.Windows.Forms.Label MostRecentLabel;
        private System.Windows.Forms.Label TimePlayedLabel;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label FollowerStatProgressLabel;
        private System.Windows.Forms.Timer FollowerStatTimer;
        private System.Windows.Forms.Label RatingComparatorProgressLabel;
        private System.Windows.Forms.Timer RatingComparatorTimer;
    }
}

