namespace RIVXIA_Simple_Scoreboard_REDUX
{
    public partial class Scoreboard : Form
    {
        // METHODS ////////////////////////////////////////////////////////////////////////////////
        private void ReadBaseFolders()
        {
            // read out the list of games and put it into the game selector
            String[] directories;
            String gamesFolder = "Games";
            directories = Directory.GetDirectories(gamesFolder);
            System.IO.File.WriteAllLines("./Characters.txt", directories);
            foreach (String directory in directories)
            {
                String gameString = directory;
                gameString = gameString.Remove(0, gamesFolder.Length + 1);
                gameSelector.Items.Add(gameString);
            }

            // read out the list of flags and put it into the flag selector
            String flagsFolder = "Flags";
            directories = Directory.GetFiles(flagsFolder);
            System.IO.File.WriteAllLines("./Flags.txt", directories);
            foreach (String flag in directories)
            {
                String flagString = flag;
                flagString = flagString.Remove(0, flagsFolder.Length + 1);
                flagString = flagString.Remove(flagString.LastIndexOf('.'));
                player1Flag.Items.Add(flagString);
                player2Flag.Items.Add(flagString);
            }

            // read out the list of logos and put it into the logo selector
            String logosFolder = "Logos";
            directories = Directory.GetFiles(logosFolder);
            System.IO.File.WriteAllLines("./Logos.txt", directories);
            foreach (String logos in directories)
            {
                String logosString = logos;
                logosString = logosString.Remove(0, logosFolder.Length + 1);
                logosString = logosString.Remove(logosString.LastIndexOf('.'));
                player1Logo.Items.Add(logosString);
                player2Logo.Items.Add(logosString);
            }

            // read out the list of extra logos and put it into the logo selector
            String extraLogosFolder = "Extra Logos";
            directories = Directory.GetDirectories(extraLogosFolder);
            System.IO.File.WriteAllLines("./Extra Logos.txt", directories);
            foreach (String extraLogos in directories)
            {
                String extraLogosString = extraLogos;
                extraLogosString = extraLogosString.Remove(0, extraLogosFolder.Length + 1);
                extraLogoSelector.Items.Add(extraLogosString);
            }
        }
        private String GetCharacterPathFromIndex(int index)
        {
            String characterPath = System.IO.File.ReadLines("./Characters.txt").Skip(index).First();
            return characterPath;
        }
        private String GetFlagPathFromIndex(int index)
        {
            String flagPath = System.IO.File.ReadLines("./Flags.txt").Skip(index).First() ;
            return flagPath;
        }
        private String GetLogoPathFromIndex(int index)
        {
            String logoPath = System.IO.File.ReadLines("./Logos.txt").Skip(index).First();
            return logoPath;
        }
        private String GetExtraPathFromIndex(int index)
        {
            String extraPath = System.IO.File.ReadLines("./Extra Logos.txt").Skip(index).First();
            return extraPath;
        }
        public void EnableDarkMode()
        {
            BackColor = Color.FromArgb(255, 17, 17, 17);
            mainScoreboardTab.BackColor = Color.FromArgb(255, 27, 27, 27);
            scoreboardEssentials.ForeColor = Color.White;
            scoreboardEssentialsDivider.ForeColor = Color.White;
            scoreboardAdditions.ForeColor = Color.White;
            scoreboardAdditionsDivider.ForeColor = Color.White;
            player1Name.BackColor = Color.FromArgb(255, 58, 58, 58);
            player2Name.ForeColor = Color.White;
            player2Name.BackColor = Color.FromArgb(255, 58, 58, 58);
            player1Subtext.BackColor = Color.FromArgb(255, 58, 58, 58);
            player1Subtext.BackColor = Color.FromArgb(255, 58, 58, 58);
            player1Score.BackColor = Color.FromArgb(255, 58, 58, 58);
            player1Score.BackColor = Color.FromArgb(255, 58, 58, 58);
        }
        public void DisableDarkMode()
        {
            BackColor = Scoreboard.DefaultBackColor;
            mainScoreboardTab.BackColor = Color.Transparent;
        }
        private void ApplySettings()
        {
            String rememberFieldsString = System.IO.File.ReadAllText("./DO NOT TOUCH/Settings/Remember Fields.txt");
            bool rememberFieldsSetting = bool.Parse(rememberFieldsString);
            if (!rememberFieldsSetting)
            {
                System.IO.File.WriteAllText("./DO NOT TOUCH/Settings/Dark Mode.txt", "False");
                return;
            }

            // if the setting is turned on

            // enables dark mode
            String darkModeString = System.IO.File.ReadAllText("./DO NOT TOUCH/Settings/Dark Mode.txt");
            bool darkModeSetting = bool.Parse(darkModeString);
            if (darkModeSetting == true)
            {
                EnableDarkMode();
            }



        }

        // INITIALIZATION /////////////////////////////////////////////////////////////////////////
        public Scoreboard() 
        {
            InitializeComponent();
            ReadBaseFolders();
            ApplySettings();
        }

        // SWAP BUTTONS ///////////////////////////////////////////////////////////////////////////

        // SWAP BUTTON ON CLICK (ESSENTIAL)
        private void essentialSwapButton_Click(object sender, EventArgs e)
        { 
            String tempName = player1Name.Text;
            String tempSubtext = player1Subtext.Text;
            decimal tempScore = player1Score.Value;

            player1Name.Text = player2Name.Text;
            player1Subtext.Text = player2Subtext.Text;
            player1Score.Value = player2Score.Value;

            player2Name.Text = tempName;
            player2Subtext.Text = tempSubtext; 
            player2Score.Value = tempScore;
        }

        // SWAP BUTTON ON CLICK (ADDITION)
        private void additionsSwapButton_Click(object sender, EventArgs e)
        {
            object tempCharacter = player1CharacterSelect.SelectedItem;
            object tempFlag = player1Flag.SelectedItem;
            object tempLogo = player1Logo.SelectedItem;

            player1CharacterSelect.SelectedItem = player2CharacterSelect.SelectedItem;
            player1Flag.SelectedItem = player2Flag.SelectedItem;
            player1Logo.SelectedItem = player2Logo.SelectedItem;

            player2CharacterSelect.SelectedItem = tempCharacter;
            player2Flag.SelectedItem = tempFlag; 
            player2Logo.SelectedItem = tempLogo;
        }

        // SWAP BUTTON ON CLICK (COMMENTARY)
        private void commentatorSwapButton_Click(object sender, EventArgs e)
        {
            String tempName = commentator1Name.Text;
            String tempSubtext = commentator1Subtext.Text;

            commentator1Name.Text = commentator2Name.Text;
            commentator1Subtext.Text = commentator2Subtext.Text;

            commentator2Name.Text = tempName;
            commentator2Subtext.Text = tempSubtext;
        }

        // SWAP BUTTON ON CLICK (EXTRA LOGO)
        private void extraLogoSwap_Click(object sender, EventArgs e)
        {
            object tempLogo = player1ExtraLogo.SelectedItem;

            player1ExtraLogo.SelectedItem = player2ExtraLogo.SelectedItem;

            player2ExtraLogo.SelectedItem = tempLogo;
        }

        // READING SUBFOLDERS BASED ON GAMES / LOGOS //////////////////////////////////////////////

        private void gameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            player1CharacterSelect.Items.Clear();
            player2CharacterSelect.Items.Clear();
            if (gameSelector.SelectedIndex != -1)
            {
                String gamesDirectory = "Games/";
                gamesDirectory += gameSelector.SelectedItem.ToString();
                String[] charactersList = Directory.GetFiles(gamesDirectory);
                System.IO.File.WriteAllLines("./Characters.txt", charactersList);
                foreach (String character in charactersList)
                {
                    String characterString = character;
                    characterString = characterString.Remove(0, gamesDirectory.Length + 1);
                    characterString = characterString.Remove(characterString.LastIndexOf('.'));
                    player1CharacterSelect.Items.Add(characterString);
                    player2CharacterSelect.Items.Add(characterString);
                }
            }
        }

        private void extraLogoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            player1ExtraLogo.Items.Clear();
            player2ExtraLogo.Items.Clear();
            if (extraLogoSelector.SelectedIndex != -1)
            {
                String extraLogoDirectory = "Extra Logos/";
                extraLogoDirectory += extraLogoSelector.SelectedItem.ToString();
                String[] logosList = Directory.GetFiles(extraLogoDirectory);
                System.IO.File.WriteAllLines("./Extra Logos.txt", logosList);
                foreach (String logos in logosList)
                {
                    String logosString = logos;
                    logosString = logosString.Remove(0, extraLogoDirectory.Length + 1);
                    logosString = logosString.Remove(logosString.LastIndexOf('.'));
                    player1ExtraLogo.Items.Add(logosString);
                    player2ExtraLogo.Items.Add(logosString);
                }
            }
        }

        // BOTTOM BUTTONS (SETTINGS, ABOUT, RESET, UPDATE) ////////////////////////////////////////
        
        // SETTINGS
        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.ShowDialog();
        }

        // ABOUT
        private void aboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        // RESET
        private void resetButton_Click(object sender, EventArgs e)
        {
            // MAIN SCOREBOARD
            player1Name.Text = player1Name.Tag.ToString();
            player2Name.Text = player2Name.Tag.ToString();
            player1Score.Value = 0;
            player2Score.Value = 0;
            player1Subtext.Text = player1Subtext.Tag.ToString();
            player2Subtext.Text = player2Subtext.Tag.ToString();
            set.Text = set.Tag.ToString();


            gameSelector.SelectedIndex = -1;
            player1CharacterSelect.SelectedIndex = -1;
            player2CharacterSelect.SelectedIndex = -1;
            player1Flag.SelectedIndex = -1;
            player2Flag.SelectedIndex = -1;
            player1Logo.SelectedIndex = -1;
            player2Logo.SelectedIndex = -1;
            gameSelector.Text = gameSelector.Tag.ToString();
            player1CharacterSelect.Text = player1CharacterSelect.Tag.ToString();
            player2CharacterSelect.Text = player2CharacterSelect.Tag.ToString();
            player1Flag.Text = player1Flag.Tag.ToString();
            player2Flag.Text = player2Flag.Tag.ToString();
            player1Logo.Text = player1Logo.Tag.ToString();
            player2Logo.Text = player2Logo.Tag.ToString();

            //EXTRA SCOREBOARD
            commentator1Name.Text = commentator1Name.Tag.ToString();
            commentator2Name.Text = commentator2Name.Tag.ToString();
            commentator1Subtext.Text = commentator1Subtext.Tag.ToString();
            commentator2Subtext.Text = commentator2Subtext.Tag.ToString();

            extraLogoSelector.SelectedIndex = -1;
            player1ExtraLogo.SelectedIndex = -1;
            player2ExtraLogo.SelectedIndex = -1;
            extraLogoSelector.Text = extraLogoSelector.Tag.ToString();
            player1ExtraLogo.Text = player1ExtraLogo.Tag.ToString();
            player2ExtraLogo.Text = player2ExtraLogo.Tag.ToString();

            miscText1.Text = miscText1.Tag.ToString();
            miscText2.Text = miscText2.Tag.ToString();

            //TOP 8 BRACKET
            winnersSemis1.Text = winnersSemis1.Tag.ToString();
            winnersSemis2.Text = winnersSemis2.Tag.ToString();
            winnersSemis3.Text = winnersSemis3.Tag.ToString();
            winnersSemis4.Text = winnersSemis4.Tag.ToString();
            losersRO1.Text = losersRO1.Tag.ToString();
            losersRO2.Text = losersRO2.Tag.ToString();
            losersRO3.Text = losersRO3.Tag.ToString();
            losersRO4.Text = losersRO4.Tag.ToString();
            winnersFinals1.Text = "";
            winnersFinals2.Text = "";
            losersQuarters1.Text = "";
            losersQuarters2.Text = "";
            losersQuarters3.Text = "";
            losersQuarters4.Text = "";
            grandFinals1.Text = "";
            grandFinals2.Text = "";
            losersSemis1.Text = "";
            losersSemis2.Text = "";
            finalWinner.Text = "";
            losersFinals1.Text = "";
            losersFinals2.Text = "";
        }

        // UPDATE
        private void updateButton_Click(object sender, EventArgs e)
        {

            // MAIN SCOREBOARD
            System.IO.File.WriteAllText("Main Output/Player 1 Name.txt", player1Name.Text);
            System.IO.File.WriteAllText("Main Output/Player 2 Name.txt", player2Name.Text);
            System.IO.File.WriteAllText("Main Output/Player 1 Score.txt", player1Score.Value.ToString());
            System.IO.File.WriteAllText("Main Output/Player 2 Score.txt", player2Score.Value.ToString());
            System.IO.File.WriteAllText("Main Output/Player 1 Subtext.txt", player1Subtext.Text);
            System.IO.File.WriteAllText("Main Output/Player 2 Subtext.txt", player2Subtext.Text);
            System.IO.File.WriteAllText("Main Output/Set.txt", set.Text);

            System.IO.File.WriteAllText("Main Output/Game.txt", gameSelector.Text);
            if (player1CharacterSelect.SelectedIndex != -1 || player2CharacterSelect.SelectedIndex != -1)
            {
                System.IO.File.Copy(GetCharacterPathFromIndex(player1CharacterSelect.SelectedIndex), "Main Output/Player 1 Character.png", true);
                System.IO.File.Copy(GetCharacterPathFromIndex(player2CharacterSelect.SelectedIndex), "Main Output/Player 2 Character.png", true);
            }
            if (player1Flag.SelectedIndex != -1 || player2Flag.SelectedIndex != -1)
            {
                System.IO.File.Copy(GetFlagPathFromIndex(player1Flag.SelectedIndex), "Main Output/Player 1 Flag.png", true);
                System.IO.File.Copy(GetFlagPathFromIndex(player2Flag.SelectedIndex), "Main Output/Player 2 Flag.png", true);    
            }
            if (player1Logo.SelectedIndex != -1 || player2Logo.SelectedIndex != -1)
            {
                System.IO.File.Copy(GetLogoPathFromIndex(player1Logo.SelectedIndex), "Main Output/Player 1 Logo.png", true);
                System.IO.File.Copy(GetLogoPathFromIndex(player2Logo.SelectedIndex), "Main Output/Player 2 Logo.png", true);
            }

            // SCOREBOARD EXTRAS
            System.IO.File.WriteAllText("Extra Output/Commentator 1 Name.txt", commentator1Name.Text);
            System.IO.File.WriteAllText("Extra Output/Commentator 2 Name.txt", commentator2Name.Text);
            System.IO.File.WriteAllText("Extra Output/Commentator 1 Subtext.txt", commentator1Subtext.Text);
            System.IO.File.WriteAllText("Extra Output/Commentator 2 Subtext.txt", commentator2Subtext.Text);
            if (player1ExtraLogo.SelectedIndex != -1 || player2ExtraLogo.SelectedIndex != -1)
            {
                System.IO.File.Copy(GetExtraPathFromIndex(player1ExtraLogo.SelectedIndex), "Extra Output/Player 1 Extra Logo.png", true);
                System.IO.File.Copy(GetExtraPathFromIndex(player2ExtraLogo.SelectedIndex), "Extra Output/Player 2 Extra Logo.png", true);
            }
            System.IO.File.WriteAllText("Extra Output/Misc Text 1.txt", miscText1.Text);
            System.IO.File.WriteAllText("Extra Output/Misc Text 2.txt", miscText2.Text);

            // TOP 8 BRACKET
            System.IO.File.WriteAllText("Bracket Output/Winners Semis 1.txt", winnersSemis1.Text);
            System.IO.File.WriteAllText("Bracket Output/Winners Semis 2.txt", winnersSemis2.Text);
            System.IO.File.WriteAllText("Bracket Output/Winners Semis 3.txt", winnersSemis3.Text);
            System.IO.File.WriteAllText("Bracket Output/Winners Semis 4.txt", winnersSemis4.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Round One 1.txt", losersRO1.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Round One 2.txt", losersRO2.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Round One 3.txt", losersRO3.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Round One 4.txt", losersRO4.Text);
            System.IO.File.WriteAllText("Bracket Output/Winners Finals 1.txt", winnersFinals1.Text);
            System.IO.File.WriteAllText("Bracket Output/Winners Finals 2.txt", winnersFinals2.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Quarters 1.txt", losersQuarters1.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Quarters 2.txt", losersQuarters2.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Quarters 3.txt", losersQuarters3.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Quarters 4.txt", losersQuarters4.Text);
            System.IO.File.WriteAllText("Bracket Output/Grand Finals 1.txt", grandFinals1.Text);
            System.IO.File.WriteAllText("Bracket Output/Grand Finals 2.txt", grandFinals2.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Finals 1.txt", losersSemis1.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Finals 2.txt", losersSemis2.Text);
            System.IO.File.WriteAllText("Bracket Output/Tournament Winner.txt", finalWinner.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Finals 1.txt", losersFinals1.Text);
            System.IO.File.WriteAllText("Bracket Output/Losers Finals 2.txt", losersFinals2.Text);
        }

        // BRACKET BUTTONS ////////////////////////////////////////////////////////////////////////
        
        
        // COLUMN 1 
        private void winnersSemis1W_Click(object sender, EventArgs e)
        {
            winnersFinals1.Text = winnersSemis1.Text;
            losersQuarters3.Text = winnersSemis2.Text;
        }
        private void winnersSemis2W_Click(object sender, EventArgs e)
        {
            winnersFinals1.Text = winnersSemis2.Text;
            losersQuarters3.Text = winnersSemis1.Text;
        }
        private void winnersSemis3W_Click(object sender, EventArgs e)
        {
            winnersFinals2.Text = winnersSemis3.Text;
            losersQuarters1.Text = winnersSemis4.Text;
        }
        private void winnersSemis4W_Click(object sender, EventArgs e)
        {
            winnersFinals2.Text = winnersSemis4.Text;
            losersQuarters1.Text = winnersSemis3.Text;
        }
        private void losersRO1W_Click(object sender, EventArgs e)
        {
            losersQuarters2.Text = losersRO1.Text;
        }
        private void losersRO2W_Click(object sender, EventArgs e)
        {
            losersQuarters2.Text = losersRO2.Text;
        }
        private void losersRO3W_Click(object sender, EventArgs e)
        {
            losersQuarters4.Text = losersRO3.Text;
        }
        private void losersRO4W_Click(object sender, EventArgs e)
        {
            losersQuarters4.Text = losersRO4.Text;
        }


        // COLUMN 2
        private void winnersFinals1W_Click(object sender, EventArgs e)
        {
            grandFinals1.Text = winnersFinals1.Text;
            losersFinals1.Text = winnersFinals2.Text;
        }
        private void winnersFinals2W_Click(object sender, EventArgs e)
        {
            grandFinals1.Text = winnersFinals2.Text;
            losersFinals1.Text = winnersFinals1.Text;
        }
        private void losersQuarters1W_Click(object sender, EventArgs e)
        {
            losersSemis1.Text = losersQuarters1.Text;
        }
        private void losersQuarters2W_Click(object sender, EventArgs e)
        {
            losersSemis1.Text = losersQuarters2.Text;
        }
        private void losersQuarters3W_Click(object sender, EventArgs e)
        {
            losersSemis2.Text = losersQuarters3.Text;
        }
        private void losersQuarters4W_Click(object sender, EventArgs e)
        {
            losersSemis2.Text = losersQuarters4.Text;
        }


        //COLUMN 3
        private void grandFinals1W_Click(object sender, EventArgs e)
        {
            finalWinner.Text = grandFinals1.Text;
        }
        private void grandFinals2W_Click(object sender, EventArgs e)
        {
            finalWinner.Text = grandFinals2.Text;
        }
        private void losersSemis1W_Click(object sender, EventArgs e)
        {
            losersFinals2.Text = losersSemis1.Text;
        }
        private void losersSemis2W_Click(object sender, EventArgs e)
        {
            losersFinals2.Text = losersSemis2.Text;
        }


        // COLUMN 4
        private void losersFinals1W_Click(object sender, EventArgs e)
        {
            grandFinals2.Text = losersFinals1.Text;
        }
        private void losersFinals2W_Click(object sender, EventArgs e)
        {
            grandFinals2.Text = losersFinals2.Text;
        }
    }
}