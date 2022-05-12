namespace RIVXIA_Simple_Scoreboard_REDUX
{
    public partial class Scoreboard : Form
    {
        // METHODS ////////////////////////////////////////////////////////////////////////////////
        public void ReadBaseFolders()
        {
            // read out the list of games and put it into the game selector
            String[] directories;
            String gamesFolder = "Games";
            directories = Directory.GetDirectories(gamesFolder);
            foreach (String directory in directories)
            {
                String gameString = directory;
                gameString = gameString.Remove(0, gamesFolder.Length + 1);
                gameSelector.Items.Add(gameString);
            }

            // read out the list of flags and put it into the flag selector
            String flagsFolder = "Flags";
            directories = Directory.GetFiles(flagsFolder);
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
            foreach (String extraLogos in directories)
            {
                String extraLogosString = extraLogos;
                extraLogosString = extraLogosString.Remove(0, extraLogosFolder.Length + 1);
                extraLogoSelector.Items.Add(extraLogosString);
            }
        }

        // INITIALIZATION /////////////////////////////////////////////////////////////////////////
        public Scoreboard()
        {
            InitializeComponent();
            ReadBaseFolders();
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
            String gamesDirectory = "Games/";
            gamesDirectory += gameSelector.SelectedItem.ToString();
            String[] charactersList = Directory.GetFiles(gamesDirectory);
            foreach (String character in charactersList)
            {
                String characterString = character;
                characterString = characterString.Remove(0, gamesDirectory.Length + 1);
                characterString = characterString.Remove(characterString.LastIndexOf('.')) ;
                player1CharacterSelect.Items.Add(characterString);
                player2CharacterSelect.Items.Add(characterString);    
            }
        }

        private void extraLogoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            String extraLogoDirectory = "Extra Logos/";
            extraLogoDirectory += extraLogoSelector.SelectedItem.ToString();
            String[] logosList = Directory.GetFiles(extraLogoDirectory);
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
}