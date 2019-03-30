namespace PlannerUI
{
    partial class TournamentViewerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unPlayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoretextBox = new System.Windows.Forms.TextBox();
            this.teamtwoScoretextBox = new System.Windows.Forms.TextBox();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(134, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentName.Location = new System.Drawing.Point(203, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(92, 30);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            this.tournamentName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundLabel.Location = new System.Drawing.Point(21, 67);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(80, 30);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round:";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(152, 64);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(169, 38);
            this.roundDropDown.TabIndex = 3;
            // 
            // unPlayedOnlyCheckBox
            // 
            this.unPlayedOnlyCheckBox.AutoSize = true;
            this.unPlayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unPlayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unPlayedOnlyCheckBox.Location = new System.Drawing.Point(167, 115);
            this.unPlayedOnlyCheckBox.Name = "unPlayedOnlyCheckBox";
            this.unPlayedOnlyCheckBox.Size = new System.Drawing.Size(113, 23);
            this.unPlayedOnlyCheckBox.TabIndex = 4;
            this.unPlayedOnlyCheckBox.Text = "Unplayed only";
            this.unPlayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchListBox
            // 
            this.matchListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchListBox.FormattingEnabled = true;
            this.matchListBox.ItemHeight = 30;
            this.matchListBox.Location = new System.Drawing.Point(28, 148);
            this.matchListBox.Name = "matchListBox";
            this.matchListBox.Size = new System.Drawing.Size(293, 272);
            this.matchListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamOneName.Location = new System.Drawing.Point(392, 153);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(135, 30);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamTwoName.Location = new System.Drawing.Point(392, 313);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(134, 30);
            this.teamTwoName.TabIndex = 7;
            this.teamTwoName.Text = "<team two>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(392, 218);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(68, 30);
            this.teamOneScoreLabel.TabIndex = 8;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(392, 374);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(68, 30);
            this.teamTwoScoreLabel.TabIndex = 9;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamOneScoretextBox
            // 
            this.teamOneScoretextBox.Location = new System.Drawing.Point(493, 215);
            this.teamOneScoretextBox.Name = "teamOneScoretextBox";
            this.teamOneScoretextBox.Size = new System.Drawing.Size(100, 36);
            this.teamOneScoretextBox.TabIndex = 10;
            // 
            // teamtwoScoretextBox
            // 
            this.teamtwoScoretextBox.Location = new System.Drawing.Point(493, 369);
            this.teamtwoScoretextBox.Name = "teamtwoScoretextBox";
            this.teamtwoScoretextBox.Size = new System.Drawing.Size(100, 36);
            this.teamtwoScoretextBox.TabIndex = 11;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.versusLabel.Location = new System.Drawing.Point(462, 275);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(58, 30);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-Vs.-";
            this.versusLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.scoreButton.Location = new System.Drawing.Point(630, 282);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(133, 69);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 477);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamtwoScoretextBox);
            this.Controls.Add(this.teamOneScoretextBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchListBox);
            this.Controls.Add(this.unPlayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unPlayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoretextBox;
        private System.Windows.Forms.TextBox teamtwoScoretextBox;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

