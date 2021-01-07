namespace CreateTeamForm
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
            this.tournamentName = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.createTeam = new System.Windows.Forms.Label();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.teamDropDown = new System.Windows.Forms.ComboBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberBox = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tournamentName
            // 
            this.tournamentName.Location = new System.Drawing.Point(38, 99);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(254, 20);
            this.tournamentName.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.Location = new System.Drawing.Point(31, 59);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // createTeam
            // 
            this.createTeam.AutoSize = true;
            this.createTeam.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeam.Location = new System.Drawing.Point(12, 9);
            this.createTeam.Name = "createTeam";
            this.createTeam.Size = new System.Drawing.Size(213, 50);
            this.createTeam.TabIndex = 11;
            this.createTeam.Text = "Create Team";
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.Location = new System.Drawing.Point(31, 135);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.SelectTeamLabel.TabIndex = 14;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // teamDropDown
            // 
            this.teamDropDown.FormattingEnabled = true;
            this.teamDropDown.Location = new System.Drawing.Point(38, 175);
            this.teamDropDown.Name = "teamDropDown";
            this.teamDropDown.Size = new System.Drawing.Size(254, 21);
            this.teamDropDown.TabIndex = 15;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(106, 215);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(95, 51);
            this.addMemberButton.TabIndex = 21;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberBox
            // 
            this.addNewMemberBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberBox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberBox.Controls.Add(this.emailValue);
            this.addNewMemberBox.Controls.Add(this.emailLabel);
            this.addNewMemberBox.Controls.Add(this.lastNameValue);
            this.addNewMemberBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberBox.Controls.Add(this.firstNameValue);
            this.addNewMemberBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberBox.Location = new System.Drawing.Point(38, 281);
            this.addNewMemberBox.Name = "addNewMemberBox";
            this.addNewMemberBox.Size = new System.Drawing.Size(447, 256);
            this.addNewMemberBox.TabIndex = 22;
            this.addNewMemberBox.TabStop = false;
            this.addNewMemberBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(142, 33);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(100, 20);
            this.firstNameValue.TabIndex = 10;
            this.firstNameValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 17);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(142, 86);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(100, 20);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(7, 69);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(143, 141);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(100, 20);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(8, 124);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 37);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(143, 197);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(100, 20);
            this.cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneLabel.Location = new System.Drawing.Point(8, 180);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(138, 37);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.Location = new System.Drawing.Point(364, 381);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(95, 48);
            this.createMemberButton.TabIndex = 23;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.Location = new System.Drawing.Point(568, 59);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(240, 485);
            this.teamMembersListBox.TabIndex = 24;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(650, 550);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(95, 51);
            this.deleteSelectedMemberButton.TabIndex = 25;
            this.deleteSelectedMemberButton.Text = "Delete Selected Member";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.Location = new System.Drawing.Point(364, 543);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(95, 51);
            this.createTeamButton.TabIndex = 26;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 606);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.createMemberButton);
            this.Controls.Add(this.addNewMemberBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.teamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.createTeam);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addNewMemberBox.ResumeLayout(false);
            this.addNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tournamentName;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label createTeam;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.ComboBox teamDropDown;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberBox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}

