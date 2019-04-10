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
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.unPlayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.teamTwoNameLabel = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
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
            this.headerLabel.Size = new System.Drawing.Size(171, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentNameLabel.Location = new System.Drawing.Point(203, 9);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(118, 38);
            this.tournamentNameLabel.TabIndex = 1;
            this.tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundLabel.Location = new System.Drawing.Point(21, 67);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(103, 38);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round:";
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(152, 64);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(169, 45);
            this.roundComboBox.TabIndex = 3;
            this.roundComboBox.SelectedIndexChanged += new System.EventHandler(this.roundComboBox_SelectedIndexChanged);
            // 
            // unPlayedOnlyCheckBox
            // 
            this.unPlayedOnlyCheckBox.AutoSize = true;
            this.unPlayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unPlayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unPlayedOnlyCheckBox.Location = new System.Drawing.Point(167, 115);
            this.unPlayedOnlyCheckBox.Name = "unPlayedOnlyCheckBox";
            this.unPlayedOnlyCheckBox.Size = new System.Drawing.Size(137, 27);
            this.unPlayedOnlyCheckBox.TabIndex = 4;
            this.unPlayedOnlyCheckBox.Text = "Unplayed only";
            this.unPlayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.unPlayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.unPlayedOnlyCheckBox_CheckedChanged);
            // 
            // matchListBox
            // 
            this.matchListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchListBox.FormattingEnabled = true;
            this.matchListBox.ItemHeight = 37;
            this.matchListBox.Location = new System.Drawing.Point(28, 148);
            this.matchListBox.Name = "matchListBox";
            this.matchListBox.Size = new System.Drawing.Size(293, 261);
            this.matchListBox.TabIndex = 5;
            this.matchListBox.SelectedIndexChanged += new System.EventHandler(this.matchListBox_SelectedIndexChanged);
            // 
            // teamOneNameLabel
            // 
            this.teamOneNameLabel.AutoSize = true;
            this.teamOneNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamOneNameLabel.Location = new System.Drawing.Point(392, 153);
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            this.teamOneNameLabel.Size = new System.Drawing.Size(172, 38);
            this.teamOneNameLabel.TabIndex = 6;
            this.teamOneNameLabel.Text = "<team one>";
            // 
            // teamTwoNameLabel
            // 
            this.teamTwoNameLabel.AutoSize = true;
            this.teamTwoNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamTwoNameLabel.Location = new System.Drawing.Point(392, 313);
            this.teamTwoNameLabel.Name = "teamTwoNameLabel";
            this.teamTwoNameLabel.Size = new System.Drawing.Size(170, 38);
            this.teamTwoNameLabel.TabIndex = 7;
            this.teamTwoNameLabel.Text = "<team two>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(392, 218);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamOneScoreLabel.TabIndex = 8;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(392, 374);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamTwoScoreLabel.TabIndex = 9;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamOneScoreTextBox
            // 
            this.teamOneScoreTextBox.Location = new System.Drawing.Point(493, 215);
            this.teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            this.teamOneScoreTextBox.Size = new System.Drawing.Size(100, 43);
            this.teamOneScoreTextBox.TabIndex = 10;
            // 
            // teamTwoScoreTextBox
            // 
            this.teamTwoScoreTextBox.Location = new System.Drawing.Point(493, 369);
            this.teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            this.teamTwoScoreTextBox.Size = new System.Drawing.Size(100, 43);
            this.teamTwoScoreTextBox.TabIndex = 11;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.versusLabel.Location = new System.Drawing.Point(462, 275);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(73, 38);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-Vs.-";
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
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 477);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreTextBox);
            this.Controls.Add(this.teamOneScoreTextBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamTwoNameLabel);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.matchListBox);
            this.Controls.Add(this.unPlayedOnlyCheckBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentNameLabel);
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
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.CheckBox unPlayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchListBox;
        private System.Windows.Forms.Label teamOneNameLabel;
        private System.Windows.Forms.Label teamTwoNameLabel;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreTextBox;
        private System.Windows.Forms.TextBox teamTwoScoreTextBox;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

