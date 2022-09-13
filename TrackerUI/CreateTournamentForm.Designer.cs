namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamnetNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton1 = new System.Windows.Forms.Button();
            this.tournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.TeamPlayerLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox1 = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(56, 27);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(343, 51);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameValue.Location = new System.Drawing.Point(65, 143);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(355, 39);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // TournamnetNameLabel
            // 
            this.TournamnetNameLabel.AutoSize = true;
            this.TournamnetNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamnetNameLabel.Location = new System.Drawing.Point(124, 100);
            this.TournamnetNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TournamnetNameLabel.Name = "TournamnetNameLabel";
            this.TournamnetNameLabel.Size = new System.Drawing.Size(236, 37);
            this.TournamnetNameLabel.TabIndex = 9;
            this.TournamnetNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeValue.Location = new System.Drawing.Point(247, 202);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(114, 39);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.Location = new System.Drawing.Point(113, 204);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(65, 304);
            this.selectTeamDropdown.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(355, 38);
            this.selectTeamDropdown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.selectTeamLabel.Location = new System.Drawing.Point(65, 261);
            this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(306, 267);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(114, 30);
            this.createNewTeamLinkLabel.TabIndex = 15;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "create new";
            this.createNewTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLinkLabel_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.addTeamButton.FlatAppearance.BorderSize = 2;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.Color.Transparent;
            this.addTeamButton.Location = new System.Drawing.Point(152, 384);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(180, 50);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreatePrizeButton1
            // 
            this.CreatePrizeButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreatePrizeButton1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.CreatePrizeButton1.FlatAppearance.BorderSize = 2;
            this.CreatePrizeButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.CreatePrizeButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.CreatePrizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButton1.ForeColor = System.Drawing.Color.Transparent;
            this.CreatePrizeButton1.Location = new System.Drawing.Point(152, 458);
            this.CreatePrizeButton1.Name = "CreatePrizeButton1";
            this.CreatePrizeButton1.Size = new System.Drawing.Size(180, 50);
            this.CreatePrizeButton1.TabIndex = 17;
            this.CreatePrizeButton1.Text = "Create Prize";
            this.CreatePrizeButton1.UseVisualStyleBackColor = false;
            // 
            // tournamentPlayerListBox
            // 
            this.tournamentPlayerListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tournamentPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayerListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tournamentPlayerListBox.FormattingEnabled = true;
            this.tournamentPlayerListBox.ItemHeight = 37;
            this.tournamentPlayerListBox.Location = new System.Drawing.Point(491, 147);
            this.tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            this.tournamentPlayerListBox.Size = new System.Drawing.Size(345, 187);
            this.tournamentPlayerListBox.TabIndex = 18;
            // 
            // TeamPlayerLabel
            // 
            this.TeamPlayerLabel.AutoSize = true;
            this.TeamPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamPlayerLabel.Location = new System.Drawing.Point(491, 100);
            this.TeamPlayerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TeamPlayerLabel.Name = "TeamPlayerLabel";
            this.TeamPlayerLabel.Size = new System.Drawing.Size(187, 37);
            this.TeamPlayerLabel.TabIndex = 19;
            this.TeamPlayerLabel.Text = "Team / Players";
            this.TeamPlayerLabel.Click += new System.EventHandler(this.TeamPlayerLabel_Click);
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.deleteSelectedPlayerButton.FlatAppearance.BorderSize = 2;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPlayerButton.ForeColor = System.Drawing.Color.Transparent;
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(842, 466);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(136, 75);
            this.deleteSelectedPlayerButton.TabIndex = 20;
            this.deleteSelectedPlayerButton.Text = "Delete Selected";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = false;
            this.deleteSelectedPlayerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.deleteSelectedPrizeButton.FlatAppearance.BorderSize = 2;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(842, 204);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(136, 75);
            this.deleteSelectedPrizeButton.TabIndex = 23;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            this.deleteSelectedPrizeButton.Click += new System.EventHandler(this.deleteSelectedPrizeButton_Click);
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.Location = new System.Drawing.Point(491, 361);
            this.prizesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(187, 37);
            this.prizesLabel.TabIndex = 22;
            this.prizesLabel.Text = "Team / Players";
            // 
            // prizesListBox1
            // 
            this.prizesListBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.prizesListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.prizesListBox1.FormattingEnabled = true;
            this.prizesListBox1.ItemHeight = 37;
            this.prizesListBox1.Location = new System.Drawing.Point(491, 408);
            this.prizesListBox1.Name = "prizesListBox1";
            this.prizesListBox1.Size = new System.Drawing.Size(345, 187);
            this.prizesListBox1.TabIndex = 21;
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
            this.createTournamentButton.Location = new System.Drawing.Point(56, 550);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(373, 61);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 691);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox1);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.TeamPlayerLabel);
            this.Controls.Add(this.tournamentPlayerListBox);
            this.Controls.Add(this.CreatePrizeButton1);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.TournamnetNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label TournamnetNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropdown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLinkLabel;
        private Button addTeamButton;
        private Button CreatePrizeButton1;
        private ListBox tournamentPlayerListBox;
        private Label TeamPlayerLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox1;
        private Button createTournamentButton;
    }
}