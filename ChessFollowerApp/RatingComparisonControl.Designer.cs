namespace ChessFollowerApp
{
    partial class RatingComparisonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.relation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.relationBox = new System.Windows.Forms.ComboBox();
            this.chessModeBox = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.RatingHomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(681, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating Comparator";
            // 
            // relation
            // 
            this.relation.AutoSize = true;
            this.relation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.relation.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relation.Location = new System.Drawing.Point(131, 432);
            this.relation.Name = "relation";
            this.relation.Size = new System.Drawing.Size(360, 49);
            this.relation.TabIndex = 2;
            this.relation.Text = "Relation to user:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chess mode:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(611, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 56);
            this.textBox1.TabIndex = 4;
            // 
            // relationBox
            // 
            this.relationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationBox.FormattingEnabled = true;
            this.relationBox.Items.AddRange(new object[] {
            "Followers",
            "Following"});
            this.relationBox.Location = new System.Drawing.Point(611, 432);
            this.relationBox.Name = "relationBox";
            this.relationBox.Size = new System.Drawing.Size(501, 57);
            this.relationBox.TabIndex = 8;
            // 
            // chessModeBox
            // 
            this.chessModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chessModeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chessModeBox.FormattingEnabled = true;
            this.chessModeBox.Items.AddRange(new object[] {
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
            this.chessModeBox.Location = new System.Drawing.Point(611, 584);
            this.chessModeBox.Name = "chessModeBox";
            this.chessModeBox.Size = new System.Drawing.Size(501, 57);
            this.chessModeBox.TabIndex = 9;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(336, 783);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(251, 84);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(752, 783);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(251, 84);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // RatingHomeButton
            // 
            this.RatingHomeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingHomeButton.Location = new System.Drawing.Point(536, 932);
            this.RatingHomeButton.Name = "RatingHomeButton";
            this.RatingHomeButton.Size = new System.Drawing.Size(251, 84);
            this.RatingHomeButton.TabIndex = 12;
            this.RatingHomeButton.Text = "Home";
            this.RatingHomeButton.UseVisualStyleBackColor = true;
            this.RatingHomeButton.Click += new System.EventHandler(this.RatingHomeButton_Click);
            // 
            // RatingComparisonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChessFollowerApp.Properties.Resources.lichessHomeV2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.RatingHomeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.chessModeBox);
            this.Controls.Add(this.relationBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.relation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "RatingComparisonControl";
            this.Size = new System.Drawing.Size(1374, 1112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label relation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox relationBox;
        private System.Windows.Forms.ComboBox chessModeBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button RatingHomeButton;
    }
}
