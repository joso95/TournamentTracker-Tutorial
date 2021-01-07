namespace CreateTournamentForm
{
    partial class CreateTournament
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
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.TextBox();
            this.CreateTournamentName = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFee = new System.Windows.Forms.Label();
            this.SelectTeam = new System.Windows.Forms.Label();
            this.teamDropDown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.createPriceButton = new System.Windows.Forms.Button();
            this.tournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.teamAndPlayersBox = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizeBoxLabel = new System.Windows.Forms.Label();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.Location = new System.Drawing.Point(12, 9);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(317, 50);
            this.tournamentLabel.TabIndex = 1;
            this.tournamentLabel.Text = "Create Tournament";
            // 
            // tournamentName
            // 
            this.tournamentName.Location = new System.Drawing.Point(38, 99);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(229, 20);
            this.tournamentName.TabIndex = 10;
            // 
            // CreateTournamentName
            // 
            this.CreateTournamentName.AutoSize = true;
            this.CreateTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentName.Location = new System.Drawing.Point(31, 59);
            this.CreateTournamentName.Name = "CreateTournamentName";
            this.CreateTournamentName.Size = new System.Drawing.Size(236, 37);
            this.CreateTournamentName.TabIndex = 9;
            this.CreateTournamentName.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(167, 157);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 20);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            this.entryFeeValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // EntryFee
            // 
            this.EntryFee.AutoSize = true;
            this.EntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFee.Location = new System.Drawing.Point(38, 141);
            this.EntryFee.Name = "EntryFee";
            this.EntryFee.Size = new System.Drawing.Size(125, 37);
            this.EntryFee.TabIndex = 11;
            this.EntryFee.Text = "Entry Fee";
            this.EntryFee.Click += new System.EventHandler(this.TeamOneScoreLabel_Click);
            // 
            // SelectTeam
            // 
            this.SelectTeam.AutoSize = true;
            this.SelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeam.Location = new System.Drawing.Point(38, 207);
            this.SelectTeam.Name = "SelectTeam";
            this.SelectTeam.Size = new System.Drawing.Size(156, 37);
            this.SelectTeam.TabIndex = 13;
            this.SelectTeam.Text = "Select Team";
            // 
            // teamDropDown
            // 
            this.teamDropDown.FormattingEnabled = true;
            this.teamDropDown.Location = new System.Drawing.Point(45, 247);
            this.teamDropDown.Name = "teamDropDown";
            this.teamDropDown.Size = new System.Drawing.Size(254, 21);
            this.teamDropDown.TabIndex = 14;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(212, 226);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(87, 13);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create new team";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Location = new System.Drawing.Point(122, 274);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(95, 51);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPriceButton
            // 
            this.createPriceButton.Location = new System.Drawing.Point(122, 348);
            this.createPriceButton.Name = "createPriceButton";
            this.createPriceButton.Size = new System.Drawing.Size(95, 51);
            this.createPriceButton.TabIndex = 17;
            this.createPriceButton.Text = "Create Price";
            this.createPriceButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayerListBox
            // 
            this.tournamentPlayerListBox.FormattingEnabled = true;
            this.tournamentPlayerListBox.Location = new System.Drawing.Point(446, 99);
            this.tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            this.tournamentPlayerListBox.Size = new System.Drawing.Size(208, 173);
            this.tournamentPlayerListBox.TabIndex = 18;
            // 
            // teamAndPlayersBox
            // 
            this.teamAndPlayersBox.AutoSize = true;
            this.teamAndPlayersBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAndPlayersBox.Location = new System.Drawing.Point(458, 59);
            this.teamAndPlayersBox.Name = "teamAndPlayersBox";
            this.teamAndPlayersBox.Size = new System.Drawing.Size(187, 37);
            this.teamAndPlayersBox.TabIndex = 19;
            this.teamAndPlayersBox.Text = "Team / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(679, 99);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(95, 51);
            this.deleteSelectedPlayerButton.TabIndex = 20;
            this.deleteSelectedPlayerButton.Text = "Delete Selected";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(679, 348);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(95, 51);
            this.deleteSelectedPrizeButton.TabIndex = 23;
            this.deleteSelectedPrizeButton.Text = "Delete selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizeBoxLabel
            // 
            this.prizeBoxLabel.AutoSize = true;
            this.prizeBoxLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeBoxLabel.Location = new System.Drawing.Point(519, 308);
            this.prizeBoxLabel.Name = "prizeBoxLabel";
            this.prizeBoxLabel.Size = new System.Drawing.Size(74, 37);
            this.prizeBoxLabel.TabIndex = 22;
            this.prizeBoxLabel.Text = "Prize";
            // 
            // prizeListBox
            // 
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.Location = new System.Drawing.Point(446, 348);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(208, 173);
            this.prizeListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(351, 527);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(95, 51);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 604);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizeBoxLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.teamAndPlayersBox);
            this.Controls.Add(this.tournamentPlayerListBox);
            this.Controls.Add(this.createPriceButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.teamDropDown);
            this.Controls.Add(this.SelectTeam);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.EntryFee);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.CreateTournamentName);
            this.Controls.Add(this.tournamentLabel);
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.TextBox tournamentName;
        private System.Windows.Forms.Label CreateTournamentName;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label EntryFee;
        private System.Windows.Forms.Label SelectTeam;
        private System.Windows.Forms.ComboBox teamDropDown;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button createPriceButton;
        private System.Windows.Forms.ListBox tournamentPlayerListBox;
        private System.Windows.Forms.Label teamAndPlayersBox;
        private System.Windows.Forms.Button deleteSelectedPlayerButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizeBoxLabel;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}

