namespace PlannerUI
{
    partial class CreatTournamentForm
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
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.EntryFeeTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.addTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.creatNewTeamlinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.tournamentTeamsLabel = new System.Windows.Forms.Label();
            this.deleteSelectedTeamsButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizesButton = new System.Windows.Forms.Button();
            this.tournamentPrizesLabel = new System.Windows.Forms.Label();
            this.tournamentPrizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerLabel.Location = new System.Drawing.Point(9, 7);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(205, 26);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentNameLabel.Location = new System.Drawing.Point(9, 60);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(199, 26);
            this.tournamentNameLabel.TabIndex = 2;
            this.tournamentNameLabel.Text = "Tournament Name:";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Location = new System.Drawing.Point(14, 98);
            this.tournamentNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.tournamentNameTextBox.TabIndex = 3;
            // 
            // EntryFeeTextBox
            // 
            this.EntryFeeTextBox.Location = new System.Drawing.Point(125, 145);
            this.EntryFeeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EntryFeeTextBox.Name = "EntryFeeTextBox";
            this.EntryFeeTextBox.Size = new System.Drawing.Size(89, 20);
            this.EntryFeeTextBox.TabIndex = 5;
            this.EntryFeeTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.entryFeeLabel.Location = new System.Drawing.Point(9, 139);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(112, 26);
            this.entryFeeLabel.TabIndex = 4;
            this.entryFeeLabel.Text = "Entry Fee:";
            // 
            // addTeamLabel
            // 
            this.addTeamLabel.AutoSize = true;
            this.addTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addTeamLabel.Location = new System.Drawing.Point(9, 188);
            this.addTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addTeamLabel.Name = "addTeamLabel";
            this.addTeamLabel.Size = new System.Drawing.Size(106, 26);
            this.addTeamLabel.TabIndex = 6;
            this.addTeamLabel.Text = "Add team";
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Location = new System.Drawing.Point(14, 217);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(194, 21);
            this.selectTeamComboBox.TabIndex = 7;
            this.selectTeamComboBox.Text = "Select a team";
            // 
            // creatNewTeamlinkLabel
            // 
            this.creatNewTeamlinkLabel.AutoSize = true;
            this.creatNewTeamlinkLabel.Location = new System.Drawing.Point(118, 198);
            this.creatNewTeamlinkLabel.Name = "creatNewTeamlinkLabel";
            this.creatNewTeamlinkLabel.Size = new System.Drawing.Size(90, 13);
            this.creatNewTeamlinkLabel.TabIndex = 8;
            this.creatNewTeamlinkLabel.TabStop = true;
            this.creatNewTeamlinkLabel.Text = "Creat a new team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(50, 267);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(157, 26);
            this.addTeamButton.TabIndex = 9;
            this.addTeamButton.Text = "Add team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Location = new System.Drawing.Point(50, 318);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(157, 26);
            this.createPrizeButton.TabIndex = 10;
            this.createPrizeButton.Text = "Create prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(277, 89);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(177, 119);
            this.tournamentTeamsListBox.TabIndex = 11;
            // 
            // tournamentTeamsLabel
            // 
            this.tournamentTeamsLabel.AutoSize = true;
            this.tournamentTeamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentTeamsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentTeamsLabel.Location = new System.Drawing.Point(275, 60);
            this.tournamentTeamsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentTeamsLabel.Name = "tournamentTeamsLabel";
            this.tournamentTeamsLabel.Size = new System.Drawing.Size(163, 26);
            this.tournamentTeamsLabel.TabIndex = 12;
            this.tournamentTeamsLabel.Text = "Teams/Players:";
            // 
            // deleteSelectedTeamsButton
            // 
            this.deleteSelectedTeamsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.deleteSelectedTeamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteSelectedTeamsButton.Location = new System.Drawing.Point(480, 132);
            this.deleteSelectedTeamsButton.Name = "deleteSelectedTeamsButton";
            this.deleteSelectedTeamsButton.Size = new System.Drawing.Size(96, 45);
            this.deleteSelectedTeamsButton.TabIndex = 14;
            this.deleteSelectedTeamsButton.Text = "Delete selected teams/players";
            this.deleteSelectedTeamsButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizesButton
            // 
            this.deleteSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.deleteSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizesButton.Location = new System.Drawing.Point(480, 288);
            this.deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            this.deleteSelectedPrizesButton.Size = new System.Drawing.Size(96, 45);
            this.deleteSelectedPrizesButton.TabIndex = 17;
            this.deleteSelectedPrizesButton.Text = "Delete selected prizes";
            this.deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPrizesLabel
            // 
            this.tournamentPrizesLabel.AutoSize = true;
            this.tournamentPrizesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPrizesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentPrizesLabel.Location = new System.Drawing.Point(275, 216);
            this.tournamentPrizesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentPrizesLabel.Name = "tournamentPrizesLabel";
            this.tournamentPrizesLabel.Size = new System.Drawing.Size(79, 26);
            this.tournamentPrizesLabel.TabIndex = 16;
            this.tournamentPrizesLabel.Text = "Prizes:";
            // 
            // tournamentPrizesListBox
            // 
            this.tournamentPrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPrizesListBox.FormattingEnabled = true;
            this.tournamentPrizesListBox.Location = new System.Drawing.Point(277, 245);
            this.tournamentPrizesListBox.Name = "tournamentPrizesListBox";
            this.tournamentPrizesListBox.Size = new System.Drawing.Size(177, 119);
            this.tournamentPrizesListBox.TabIndex = 15;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createTournamentButton.Location = new System.Drawing.Point(176, 380);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(249, 45);
            this.createTournamentButton.TabIndex = 18;
            this.createTournamentButton.Text = "Create tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreatTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 437);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizesButton);
            this.Controls.Add(this.tournamentPrizesLabel);
            this.Controls.Add(this.tournamentPrizesListBox);
            this.Controls.Add(this.deleteSelectedTeamsButton);
            this.Controls.Add(this.tournamentTeamsLabel);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.creatNewTeamlinkLabel);
            this.Controls.Add(this.selectTeamComboBox);
            this.Controls.Add(this.addTeamLabel);
            this.Controls.Add(this.EntryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreatTournamentForm";
            this.Text = "CreatTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.TextBox EntryFeeTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label addTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamComboBox;
        private System.Windows.Forms.LinkLabel creatNewTeamlinkLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label tournamentTeamsLabel;
        private System.Windows.Forms.Button deleteSelectedTeamsButton;
        private System.Windows.Forms.Button deleteSelectedPrizesButton;
        private System.Windows.Forms.Label tournamentPrizesLabel;
        private System.Windows.Forms.ListBox tournamentPrizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}