﻿namespace PlannerUI
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
            this.creatNewTeamlinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.tournamentTeamsLabel = new System.Windows.Forms.Label();
            this.removeSelectedTeamsButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizesButton = new System.Windows.Forms.Button();
            this.tournamentPrizesLabel = new System.Windows.Forms.Label();
            this.tournamentPrizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.selectTeamListBox = new System.Windows.Forms.ListBox();
            this.prizesGroupBox = new System.Windows.Forms.GroupBox();
            this.selectTeamsGroupBox = new System.Windows.Forms.GroupBox();
            this.prizesGroupBox.SuspendLayout();
            this.selectTeamsGroupBox.SuspendLayout();
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
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 52);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(258, 32);
            this.tournamentNameLabel.TabIndex = 2;
            this.tournamentNameLabel.Text = "Tournament Name:";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameTextBox.Location = new System.Drawing.Point(267, 52);
            this.tournamentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(160, 34);
            this.tournamentNameTextBox.TabIndex = 3;
            // 
            // EntryFeeTextBox
            // 
            this.EntryFeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeTextBox.Location = new System.Drawing.Point(628, 50);
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
            this.entryFeeLabel.Location = new System.Drawing.Point(477, 52);
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
            this.addTeamLabel.Location = new System.Drawing.Point(4, 14);
            this.addTeamLabel.Name = "addTeamLabel";
            this.addTeamLabel.Size = new System.Drawing.Size(217, 32);
            this.addTeamLabel.TabIndex = 6;
            this.addTeamLabel.Text = "Available teams";
            // 
            // creatNewTeamlinkLabel
            // 
            this.creatNewTeamlinkLabel.AutoSize = true;
            this.creatNewTeamlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatNewTeamlinkLabel.Location = new System.Drawing.Point(216, 20);
            this.creatNewTeamlinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creatNewTeamlinkLabel.Name = "creatNewTeamlinkLabel";
            this.creatNewTeamlinkLabel.Size = new System.Drawing.Size(165, 25);
            this.creatNewTeamlinkLabel.TabIndex = 8;
            this.creatNewTeamlinkLabel.TabStop = true;
            this.creatNewTeamlinkLabel.Text = "Creat a new team";
            this.creatNewTeamlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creatNewTeamlinkLabel_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addTeamButton.Location = new System.Drawing.Point(321, 94);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(144, 55);
            this.addTeamButton.TabIndex = 9;
            this.addTeamButton.Text = "Add team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createPrizeButton.Location = new System.Drawing.Point(18, 41);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(105, 55);
            this.createPrizeButton.TabIndex = 10;
            this.createPrizeButton.Text = "Create new prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 29;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(483, 50);
            this.tournamentTeamsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(292, 205);
            this.tournamentTeamsListBox.TabIndex = 11;
            // 
            // tournamentTeamsLabel
            // 
            this.tournamentTeamsLabel.AutoSize = true;
            this.tournamentTeamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentTeamsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentTeamsLabel.Location = new System.Drawing.Point(477, 14);
            this.tournamentTeamsLabel.Name = "tournamentTeamsLabel";
            this.tournamentTeamsLabel.Size = new System.Drawing.Size(212, 32);
            this.tournamentTeamsLabel.TabIndex = 12;
            this.tournamentTeamsLabel.Text = "Teams/Players:";
            // 
            // removeSelectedTeamsButton
            // 
            this.removeSelectedTeamsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.removeSelectedTeamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.removeSelectedTeamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeamsButton.Location = new System.Drawing.Point(321, 169);
            this.removeSelectedTeamsButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeSelectedTeamsButton.Name = "removeSelectedTeamsButton";
            this.removeSelectedTeamsButton.Size = new System.Drawing.Size(144, 55);
            this.removeSelectedTeamsButton.TabIndex = 14;
            this.removeSelectedTeamsButton.Text = "Remove selected teams/players";
            this.removeSelectedTeamsButton.UseVisualStyleBackColor = true;
            this.removeSelectedTeamsButton.Click += new System.EventHandler(this.removeSelectedTeamsButton_Click);
            // 
            // removeSelectedPrizesButton
            // 
            this.removeSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.removeSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.removeSelectedPrizesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPrizesButton.Location = new System.Drawing.Point(18, 104);
            this.removeSelectedPrizesButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeSelectedPrizesButton.Name = "removeSelectedPrizesButton";
            this.removeSelectedPrizesButton.Size = new System.Drawing.Size(105, 55);
            this.removeSelectedPrizesButton.TabIndex = 17;
            this.removeSelectedPrizesButton.Text = "Remove selected prizes";
            this.removeSelectedPrizesButton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizesButton.Click += new System.EventHandler(this.removeSelectedPrizesButton_Click);
            // 
            // tournamentPrizesLabel
            // 
            this.tournamentPrizesLabel.AutoSize = true;
            this.tournamentPrizesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPrizesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentPrizesLabel.Location = new System.Drawing.Point(6, 0);
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
            this.tournamentPrizesListBox.Location = new System.Drawing.Point(154, 19);
            this.tournamentPrizesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.tournamentPrizesListBox.Name = "tournamentPrizesListBox";
            this.tournamentPrizesListBox.Size = new System.Drawing.Size(303, 147);
            this.tournamentPrizesListBox.TabIndex = 15;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.Location = new System.Drawing.Point(559, 407);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(4);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(175, 100);
            this.createTournamentButton.TabIndex = 18;
            this.createTournamentButton.Text = "Create tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // selectTeamListBox
            // 
            this.selectTeamListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectTeamListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamListBox.FormattingEnabled = true;
            this.selectTeamListBox.ItemHeight = 29;
            this.selectTeamListBox.Location = new System.Drawing.Point(9, 50);
            this.selectTeamListBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectTeamListBox.Name = "selectTeamListBox";
            this.selectTeamListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectTeamListBox.Size = new System.Drawing.Size(293, 205);
            this.selectTeamListBox.TabIndex = 19;
            // 
            // prizesGroupBox
            // 
            this.prizesGroupBox.Controls.Add(this.removeSelectedPrizesButton);
            this.prizesGroupBox.Controls.Add(this.tournamentPrizesLabel);
            this.prizesGroupBox.Controls.Add(this.tournamentPrizesListBox);
            this.prizesGroupBox.Controls.Add(this.createPrizeButton);
            this.prizesGroupBox.Location = new System.Drawing.Point(12, 361);
            this.prizesGroupBox.Name = "prizesGroupBox";
            this.prizesGroupBox.Size = new System.Drawing.Size(483, 169);
            this.prizesGroupBox.TabIndex = 20;
            this.prizesGroupBox.TabStop = false;
            // 
            // selectTeamsGroupBox
            // 
            this.selectTeamsGroupBox.Controls.Add(this.selectTeamListBox);
            this.selectTeamsGroupBox.Controls.Add(this.removeSelectedTeamsButton);
            this.selectTeamsGroupBox.Controls.Add(this.tournamentTeamsLabel);
            this.selectTeamsGroupBox.Controls.Add(this.tournamentTeamsListBox);
            this.selectTeamsGroupBox.Controls.Add(this.addTeamButton);
            this.selectTeamsGroupBox.Controls.Add(this.creatNewTeamlinkLabel);
            this.selectTeamsGroupBox.Controls.Add(this.addTeamLabel);
            this.selectTeamsGroupBox.Location = new System.Drawing.Point(11, 92);
            this.selectTeamsGroupBox.Name = "selectTeamsGroupBox";
            this.selectTeamsGroupBox.Size = new System.Drawing.Size(783, 267);
            this.selectTeamsGroupBox.TabIndex = 21;
            this.selectTeamsGroupBox.TabStop = false;
            // 
            // CreatTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.selectTeamsGroupBox);
            this.Controls.Add(this.prizesGroupBox);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.EntryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreatTournamentForm";
            this.Text = "CreatTournament";
            this.prizesGroupBox.ResumeLayout(false);
            this.prizesGroupBox.PerformLayout();
            this.selectTeamsGroupBox.ResumeLayout(false);
            this.selectTeamsGroupBox.PerformLayout();
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
        private System.Windows.Forms.LinkLabel creatNewTeamlinkLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label tournamentTeamsLabel;
        private System.Windows.Forms.Button removeSelectedTeamsButton;
        private System.Windows.Forms.Button removeSelectedPrizesButton;
        private System.Windows.Forms.Label tournamentPrizesLabel;
        private System.Windows.Forms.ListBox tournamentPrizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.ListBox selectTeamListBox;
        private System.Windows.Forms.GroupBox prizesGroupBox;
        private System.Windows.Forms.GroupBox selectTeamsGroupBox;
    }
}