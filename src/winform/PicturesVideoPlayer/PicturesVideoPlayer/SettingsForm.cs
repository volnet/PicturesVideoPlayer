using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesVideoPlayer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            OnInit();
        }

        private Settings.Setting setting = null;
        private void OnInit()
        {
            setting = Settings.Setting.Instance;
            if (setting != null)
            {
                this.comboBoxMode.SelectedIndex = (int)setting.Mode;

                this.textBoxSourceFolderPath.Text = setting.SourceFolderPath;
                this.textBoxFrameName.Text = setting.FrameName;

                this.tbFPS.Text = setting.FPS.ToString();
                this.comboBoxSizeMode.SelectedIndex = (int)setting.SizeMode;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setting.Mode = (Settings.SettingTypes.Modes)this.comboBoxMode.SelectedIndex;

            setting.SourceFolderPath = this.textBoxSourceFolderPath.Text;
            setting.FrameName = this.textBoxFrameName.Text;

            int fps = 0;
            if (int.TryParse(this.tbFPS.Text, out fps))
            {
                setting.FPS = fps;
            }
            setting.SizeMode = (Settings.SettingTypes.SizeModes)this.comboBoxSizeMode.SelectedIndex;

            if (Settings.Setting.SaveToDisk(setting))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
