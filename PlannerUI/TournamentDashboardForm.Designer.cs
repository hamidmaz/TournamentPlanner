namespace PlannerUI
{
    partial class TournamentDashboardForm
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
            this.selectTournamentComboBox = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createNewTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerLabel.Location = new System.Drawing.Point(26, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(314, 32);
            this.headerLabel.TabIndex = 21;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // selectTournamentComboBox
            // 
            this.selectTournamentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTournamentComboBox.FormattingEnabled = true;
            this.selectTournamentComboBox.Location = new System.Drawing.Point(33, 127);
            this.selectTournamentComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectTournamentComboBox.Name = "selectTournamentComboBox";
            this.selectTournamentComboBox.Size = new System.Drawing.Size(301, 37);
            this.selectTournamentComboBox.TabIndex = 23;
            this.selectTournamentComboBox.Text = "Select a tournament";
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(43, 91);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(281, 29);
            this.loadExistingTournamentLabel.TabIndex = 22;
            this.loadExistingTournamentLabel.Text = "Load existing tournament";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.Location = new System.Drawing.Point(79, 176);
            this.loadTournamentButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(209, 37);
            this.loadTournamentButton.TabIndex = 24;
            this.loadTournamentButton.Text = "Load tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createNewTournamentButton
            // 
            this.createNewTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createNewTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createNewTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTournamentButton.Location = new System.Drawing.Point(17, 260);
            this.createNewTournamentButton.Margin = new System.Windows.Forms.Padding(4);
            this.createNewTournamentButton.Name = "createNewTournamentButton";
            this.createNewTournamentButton.Size = new System.Drawing.Size(332, 55);
            this.createNewTournamentButton.TabIndex = 25;
            this.createNewTournamentButton.Text = "Create new tournament";
            this.createNewTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 350);
            this.Controls.Add(this.createNewTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.selectTournamentComboBox);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox selectTournamentComboBox;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createNewTournamentButton;
    }
}