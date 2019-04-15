namespace PlannerUI
{
    partial class CreateTeamForm
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
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.availablePlayersLabel = new System.Windows.Forms.Label();
            this.addNewPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.addNewplayerButton = new System.Windows.Forms.Button();
            this.mobileNrLabel = new System.Windows.Forms.Label();
            this.mobileNrTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedTeamMembersButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.selectPlayerListBox = new System.Windows.Forms.ListBox();
            this.selectedPlayersLabel = new System.Windows.Forms.Label();
            this.addNewPlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameTextBox.Location = new System.Drawing.Point(426, 41);
            this.teamNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(266, 34);
            this.teamNameTextBox.TabIndex = 6;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamNameLabel.Location = new System.Drawing.Point(243, 41);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(177, 32);
            this.teamNameLabel.TabIndex = 5;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerLabel.Location = new System.Drawing.Point(12, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(187, 32);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Create Team:";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addMemberButton.Location = new System.Drawing.Point(382, 198);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(163, 54);
            this.addMemberButton.TabIndex = 12;
            this.addMemberButton.Text = "Add selected player";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // availablePlayersLabel
            // 
            this.availablePlayersLabel.AutoSize = true;
            this.availablePlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePlayersLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.availablePlayersLabel.Location = new System.Drawing.Point(66, 105);
            this.availablePlayersLabel.Name = "availablePlayersLabel";
            this.availablePlayersLabel.Size = new System.Drawing.Size(235, 32);
            this.availablePlayersLabel.TabIndex = 10;
            this.availablePlayersLabel.Text = "Available Players";
            this.availablePlayersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addNewPlayerGroupBox
            // 
            this.addNewPlayerGroupBox.Controls.Add(this.addNewplayerButton);
            this.addNewPlayerGroupBox.Controls.Add(this.mobileNrLabel);
            this.addNewPlayerGroupBox.Controls.Add(this.mobileNrTextBox);
            this.addNewPlayerGroupBox.Controls.Add(this.emailLabel);
            this.addNewPlayerGroupBox.Controls.Add(this.emailTextBox);
            this.addNewPlayerGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewPlayerGroupBox.Controls.Add(this.lastNameTextBox);
            this.addNewPlayerGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewPlayerGroupBox.Controls.Add(this.firstNameTextBox);
            this.addNewPlayerGroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPlayerGroupBox.Location = new System.Drawing.Point(12, 411);
            this.addNewPlayerGroupBox.Name = "addNewPlayerGroupBox";
            this.addNewPlayerGroupBox.Size = new System.Drawing.Size(556, 201);
            this.addNewPlayerGroupBox.TabIndex = 13;
            this.addNewPlayerGroupBox.TabStop = false;
            this.addNewPlayerGroupBox.Text = "Add new player";
            // 
            // addNewplayerButton
            // 
            this.addNewplayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewplayerButton.Location = new System.Drawing.Point(176, 140);
            this.addNewplayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewplayerButton.Name = "addNewplayerButton";
            this.addNewplayerButton.Size = new System.Drawing.Size(209, 41);
            this.addNewplayerButton.TabIndex = 14;
            this.addNewplayerButton.Text = "Add new player";
            this.addNewplayerButton.UseVisualStyleBackColor = true;
            this.addNewplayerButton.Click += new System.EventHandler(this.addNewplayerButton_Click);
            // 
            // mobileNrLabel
            // 
            this.mobileNrLabel.AutoSize = true;
            this.mobileNrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNrLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mobileNrLabel.Location = new System.Drawing.Point(285, 98);
            this.mobileNrLabel.Name = "mobileNrLabel";
            this.mobileNrLabel.Size = new System.Drawing.Size(100, 25);
            this.mobileNrLabel.TabIndex = 17;
            this.mobileNrLabel.Text = "Mobile Nr.";
            // 
            // mobileNrTextBox
            // 
            this.mobileNrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNrTextBox.Location = new System.Drawing.Point(394, 93);
            this.mobileNrTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mobileNrTextBox.Name = "mobileNrTextBox";
            this.mobileNrTextBox.Size = new System.Drawing.Size(155, 30);
            this.mobileNrTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailLabel.Location = new System.Drawing.Point(285, 50);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 25);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(394, 47);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(155, 30);
            this.emailTextBox.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastNameLabel.Location = new System.Drawing.Point(11, 96);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(103, 25);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(117, 93);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(154, 30);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.firstNameLabel.Location = new System.Drawing.Point(11, 51);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(103, 25);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(116, 48);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(155, 30);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 29;
            this.teamMembersListBox.Location = new System.Drawing.Point(575, 141);
            this.teamMembersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.teamMembersListBox.Size = new System.Drawing.Size(310, 263);
            this.teamMembersListBox.TabIndex = 14;
            // 
            // removeSelectedTeamMembersButton
            // 
            this.removeSelectedTeamMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.removeSelectedTeamMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.removeSelectedTeamMembersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeamMembersButton.Location = new System.Drawing.Point(382, 282);
            this.removeSelectedTeamMembersButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeSelectedTeamMembersButton.Name = "removeSelectedTeamMembersButton";
            this.removeSelectedTeamMembersButton.Size = new System.Drawing.Size(163, 55);
            this.removeSelectedTeamMembersButton.TabIndex = 15;
            this.removeSelectedTeamMembersButton.Text = "Remove selected team members";
            this.removeSelectedTeamMembersButton.UseVisualStyleBackColor = true;
            this.removeSelectedTeamMembersButton.Click += new System.EventHandler(this.removeSelectedTeamMembersButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.Location = new System.Drawing.Point(646, 468);
            this.createTeamButton.Margin = new System.Windows.Forms.Padding(4);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(224, 101);
            this.createTeamButton.TabIndex = 19;
            this.createTeamButton.Text = "Create team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // selectPlayerListBox
            // 
            this.selectPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectPlayerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPlayerListBox.FormattingEnabled = true;
            this.selectPlayerListBox.ItemHeight = 29;
            this.selectPlayerListBox.Location = new System.Drawing.Point(28, 141);
            this.selectPlayerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectPlayerListBox.Name = "selectPlayerListBox";
            this.selectPlayerListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectPlayerListBox.Size = new System.Drawing.Size(310, 263);
            this.selectPlayerListBox.TabIndex = 20;
            // 
            // selectedPlayersLabel
            // 
            this.selectedPlayersLabel.AutoSize = true;
            this.selectedPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPlayersLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectedPlayersLabel.Location = new System.Drawing.Point(621, 105);
            this.selectedPlayersLabel.Name = "selectedPlayersLabel";
            this.selectedPlayersLabel.Size = new System.Drawing.Size(229, 32);
            this.selectedPlayersLabel.TabIndex = 21;
            this.selectedPlayersLabel.Text = "Selected Players";
            this.selectedPlayersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 620);
            this.Controls.Add(this.selectedPlayersLabel);
            this.Controls.Add(this.selectPlayerListBox);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedTeamMembersButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewPlayerGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.availablePlayersLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewPlayerGroupBox.ResumeLayout(false);
            this.addNewPlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Label availablePlayersLabel;
        private System.Windows.Forms.GroupBox addNewPlayerGroupBox;
        private System.Windows.Forms.Label mobileNrLabel;
        private System.Windows.Forms.TextBox mobileNrTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button addNewplayerButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button removeSelectedTeamMembersButton;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.ListBox selectPlayerListBox;
        private System.Windows.Forms.Label selectedPlayersLabel;
    }
}