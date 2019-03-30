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
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(268, 32);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 74);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(258, 32);
            this.tournamentNameLabel.TabIndex = 2;
            this.tournamentNameLabel.Text = "Tournament Name:";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameTextBox.Location = new System.Drawing.Point(19, 121);
            this.tournamentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(160, 34);
            this.tournamentNameTextBox.TabIndex = 3;
            // 
            // EntryFeeTextBox
            // 
            this.EntryFeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeTextBox.Location = new System.Drawing.Point(163, 165);
            this.EntryFeeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EntryFeeTextBox.Name = "EntryFeeTextBox";
            this.EntryFeeTextBox.Size = new System.Drawing.Size(117, 34);
            this.EntryFeeTextBox.TabIndex = 5;
            this.EntryFeeTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 171);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(145, 32);
            this.entryFeeLabel.TabIndex = 4;
            this.entryFeeLabel.Text = "Entry Fee:";
            // 
            // addTeamLabel
            // 
            this.addTeamLabel.AutoSize = true;
            this.addTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addTeamLabel.Location = new System.Drawing.Point(12, 231);
            this.addTeamLabel.Name = "addTeamLabel";
            this.addTeamLabel.Size = new System.Drawing.Size(136, 32);
            this.addTeamLabel.TabIndex = 6;
            this.addTeamLabel.Text = "Add team";
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Location = new System.Drawing.Point(19, 267);
            this.selectTeamComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(301, 37);
            this.selectTeamComboBox.TabIndex = 7;
            this.selectTeamComboBox.Text = "Select a team";
            // 
            // creatNewTeamlinkLabel
            // 
            this.creatNewTeamlinkLabel.AutoSize = true;
            this.creatNewTeamlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatNewTeamlinkLabel.Location = new System.Drawing.Point(155, 238);
            this.creatNewTeamlinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creatNewTeamlinkLabel.Name = "creatNewTeamlinkLabel";
            this.creatNewTeamlinkLabel.Size = new System.Drawing.Size(165, 25);
            this.creatNewTeamlinkLabel.TabIndex = 8;
            this.creatNewTeamlinkLabel.TabStop = true;
            this.creatNewTeamlinkLabel.Text = "Creat a new team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.Location = new System.Drawing.Point(61, 322);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(209, 32);
            this.addTeamButton.TabIndex = 9;
            this.addTeamButton.Text = "Add team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.Location = new System.Drawing.Point(61, 377);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(209, 32);
            this.createPrizeButton.TabIndex = 10;
            this.createPrizeButton.Text = "Create prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 29;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(369, 110);
            this.tournamentTeamsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(235, 118);
            this.tournamentTeamsListBox.TabIndex = 11;
            // 
            // tournamentTeamsLabel
            // 
            this.tournamentTeamsLabel.AutoSize = true;
            this.tournamentTeamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentTeamsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentTeamsLabel.Location = new System.Drawing.Point(367, 74);
            this.tournamentTeamsLabel.Name = "tournamentTeamsLabel";
            this.tournamentTeamsLabel.Size = new System.Drawing.Size(212, 32);
            this.tournamentTeamsLabel.TabIndex = 12;
            this.tournamentTeamsLabel.Text = "Teams/Players:";
            // 
            // deleteSelectedTeamsButton
            // 
            this.deleteSelectedTeamsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.deleteSelectedTeamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteSelectedTeamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedTeamsButton.Location = new System.Drawing.Point(624, 162);
            this.deleteSelectedTeamsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteSelectedTeamsButton.Name = "deleteSelectedTeamsButton";
            this.deleteSelectedTeamsButton.Size = new System.Drawing.Size(144, 55);
            this.deleteSelectedTeamsButton.TabIndex = 14;
            this.deleteSelectedTeamsButton.Text = "Delete selected teams/players";
            this.deleteSelectedTeamsButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizesButton
            // 
            this.deleteSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.deleteSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizesButton.Location = new System.Drawing.Point(624, 354);
            this.deleteSelectedPrizesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            this.deleteSelectedPrizesButton.Size = new System.Drawing.Size(144, 55);
            this.deleteSelectedPrizesButton.TabIndex = 17;
            this.deleteSelectedPrizesButton.Text = "Delete selected prizes";
            this.deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPrizesLabel
            // 
            this.tournamentPrizesLabel.AutoSize = true;
            this.tournamentPrizesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPrizesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentPrizesLabel.Location = new System.Drawing.Point(367, 266);
            this.tournamentPrizesLabel.Name = "tournamentPrizesLabel";
            this.tournamentPrizesLabel.Size = new System.Drawing.Size(102, 32);
            this.tournamentPrizesLabel.TabIndex = 16;
            this.tournamentPrizesLabel.Text = "Prizes:";
            // 
            // tournamentPrizesListBox
            // 
            this.tournamentPrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPrizesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPrizesListBox.FormattingEnabled = true;
            this.tournamentPrizesListBox.ItemHeight = 29;
            this.tournamentPrizesListBox.Location = new System.Drawing.Point(369, 302);
            this.tournamentPrizesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tournamentPrizesListBox.Name = "tournamentPrizesListBox";
            this.tournamentPrizesListBox.Size = new System.Drawing.Size(235, 118);
            this.tournamentPrizesListBox.TabIndex = 15;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.Location = new System.Drawing.Point(235, 468);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(332, 55);
            this.createTournamentButton.TabIndex = 18;
            this.createTournamentButton.Text = "Create tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreatTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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