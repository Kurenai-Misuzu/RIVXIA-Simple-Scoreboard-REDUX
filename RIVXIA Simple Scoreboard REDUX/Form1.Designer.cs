namespace RIVXIA_Simple_Scoreboard_REDUX
{
    partial class Scoreboard
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
            this.scoreboardTabController = new System.Windows.Forms.TabControl();
            this.mainScoreboardTab = new System.Windows.Forms.TabPage();
            this.scoreboardAdditionsDivider = new System.Windows.Forms.Label();
            this.scorebordAdditions = new System.Windows.Forms.Label();
            this.scoreboardEssentialsDivider = new System.Windows.Forms.Label();
            this.scoreboardEssentials = new System.Windows.Forms.Label();
            this.player2Subtext = new System.Windows.Forms.TextBox();
            this.player1Subtext = new System.Windows.Forms.TextBox();
            this.swapButton = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.TextBox();
            this.player2Score = new System.Windows.Forms.NumericUpDown();
            this.player1Score = new System.Windows.Forms.NumericUpDown();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.top8BracketTab = new System.Windows.Forms.TabPage();
            this.scoreboardExtrasTab = new System.Windows.Forms.TabPage();
            this.scoreboardTabController.SuspendLayout();
            this.mainScoreboardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Score)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreboardTabController
            // 
            this.scoreboardTabController.Controls.Add(this.mainScoreboardTab);
            this.scoreboardTabController.Controls.Add(this.top8BracketTab);
            this.scoreboardTabController.Controls.Add(this.scoreboardExtrasTab);
            this.scoreboardTabController.Location = new System.Drawing.Point(12, 12);
            this.scoreboardTabController.Name = "scoreboardTabController";
            this.scoreboardTabController.SelectedIndex = 0;
            this.scoreboardTabController.Size = new System.Drawing.Size(532, 313);
            this.scoreboardTabController.TabIndex = 0;
            // 
            // mainScoreboardTab
            // 
            this.mainScoreboardTab.Controls.Add(this.scoreboardAdditionsDivider);
            this.mainScoreboardTab.Controls.Add(this.scorebordAdditions);
            this.mainScoreboardTab.Controls.Add(this.scoreboardEssentialsDivider);
            this.mainScoreboardTab.Controls.Add(this.scoreboardEssentials);
            this.mainScoreboardTab.Controls.Add(this.player2Subtext);
            this.mainScoreboardTab.Controls.Add(this.player1Subtext);
            this.mainScoreboardTab.Controls.Add(this.swapButton);
            this.mainScoreboardTab.Controls.Add(this.set);
            this.mainScoreboardTab.Controls.Add(this.player2Score);
            this.mainScoreboardTab.Controls.Add(this.player1Score);
            this.mainScoreboardTab.Controls.Add(this.player2Name);
            this.mainScoreboardTab.Controls.Add(this.player1Name);
            this.mainScoreboardTab.Location = new System.Drawing.Point(4, 24);
            this.mainScoreboardTab.Name = "mainScoreboardTab";
            this.mainScoreboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainScoreboardTab.Size = new System.Drawing.Size(524, 285);
            this.mainScoreboardTab.TabIndex = 0;
            this.mainScoreboardTab.Text = "Main Scoreboard";
            this.mainScoreboardTab.UseVisualStyleBackColor = true;
            // 
            // scoreboardAdditionsDivider
            // 
            this.scoreboardAdditionsDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreboardAdditionsDivider.Location = new System.Drawing.Point(6, 145);
            this.scoreboardAdditionsDivider.Name = "scoreboardAdditionsDivider";
            this.scoreboardAdditionsDivider.Size = new System.Drawing.Size(507, 2);
            this.scoreboardAdditionsDivider.TabIndex = 11;
            // 
            // scorebordAdditions
            // 
            this.scorebordAdditions.AutoSize = true;
            this.scorebordAdditions.Location = new System.Drawing.Point(6, 130);
            this.scorebordAdditions.Name = "scorebordAdditions";
            this.scorebordAdditions.Size = new System.Drawing.Size(121, 15);
            this.scorebordAdditions.TabIndex = 10;
            this.scorebordAdditions.Text = "Scoreboard Additions";
            // 
            // scoreboardEssentialsDivider
            // 
            this.scoreboardEssentialsDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreboardEssentialsDivider.Location = new System.Drawing.Point(6, 21);
            this.scoreboardEssentialsDivider.Name = "scoreboardEssentialsDivider";
            this.scoreboardEssentialsDivider.Size = new System.Drawing.Size(507, 2);
            this.scoreboardEssentialsDivider.TabIndex = 9;
            // 
            // scoreboardEssentials
            // 
            this.scoreboardEssentials.AutoSize = true;
            this.scoreboardEssentials.Location = new System.Drawing.Point(6, 6);
            this.scoreboardEssentials.Name = "scoreboardEssentials";
            this.scoreboardEssentials.Size = new System.Drawing.Size(120, 15);
            this.scoreboardEssentials.TabIndex = 8;
            this.scoreboardEssentials.Text = "Scoreboard Essentials";
            // 
            // player2Subtext
            // 
            this.player2Subtext.Location = new System.Drawing.Point(355, 65);
            this.player2Subtext.Name = "player2Subtext";
            this.player2Subtext.Size = new System.Drawing.Size(158, 23);
            this.player2Subtext.TabIndex = 5;
            this.player2Subtext.Text = "Player 2 Subtext";
            // 
            // player1Subtext
            // 
            this.player1Subtext.Location = new System.Drawing.Point(6, 65);
            this.player1Subtext.Name = "player1Subtext";
            this.player1Subtext.Size = new System.Drawing.Size(158, 23);
            this.player1Subtext.TabIndex = 4;
            this.player1Subtext.Text = "Player 1 Subtext";
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(216, 36);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(87, 52);
            this.swapButton.TabIndex = 7;
            this.swapButton.Text = " < SWAP >";
            this.swapButton.UseVisualStyleBackColor = true;
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(6, 94);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(507, 23);
            this.set.TabIndex = 6;
            this.set.Text = "Set";
            // 
            // player2Score
            // 
            this.player2Score.Location = new System.Drawing.Point(309, 53);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(40, 23);
            this.player2Score.TabIndex = 3;
            // 
            // player1Score
            // 
            this.player1Score.Location = new System.Drawing.Point(170, 53);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(40, 23);
            this.player1Score.TabIndex = 2;
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(355, 36);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(158, 23);
            this.player2Name.TabIndex = 1;
            this.player2Name.Text = "Player 2 Name";
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(6, 36);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(158, 23);
            this.player1Name.TabIndex = 0;
            this.player1Name.Text = "Player 1 Name";
            // 
            // top8BracketTab
            // 
            this.top8BracketTab.Location = new System.Drawing.Point(4, 24);
            this.top8BracketTab.Name = "top8BracketTab";
            this.top8BracketTab.Padding = new System.Windows.Forms.Padding(3);
            this.top8BracketTab.Size = new System.Drawing.Size(524, 285);
            this.top8BracketTab.TabIndex = 1;
            this.top8BracketTab.Text = "Top 8 Bracket";
            this.top8BracketTab.UseVisualStyleBackColor = true;
            // 
            // scoreboardExtrasTab
            // 
            this.scoreboardExtrasTab.Location = new System.Drawing.Point(4, 24);
            this.scoreboardExtrasTab.Name = "scoreboardExtrasTab";
            this.scoreboardExtrasTab.Padding = new System.Windows.Forms.Padding(3);
            this.scoreboardExtrasTab.Size = new System.Drawing.Size(524, 285);
            this.scoreboardExtrasTab.TabIndex = 2;
            this.scoreboardExtrasTab.Text = "Scoreboard Extras";
            this.scoreboardExtrasTab.UseVisualStyleBackColor = true;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 361);
            this.Controls.Add(this.scoreboardTabController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Scoreboard";
            this.Text = "RIVXIA Simple Scoreboard REDUX";
            this.scoreboardTabController.ResumeLayout(false);
            this.mainScoreboardTab.ResumeLayout(false);
            this.mainScoreboardTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl scoreboardTabController;

        private TabPage mainScoreboardTab;
        private TabPage top8BracketTab;
        private TabPage scoreboardExtrasTab;

        private Label scoreboardEssentials;
        private Label scoreboardEssentialsDivider;

        private TextBox player1Name;
        private TextBox player2Name;
        private NumericUpDown player1Score;
        private NumericUpDown player2Score;
        private TextBox player1Subtext;
        private TextBox player2Subtext;
        private TextBox set;
        private Button swapButton;

        private Label scoreboardAdditionsDivider;
        private Label scorebordAdditions;
    }
}