namespace RIVXIA_Simple_Scoreboard_REDUX
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
            // read out the list of games
            // read out the list of flags
            // read out the list of logos

            // put add those items to their respective combo boxes

            // read the character files in each one
        }

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
    }
}