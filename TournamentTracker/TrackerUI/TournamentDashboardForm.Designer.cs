namespace TrackerUI
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
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.tournamentValue = new System.Windows.Forms.TextBox();
            this.loadTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(313, 312);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(180, 87);
            this.createTournamentButton.TabIndex = 33;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Location = new System.Drawing.Point(343, 234);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(119, 51);
            this.loadTournamentButton.TabIndex = 32;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // tournamentValue
            // 
            this.tournamentValue.Location = new System.Drawing.Point(300, 208);
            this.tournamentValue.Name = "tournamentValue";
            this.tournamentValue.Size = new System.Drawing.Size(212, 20);
            this.tournamentValue.TabIndex = 31;
            // 
            // loadTournamentLabel
            // 
            this.loadTournamentLabel.AutoSize = true;
            this.loadTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentLabel.Location = new System.Drawing.Point(190, 130);
            this.loadTournamentLabel.Name = "loadTournamentLabel";
            this.loadTournamentLabel.Size = new System.Drawing.Size(420, 50);
            this.loadTournamentLabel.TabIndex = 30;
            this.loadTournamentLabel.Text = "Load Existing Tournament";
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(204, 52);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(385, 50);
            this.tournamentDashboardLabel.TabIndex = 29;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.tournamentValue);
            this.Controls.Add(this.loadTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Name = "TournamentDashboardForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.TextBox tournamentValue;
        private System.Windows.Forms.Label loadTournamentLabel;
        private System.Windows.Forms.Label tournamentDashboardLabel;
    }
}