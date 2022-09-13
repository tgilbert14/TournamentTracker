namespace TrackerUI
{
    partial class TournamnetDashboardForm
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
            this.loadExisitingTournamnetDropdown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamnetLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(237, 52);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(416, 51);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Tournament Dashboard";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // loadExisitingTournamnetDropdown
            // 
            this.loadExisitingTournamnetDropdown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loadExisitingTournamnetDropdown.FormattingEnabled = true;
            this.loadExisitingTournamnetDropdown.Location = new System.Drawing.Point(230, 175);
            this.loadExisitingTournamnetDropdown.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.loadExisitingTournamnetDropdown.Name = "loadExisitingTournamnetDropdown";
            this.loadExisitingTournamnetDropdown.Size = new System.Drawing.Size(430, 38);
            this.loadExisitingTournamnetDropdown.TabIndex = 20;
            // 
            // loadExistingTournamnetLabel
            // 
            this.loadExistingTournamnetLabel.AutoSize = true;
            this.loadExistingTournamnetLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamnetLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loadExistingTournamnetLabel.Location = new System.Drawing.Point(301, 131);
            this.loadExistingTournamnetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loadExistingTournamnetLabel.Name = "loadExistingTournamnetLabel";
            this.loadExistingTournamnetLabel.Size = new System.Drawing.Size(322, 37);
            this.loadExistingTournamnetLabel.TabIndex = 19;
            this.loadExistingTournamnetLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.loadTournamentButton.FlatAppearance.BorderSize = 2;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentButton.ForeColor = System.Drawing.Color.Transparent;
            this.loadTournamentButton.Location = new System.Drawing.Point(322, 234);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(264, 50);
            this.loadTournamentButton.TabIndex = 21;
            this.loadTournamentButton.Text = "Load Tournamnet";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.createTournamentButton.FlatAppearance.BorderSize = 2;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.Color.Transparent;
            this.createTournamentButton.Location = new System.Drawing.Point(340, 312);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(235, 95);
            this.createTournamentButton.TabIndex = 27;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamnetDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(890, 490);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExisitingTournamnetDropdown);
            this.Controls.Add(this.loadExistingTournamnetLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "TournamnetDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExisitingTournamnetDropdown;
        private Label loadExistingTournamnetLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}