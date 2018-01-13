using PicturesVideoPlayer.Settings.SettingTypes;
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
                UpdateUIByMode(_setting.Mode);
            }
        }

        private void UpdateUIByMode(Modes mode)
        {
            if (mode == Settings.SettingTypes.Modes.Replace)
            {
                this.labelFilter.Visible = false;
                this.textBoxSourceFileSystemWatcherFilter.Visible = false;
                this.tbFPS.Enabled = true;

                this.textBoxSourceFramePath.Text = _setting.SourceFramePath;
            }
            else if (mode == Settings.SettingTypes.Modes.HTTPGet)
            {
                this.labelFilter.Visible = false;
                this.textBoxSourceFileSystemWatcherFilter.Visible = false;
                this.tbFPS.Enabled = true;

                this.textBoxSourceFramePath.Text = _setting.SourceFrameURI;
            }
            else if (mode == Settings.SettingTypes.Modes.AddNew)
            {
                this.tbFPS.Enabled = true;
                this.textBoxSourceFramePath.Text = _setting.SourceFileSystemWatcherPath;

                this.labelFilter.Visible = true;
                this.textBoxSourceFileSystemWatcherFilter.Visible = true;
                this.textBoxSourceFileSystemWatcherFilter.Text = _setting.SourceFileSystemWatcherFilter;
            }

            this.tbFPS.Text = _setting.FPS.ToString();
            this.comboBoxSizeMode.SelectedIndex = (int)_setting.SizeMode;
        }
        
        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.SettingTypes.Modes mode = (Settings.SettingTypes.Modes)this.comboBoxMode.SelectedIndex;
            UpdateUIByMode(mode);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.SettingTypes.Modes mode = (Settings.SettingTypes.Modes)this.comboBoxMode.SelectedIndex;
            _setting.Mode = mode;

            if (mode == Settings.SettingTypes.Modes.Replace)
            {
                _setting.SourceFramePath = this.textBoxSourceFramePath.Text;
            }
            else if (mode == Settings.SettingTypes.Modes.HTTPGet)
            {
                _setting.SourceFrameURI = this.textBoxSourceFramePath.Text;
            }
            else if (mode == Settings.SettingTypes.Modes.AddNew)
            {
                _setting.SourceFileSystemWatcherPath = this.textBoxSourceFramePath.Text;
                _setting.SourceFileSystemWatcherFilter = this.textBoxSourceFileSystemWatcherFilter.Text;
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
            MainForm mainFrom = this.Owner as MainForm;
            if (mainFrom != null)
            {
                mainFrom.ReLoadConnector();
            }
            this.Close();
        }
    }
}