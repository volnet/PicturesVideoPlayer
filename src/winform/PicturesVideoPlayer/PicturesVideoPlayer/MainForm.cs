using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesVideoPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitUI();
            this.timer1.Interval = 1000 / Configs.FPS;
            framePath = GetFramePath();
        }

        private void InitUI()
        { 
            // PlayOrPause button
            this.btnPlayOrPause.Parent = this.pictureBoxFrameView;
            this.btnPlayOrPause.Image = global::PicturesVideoPlayer.Properties.Resources.play;
            this.btnPlayOrPause.Text = string.Empty;

            this.pictureBoxFrameView.MouseHover += PictureBox1_MouseHover;
            this.pictureBoxFrameView.MouseLeave += PictureBox1_MouseLeave;
            this.btnPlayOrPause.MouseHover += BtnPlayOrPause_MouseHover;
            this.btnPlayOrPause.MouseLeave += BtnPlayOrPause_MouseLeave;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnPlayOrPauseNeedBeHide = true;
            HideBtnPauseLater();
        }

        private void BtnPlayOrPause_MouseLeave(object sender, EventArgs e)
        {
            btnPlayOrPauseNeedBeHide = true;
            HideBtnPauseLater();
        }

        private void BtnPlayOrPause_MouseHover(object sender, EventArgs e)
        {
            btnPlayOrPauseNeedBeHide = false;
            ShowBtnPause();
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            btnPlayOrPauseNeedBeHide = false;
            ShowBtnPause();
        }

        private string framePath = string.Empty;

        private string GetFramePath()
        {
            return Configs.FrameFullPath;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image img = null;
            Stream ms = GetFrameStream();
            img = Image.FromStream(ms);
            UpdateFrame(img);
        }

        private Stream GetFrameStream()
        {
            try
            {
                string path = framePath;
                byte[] buffer = System.IO.File.ReadAllBytes(path);
                if (buffer != null)
                {
                    MemoryStream ms = new MemoryStream(buffer);
                    return ms;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        private void UpdateFrame(Image frame)
        {
            this.SuspendLayout();
            pictureBoxFrameView.Image = frame;
            pictureBoxFrameView.Refresh();
            this.ResumeLayout(true);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11 || e.KeyCode == Keys.Escape)
            {
                Helpers.UIHelper.SwitchFullScreen(this);
            }
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Helpers.UIHelper.SwitchFullScreen(this);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Helpers.UIHelper.SwitchFullScreen(this);
        }



        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            SwitchPlayOrPause();
        }

        private bool isPlaying = false;
        private void SwitchPlayOrPause()
        {
            if (isPlaying)
            {
                this.btnPlayOrPause.Image = global::PicturesVideoPlayer.Properties.Resources.play;
                isPlaying = false;
                timer1.Stop();
            }
            else
            {
                this.btnPlayOrPause.Image = global::PicturesVideoPlayer.Properties.Resources.pause;
                isPlaying = true;
                btnPlayOrPauseNeedBeHide = true;
                timer1.Start();

                HideBtnPauseLater();
            }
        }

        private void ShowBtnPause()
        {
            this.btnPlayOrPause.Visible = true;
        }

        private void HideBtnPauseLater()
        {
            InitTimerForShowingBtnPause();
            timerForShowingBtnPause.Start();
        }

        private void InitTimerForShowingBtnPause()
        {
            timerForShowingBtnPause.Interval = 2000;
            timerForShowingBtnPause.Tick += TimerForShowingBtnPause_Tick;
        }

        private bool btnPlayOrPauseNeedBeHide = false;

        private void TimerForShowingBtnPause_Tick(object sender, EventArgs e)
        {
            if (isPlaying && btnPlayOrPauseNeedBeHide)
            {
                this.btnPlayOrPause.Visible = false;
                timerForShowingBtnPause.Stop();
            }
        }
        
        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.pictureBoxFrameView.Size = this.ClientSize;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }
    }
}
