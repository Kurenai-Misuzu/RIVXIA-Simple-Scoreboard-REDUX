using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIVXIA_Simple_Scoreboard_REDUX
{
    public partial class Settings : Form
    {
        // METHODS ////////////////////////////////////////////////////////////////////////////////
        private void ReadSettings()
        {
            if (!System.IO.File.Exists("./DO NOT TOUCH/Settings/Dark Mode.txt"))
            {
                System.IO.File.WriteAllText("./DO NOT TOUCH/Settings/Dark Mode.txt", "False");
            }
            if (!System.IO.File.Exists("./DO NOT TOUCH/Settings/Remember Fields.txt"))
            {
                System.IO.File.WriteAllText("./DO NOT TOUCH/Settings/Remember Fields.txt", "False");
            }

            String darkModeString = System.IO.File.ReadAllText("./DO NOT TOUCH/Settings/Dark Mode.txt");
            bool darkModeSetting = bool.Parse(darkModeString);
            if (darkModeSetting == true)
            {
                darkModeCheckBox.Checked = true;
            }

            String rememberFieldsString = System.IO.File.ReadAllText("./DO NOT TOUCH/Settings/Remember Fields.txt");
            bool rememberFieldsSetting = bool.Parse(rememberFieldsString);
            if (rememberFieldsSetting == true)
            {
                rememberFieldsCheckbox.Checked = true;
            }

        }

        private Scoreboard scoreboard_;
        public Settings(Scoreboard mainForm)
        {
            scoreboard_ = mainForm as Scoreboard;
            InitializeComponent();
            ReadSettings();
        }


        private void darkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (darkModeCheckBox.Checked)
            {
                scoreboard_.EnableDarkMode();
                System.IO.File.WriteAllText("./DO NOT TOUCH/Settings/Dark Mode.txt", "True");
            }
            if (!darkModeCheckBox.Checked)
            {
                scoreboard_.DisableDarkMode();
                System.IO.File.WriteAllText("./DO NOT TOUCH/Settings/Dark Mode.txt", "False");
            }
        }

        private void rememberFieldsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberFieldsCheckbox.Checked)
            {
                System.IO.File.WriteAllText("./DO NOT TOUCH/Settings/Remember Fields.txt", "True");
            }
            if (!rememberFieldsCheckbox.Checked)
            {
                System.IO.File.WriteAllText("./DO NOT TOUCH/Settings/Remember Fields.txt", "False");
            }
        }
    }
}
