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
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TNameTextBox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.EntryFeeTextBox = new System.Windows.Forms.TextBox();
            this.RoundComboBox = new System.Windows.Forms.ComboBox();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.CreateTeamlinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TeamsPlayersDeleteButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TeamsLabel = new System.Windows.Forms.Label();
            this.PrizesDeleteButton = new System.Windows.Forms.Button();
            this.PrizeslistBox = new System.Windows.Forms.ListBox();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.CreateTournamentLabel.Location = new System.Drawing.Point(14, 9);
            this.CreateTournamentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(177, 25);
            this.CreateTournamentLabel.TabIndex = 1;
            this.CreateTournamentLabel.Text = "Create Tournament:";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(14, 53);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(142, 21);
            this.TournamentNameLabel.TabIndex = 2;
            this.TournamentNameLabel.Text = "Tournament Name:";
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNameTextBox.Location = new System.Drawing.Point(14, 77);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.Size = new System.Drawing.Size(246, 33);
            this.TNameTextBox.TabIndex = 9;
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(14, 130);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(77, 21);
            this.EntryFeeLabel.TabIndex = 10;
            this.EntryFeeLabel.Text = "Entry Fee:";
            // 
            // EntryFeeTextBox
            // 
            this.EntryFeeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntryFeeTextBox.Location = new System.Drawing.Point(14, 154);
            this.EntryFeeTextBox.Name = "EntryFeeTextBox";
            this.EntryFeeTextBox.Size = new System.Drawing.Size(161, 33);
            this.EntryFeeTextBox.TabIndex = 11;
            // 
            // RoundComboBox
            // 
            this.RoundComboBox.FormattingEnabled = true;
            this.RoundComboBox.Location = new System.Drawing.Point(14, 251);
            this.RoundComboBox.Name = "RoundComboBox";
            this.RoundComboBox.Size = new System.Drawing.Size(246, 33);
            this.RoundComboBox.TabIndex = 13;
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.RoundLabel.Location = new System.Drawing.Point(13, 213);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(111, 25);
            this.RoundLabel.TabIndex = 12;
            this.RoundLabel.Text = "Select Team";
            // 
            // CreateTeamlinkLabel1
            // 
            this.CreateTeamlinkLabel1.AutoSize = true;
            this.CreateTeamlinkLabel1.Location = new System.Drawing.Point(144, 213);
            this.CreateTeamlinkLabel1.Name = "CreateTeamlinkLabel1";
            this.CreateTeamlinkLabel1.Size = new System.Drawing.Size(116, 25);
            this.CreateTeamlinkLabel1.TabIndex = 14;
            this.CreateTeamlinkLabel1.TabStop = true;
            this.CreateTeamlinkLabel1.Text = "Create Team";
            this.CreateTeamlinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateTeamlinkLabel1_LinkClicked);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.AddTeamButton.Location = new System.Drawing.Point(49, 315);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(142, 38);
            this.AddTeamButton.TabIndex = 15;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.CreatePrizeButton.Location = new System.Drawing.Point(49, 375);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(142, 33);
            this.CreatePrizeButton.TabIndex = 16;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TeamsPlayersDeleteButton
            // 
            this.TeamsPlayersDeleteButton.BackColor = System.Drawing.Color.Silver;
            this.TeamsPlayersDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.TeamsPlayersDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TeamsPlayersDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TeamsPlayersDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamsPlayersDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.TeamsPlayersDeleteButton.Location = new System.Drawing.Point(678, 105);
            this.TeamsPlayersDeleteButton.Name = "TeamsPlayersDeleteButton";
            this.TeamsPlayersDeleteButton.Size = new System.Drawing.Size(111, 68);
            this.TeamsPlayersDeleteButton.TabIndex = 19;
            this.TeamsPlayersDeleteButton.Text = "Delete Selected";
            this.TeamsPlayersDeleteButton.UseVisualStyleBackColor = false;
            this.TeamsPlayersDeleteButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 25;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(316, 77);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(343, 129);
            this.TournamentPlayersListBox.TabIndex = 18;
            // 
            // TeamsLabel
            // 
            this.TeamsLabel.AutoSize = true;
            this.TeamsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.TeamsLabel.Location = new System.Drawing.Point(316, 49);
            this.TeamsLabel.Name = "TeamsLabel";
            this.TeamsLabel.Size = new System.Drawing.Size(136, 25);
            this.TeamsLabel.TabIndex = 17;
            this.TeamsLabel.Text = "Teams/ Players";
            this.TeamsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrizesDeleteButton
            // 
            this.PrizesDeleteButton.BackColor = System.Drawing.Color.Silver;
            this.PrizesDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PrizesDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PrizesDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PrizesDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrizesDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.PrizesDeleteButton.Location = new System.Drawing.Point(678, 279);
            this.PrizesDeleteButton.Name = "PrizesDeleteButton";
            this.PrizesDeleteButton.Size = new System.Drawing.Size(111, 68);
            this.PrizesDeleteButton.TabIndex = 22;
            this.PrizesDeleteButton.Text = "Delete Selected";
            this.PrizesDeleteButton.UseVisualStyleBackColor = false;
            // 
            // PrizeslistBox
            // 
            this.PrizeslistBox.FormattingEnabled = true;
            this.PrizeslistBox.ItemHeight = 25;
            this.PrizeslistBox.Location = new System.Drawing.Point(316, 251);
            this.PrizeslistBox.Name = "PrizeslistBox";
            this.PrizeslistBox.Size = new System.Drawing.Size(343, 129);
            this.PrizeslistBox.TabIndex = 21;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(189)))), ((int)(((byte)(101)))));
            this.PrizesLabel.Location = new System.Drawing.Point(316, 223);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(136, 25);
            this.PrizesLabel.TabIndex = 20;
            this.PrizesLabel.Text = "Teams/ Players";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 432);
            this.Controls.Add(this.PrizesDeleteButton);
            this.Controls.Add(this.PrizeslistBox);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.TeamsPlayersDeleteButton);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.TeamsLabel);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateTeamlinkLabel1);
            this.Controls.Add(this.RoundComboBox);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.EntryFeeTextBox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TNameTextBox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreateTournamentLabel;
        private Label TournamentNameLabel;
        private TextBox TNameTextBox;
        private Label EntryFeeLabel;
        private TextBox EntryFeeTextBox;
        private ComboBox RoundComboBox;
        private Label RoundLabel;
        private LinkLabel CreateTeamlinkLabel1;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private Button TeamsPlayersDeleteButton;
        private ListBox TournamentPlayersListBox;
        private Label TeamsLabel;
        private Button PrizesDeleteButton;
        private ListBox PrizeslistBox;
        private Label PrizesLabel;
    }
}