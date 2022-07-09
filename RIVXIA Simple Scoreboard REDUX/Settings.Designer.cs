namespace RIVXIA_Simple_Scoreboard_REDUX
{
    partial class Settings
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
            this.darkModeCheckBox = new System.Windows.Forms.CheckBox();
            this.rememberFieldsCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // darkModeCheckBox
            // 
            this.darkModeCheckBox.AutoSize = true;
            this.darkModeCheckBox.Location = new System.Drawing.Point(12, 12);
            this.darkModeCheckBox.Name = "darkModeCheckBox";
            this.darkModeCheckBox.Size = new System.Drawing.Size(84, 19);
            this.darkModeCheckBox.TabIndex = 0;
            this.darkModeCheckBox.Text = "Dark Mode";
            this.darkModeCheckBox.UseVisualStyleBackColor = true;
            this.darkModeCheckBox.CheckedChanged += new System.EventHandler(this.darkModeCheckBox_CheckedChanged);
            // 
            // rememberFieldsCheckbox
            // 
            this.rememberFieldsCheckbox.AutoSize = true;
            this.rememberFieldsCheckbox.Location = new System.Drawing.Point(12, 37);
            this.rememberFieldsCheckbox.Name = "rememberFieldsCheckbox";
            this.rememberFieldsCheckbox.Size = new System.Drawing.Size(117, 19);
            this.rememberFieldsCheckbox.TabIndex = 1;
            this.rememberFieldsCheckbox.Text = "Remember Fields";
            this.rememberFieldsCheckbox.UseVisualStyleBackColor = true;
            this.rememberFieldsCheckbox.CheckedChanged += new System.EventHandler(this.rememberFieldsCheckbox_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 68);
            this.Controls.Add(this.rememberFieldsCheckbox);
            this.Controls.Add(this.darkModeCheckBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox darkModeCheckBox;
        private CheckBox rememberFieldsCheckbox;
    }
}