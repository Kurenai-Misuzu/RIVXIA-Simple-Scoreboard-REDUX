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
            this.player2Logo = new System.Windows.Forms.ComboBox();
            this.player1Logo = new System.Windows.Forms.ComboBox();
            this.additionsSwapButton = new System.Windows.Forms.Button();
            this.player2Flag = new System.Windows.Forms.ComboBox();
            this.player1Flag = new System.Windows.Forms.ComboBox();
            this.player2CharacterSelect = new System.Windows.Forms.ComboBox();
            this.player1CharacterSelect = new System.Windows.Forms.ComboBox();
            this.gameSelector = new System.Windows.Forms.ComboBox();
            this.scoreboardAdditionsDivider = new System.Windows.Forms.Label();
            this.scorebordAdditions = new System.Windows.Forms.Label();
            this.scoreboardEssentialsDivider = new System.Windows.Forms.Label();
            this.scoreboardEssentials = new System.Windows.Forms.Label();
            this.player2Subtext = new System.Windows.Forms.TextBox();
            this.player1Subtext = new System.Windows.Forms.TextBox();
            this.essentialSwapButton = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.TextBox();
            this.player2Score = new System.Windows.Forms.NumericUpDown();
            this.player1Score = new System.Windows.Forms.NumericUpDown();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.scoreboardExtrasTab = new System.Windows.Forms.TabPage();
            this.top8BracketTab = new System.Windows.Forms.TabPage();
            this.scoreboardTabController.SuspendLayout();
            this.mainScoreboardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Score)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreboardTabController
            // 
            this.scoreboardTabController.Controls.Add(this.mainScoreboardTab);
            this.scoreboardTabController.Controls.Add(this.scoreboardExtrasTab);
            this.scoreboardTabController.Controls.Add(this.top8BracketTab);
            this.scoreboardTabController.Location = new System.Drawing.Point(12, 12);
            this.scoreboardTabController.Name = "scoreboardTabController";
            this.scoreboardTabController.SelectedIndex = 0;
            this.scoreboardTabController.Size = new System.Drawing.Size(528, 309);
            this.scoreboardTabController.TabIndex = 0;
            // 
            // mainScoreboardTab
            // 
            this.mainScoreboardTab.Controls.Add(this.player2Logo);
            this.mainScoreboardTab.Controls.Add(this.player1Logo);
            this.mainScoreboardTab.Controls.Add(this.additionsSwapButton);
            this.mainScoreboardTab.Controls.Add(this.player2Flag);
            this.mainScoreboardTab.Controls.Add(this.player1Flag);
            this.mainScoreboardTab.Controls.Add(this.player2CharacterSelect);
            this.mainScoreboardTab.Controls.Add(this.player1CharacterSelect);
            this.mainScoreboardTab.Controls.Add(this.gameSelector);
            this.mainScoreboardTab.Controls.Add(this.scoreboardAdditionsDivider);
            this.mainScoreboardTab.Controls.Add(this.scorebordAdditions);
            this.mainScoreboardTab.Controls.Add(this.scoreboardEssentialsDivider);
            this.mainScoreboardTab.Controls.Add(this.scoreboardEssentials);
            this.mainScoreboardTab.Controls.Add(this.player2Subtext);
            this.mainScoreboardTab.Controls.Add(this.player1Subtext);
            this.mainScoreboardTab.Controls.Add(this.essentialSwapButton);
            this.mainScoreboardTab.Controls.Add(this.set);
            this.mainScoreboardTab.Controls.Add(this.player2Score);
            this.mainScoreboardTab.Controls.Add(this.player1Score);
            this.mainScoreboardTab.Controls.Add(this.player2Name);
            this.mainScoreboardTab.Controls.Add(this.player1Name);
            this.mainScoreboardTab.Location = new System.Drawing.Point(4, 24);
            this.mainScoreboardTab.Name = "mainScoreboardTab";
            this.mainScoreboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainScoreboardTab.Size = new System.Drawing.Size(520, 281);
            this.mainScoreboardTab.TabIndex = 0;
            this.mainScoreboardTab.Text = "Main Scoreboard";
            this.mainScoreboardTab.UseVisualStyleBackColor = true;
            // 
            // player2Logo
            // 
            this.player2Logo.FormattingEnabled = true;
            this.player2Logo.Location = new System.Drawing.Point(309, 251);
            this.player2Logo.Name = "player2Logo";
            this.player2Logo.Size = new System.Drawing.Size(204, 23);
            this.player2Logo.TabIndex = 18;
            this.player2Logo.Text = "Player 2 Logo";
            // 
            // player1Logo
            // 
            this.player1Logo.FormattingEnabled = true;
            this.player1Logo.Location = new System.Drawing.Point(6, 251);
            this.player1Logo.Name = "player1Logo";
            this.player1Logo.Size = new System.Drawing.Size(204, 23);
            this.player1Logo.TabIndex = 17;
            this.player1Logo.Text = "Player 1 Logo";
            // 
            // additionsSwapButton
            // 
            this.additionsSwapButton.Location = new System.Drawing.Point(216, 206);
            this.additionsSwapButton.Name = "additionsSwapButton";
            this.additionsSwapButton.Size = new System.Drawing.Size(87, 52);
            this.additionsSwapButton.TabIndex = 19;
            this.additionsSwapButton.Text = "< SWAP >";
            this.additionsSwapButton.UseVisualStyleBackColor = true;
            // 
            // player2Flag
            // 
            this.player2Flag.FormattingEnabled = true;
            this.player2Flag.Location = new System.Drawing.Point(309, 222);
            this.player2Flag.Name = "player2Flag";
            this.player2Flag.Size = new System.Drawing.Size(204, 23);
            this.player2Flag.TabIndex = 16;
            this.player2Flag.Text = "Player 2 Country / State";
            // 
            // player1Flag
            // 
            this.player1Flag.FormattingEnabled = true;
            this.player1Flag.Location = new System.Drawing.Point(6, 222);
            this.player1Flag.Name = "player1Flag";
            this.player1Flag.Size = new System.Drawing.Size(204, 23);
            this.player1Flag.TabIndex = 15;
            this.player1Flag.Text = "Player 1 Country / State";
            // 
            // player2CharacterSelect
            // 
            this.player2CharacterSelect.FormattingEnabled = true;
            this.player2CharacterSelect.Location = new System.Drawing.Point(309, 193);
            this.player2CharacterSelect.Name = "player2CharacterSelect";
            this.player2CharacterSelect.Size = new System.Drawing.Size(204, 23);
            this.player2CharacterSelect.TabIndex = 14;
            this.player2CharacterSelect.Text = "Player 2 Character";
            // 
            // player1CharacterSelect
            // 
            this.player1CharacterSelect.FormattingEnabled = true;
            this.player1CharacterSelect.Location = new System.Drawing.Point(6, 193);
            this.player1CharacterSelect.Name = "player1CharacterSelect";
            this.player1CharacterSelect.Size = new System.Drawing.Size(204, 23);
            this.player1CharacterSelect.TabIndex = 13;
            this.player1CharacterSelect.Text = "Player 1 Character";
            // 
            // gameSelector
            // 
            this.gameSelector.FormattingEnabled = true;
            this.gameSelector.Location = new System.Drawing.Point(6, 164);
            this.gameSelector.Name = "gameSelector";
            this.gameSelector.Size = new System.Drawing.Size(507, 23);
            this.gameSelector.TabIndex = 12;
            this.gameSelector.Text = "Select Game Being Played";
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
            // essentialSwapButton
            // 
            this.essentialSwapButton.Location = new System.Drawing.Point(216, 36);
            this.essentialSwapButton.Name = "essentialSwapButton";
            this.essentialSwapButton.Size = new System.Drawing.Size(87, 52);
            this.essentialSwapButton.TabIndex = 7;
            this.essentialSwapButton.Text = " < SWAP >";
            this.essentialSwapButton.UseVisualStyleBackColor = true;
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
            // scoreboardExtrasTab
            // 
            this.scoreboardExtrasTab.Location = new System.Drawing.Point(4, 24);
            this.scoreboardExtrasTab.Name = "scoreboardExtrasTab";
            this.scoreboardExtrasTab.Padding = new System.Windows.Forms.Padding(3);
            this.scoreboardExtrasTab.Size = new System.Drawing.Size(520, 281);
            this.scoreboardExtrasTab.TabIndex = 1;
            this.scoreboardExtrasTab.Text = "Scoreboard Extras";
            this.scoreboardExtrasTab.UseVisualStyleBackColor = true;
            // 
            // top8BracketTab
            // 
            this.top8BracketTab.Location = new System.Drawing.Point(4, 24);
            this.top8BracketTab.Name = "top8BracketTab";
            this.top8BracketTab.Padding = new System.Windows.Forms.Padding(3);
            this.top8BracketTab.Size = new System.Drawing.Size(520, 281);
            this.top8BracketTab.TabIndex = 2;
            this.top8BracketTab.Text = "Top 8 Bracket";
            this.top8BracketTab.UseVisualStyleBackColor = true;
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
        private TabPage scoreboardExtrasTab;
        private TabPage top8BracketTab;

        private Label scoreboardEssentials;
        private Label scoreboardEssentialsDivider;

        private TextBox player1Name;
        private TextBox player2Name;
        private NumericUpDown player1Score;
        private NumericUpDown player2Score;
        private TextBox player1Subtext;
        private TextBox player2Subtext;
        private TextBox set;
        private Button essentialSwapButton;

        private Label scoreboardAdditionsDivider;
        private Label scorebordAdditions;

        private ComboBox gameSelector;
        private ComboBox player1CharacterSelect;
        private ComboBox player2CharacterSelect;
        private ComboBox player1Flag;
        private ComboBox player2Flag;
        private ComboBox player2Logo;
        private ComboBox player1Logo;
        private Button additionsSwapButton;
    }
}