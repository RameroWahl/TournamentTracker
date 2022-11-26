namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.VSlabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.Team1label = new System.Windows.Forms.Label();
            this.Team1Scorelabel = new System.Windows.Forms.Label();
            this.UnplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.RoundComboBox = new System.Windows.Forms.ComboBox();
            this.Team1TextBox = new System.Windows.Forms.TextBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.Team2TextBox = new System.Windows.Forms.TextBox();
            this.Team2ScoreLabel = new System.Windows.Forms.Label();
            this.Team2label = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.TournamentLabel.Location = new System.Drawing.Point(12, 9);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(117, 25);
            this.TournamentLabel.TabIndex = 0;
            this.TournamentLabel.Text = "Tournament:";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(178, 9);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(81, 25);
            this.TournamentNameLabel.TabIndex = 1;
            this.TournamentNameLabel.Text = "<none>";
            // 
            // VSlabel
            // 
            this.VSlabel.AutoSize = true;
            this.VSlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.VSlabel.Location = new System.Drawing.Point(577, 298);
            this.VSlabel.Name = "VSlabel";
            this.VSlabel.Size = new System.Drawing.Size(50, 25);
            this.VSlabel.TabIndex = 2;
            this.VSlabel.Text = "-VS-";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.RoundLabel.Location = new System.Drawing.Point(12, 58);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(70, 25);
            this.RoundLabel.TabIndex = 3;
            this.RoundLabel.Text = "Round:";
            // 
            // Team1label
            // 
            this.Team1label.AutoSize = true;
            this.Team1label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.Team1label.Location = new System.Drawing.Point(446, 168);
            this.Team1label.Name = "Team1label";
            this.Team1label.Size = new System.Drawing.Size(117, 25);
            this.Team1label.TabIndex = 4;
            this.Team1label.Text = "<team one>";
            // 
            // Team1Scorelabel
            // 
            this.Team1Scorelabel.AutoSize = true;
            this.Team1Scorelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.Team1Scorelabel.Location = new System.Drawing.Point(446, 241);
            this.Team1Scorelabel.Name = "Team1Scorelabel";
            this.Team1Scorelabel.Size = new System.Drawing.Size(63, 25);
            this.Team1Scorelabel.TabIndex = 5;
            this.Team1Scorelabel.Text = "Score:";
            // 
            // UnplayedCheckBox
            // 
            this.UnplayedCheckBox.AutoSize = true;
            this.UnplayedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.UnplayedCheckBox.Location = new System.Drawing.Point(104, 102);
            this.UnplayedCheckBox.Name = "UnplayedCheckBox";
            this.UnplayedCheckBox.Size = new System.Drawing.Size(155, 29);
            this.UnplayedCheckBox.TabIndex = 6;
            this.UnplayedCheckBox.Text = "Unplayed Only";
            this.UnplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // RoundComboBox
            // 
            this.RoundComboBox.FormattingEnabled = true;
            this.RoundComboBox.Location = new System.Drawing.Point(123, 58);
            this.RoundComboBox.Name = "RoundComboBox";
            this.RoundComboBox.Size = new System.Drawing.Size(136, 33);
            this.RoundComboBox.TabIndex = 7;
            // 
            // Team1TextBox
            // 
            this.Team1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Team1TextBox.Location = new System.Drawing.Point(532, 241);
            this.Team1TextBox.Name = "Team1TextBox";
            this.Team1TextBox.Size = new System.Drawing.Size(161, 33);
            this.Team1TextBox.TabIndex = 8;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 25;
            this.matchupListBox.Location = new System.Drawing.Point(12, 168);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(247, 329);
            this.matchupListBox.TabIndex = 9;
            // 
            // Team2TextBox
            // 
            this.Team2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Team2TextBox.Location = new System.Drawing.Point(532, 403);
            this.Team2TextBox.Name = "Team2TextBox";
            this.Team2TextBox.Size = new System.Drawing.Size(161, 33);
            this.Team2TextBox.TabIndex = 12;
            // 
            // Team2ScoreLabel
            // 
            this.Team2ScoreLabel.AutoSize = true;
            this.Team2ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.Team2ScoreLabel.Location = new System.Drawing.Point(446, 405);
            this.Team2ScoreLabel.Name = "Team2ScoreLabel";
            this.Team2ScoreLabel.Size = new System.Drawing.Size(63, 25);
            this.Team2ScoreLabel.TabIndex = 11;
            this.Team2ScoreLabel.Text = "Score:";
            // 
            // Team2label
            // 
            this.Team2label.AutoSize = true;
            this.Team2label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.Team2label.Location = new System.Drawing.Point(447, 341);
            this.Team2label.Name = "Team2label";
            this.Team2label.Size = new System.Drawing.Size(116, 25);
            this.Team2label.TabIndex = 10;
            this.Team2label.Text = "<team two>";
            // 
            // ScoreButton
            // 
            this.ScoreButton.BackColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.ScoreButton.Location = new System.Drawing.Point(681, 298);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(111, 40);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(836, 509);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.Team2TextBox);
            this.Controls.Add(this.Team2ScoreLabel);
            this.Controls.Add(this.Team2label);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.Team1TextBox);
            this.Controls.Add(this.RoundComboBox);
            this.Controls.Add(this.UnplayedCheckBox);
            this.Controls.Add(this.Team1Scorelabel);
            this.Controls.Add(this.Team1label);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.VSlabel);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.TournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TournamentViewerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TournamentLabel;
        private Label TournamentNameLabel;
        private Label VSlabel;
        private Label RoundLabel;
        private Label Team1label;
        private Label Team1Scorelabel;
        private CheckBox UnplayedCheckBox;
        private ComboBox RoundComboBox;
        private TextBox Team1TextBox;
        private ListBox matchupListBox;
        private TextBox Team2TextBox;
        private Label Team2ScoreLabel;
        private Label Team2label;
        private Button ScoreButton;
    }
}