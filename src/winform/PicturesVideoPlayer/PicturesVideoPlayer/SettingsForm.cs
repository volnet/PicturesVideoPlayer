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

        private Settings.Setting _setting = null;
        private void OnInit()
        {
            _setting = Settings.Setting.Instance;
            if (_setting != null)
            {
                this.comboBoxMode.SelectedIndex = (int)_setting.Mode;

                if (_setting.Mode == Settings.SettingTypes.Modes.Replace)
                {
                    this.textBoxSourceFramePath.Text = _setting.SourceFramePath;
                }
                else if (_setting.Mode == Settings.SettingTypes.Modes.HTTPGet)
                {
                    this.textBoxSourceFramePath.Text = _setting.SourceFrameURI;
                }

                this.tbFPS.Text = _setting.FPS.ToString();
                this.comboBoxSizeMode.SelectedIndex = (int)_setting.SizeMode;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.SettingTypes.Modes mode = (Settings.SettingTypes.Modes)this.comboBoxMode.SelectedIndex;
            _setting.Mode = mode;

            if (mode == Settings.SettingTypes.Modes.AddNew)
            {
                _setting.SourceFramePath = this.textBoxSourceFramePath.Text;
            }
            else if (mode == Settings.SettingTypes.Modes.HTTPGet)
            {
                _setting.SourceFrameURI = this.textBoxSourceFramePath.Text;
            }

            int fps = 0;
            if (int.TryParse(this.tbFPS.Text, out fps))
            {
                _setting.FPS = fps;
            }
            _setting.SizeMode = (Settings.SettingTypes.SizeModes)this.comboBoxSizeMode.SelectedIndex;

            if (Settings.Setting.SaveToDisk(_setting))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.SettingTypes.Modes mode = (Settings.SettingTypes.Modes)this.comboBoxMode.SelectedIndex;
            if (mode == Settings.SettingTypes.Modes.Replace)
            {
                this.textBoxSourceFramePath.Text = _setting.SourceFramePath;
            }
            else if (mode == Settings.SettingTypes.Modes.HTTPGet)
            {
                this.textBoxSourceFramePath.Text = _setting.SourceFrameURI;
            }
        }
    }
}