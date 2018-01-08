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
            this.btnPlayOrPause.Parent = this.pictureBox1;
            this.btnPlayOrPause.Image = global::PicturesVideoPlayer.Properties.Resources.play;
            this.btnPlayOrPause.Text = "";

            this.pictureBox1.MouseHover += PictureBox1_MouseHover;
            this.pictureBox1.MouseLeave += PictureBox1_MouseLeave;
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
            try
            {
                this.SuspendLayout();
                string path = framePath;
                byte[] buffer = System.IO.File.ReadAllBytes(path);
                if (buffer != null)
                {
                    MemoryStream ms = new MemoryStream(buffer);
                    Image img = Image.FromStream(ms);
                    pictureBox1.Image = img;
                    pictureBox1.Refresh();
                }
                this.ResumeLayout(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11 || e.KeyCode == Keys.Escape)
            {
                SwitchFullScreen();
            }
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SwitchFullScreen();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            SwitchFullScreen();
        }

        #region FullScreen

        private void SwitchFullScreen()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ShowWindow(FindWindow("Shell_TrayWnd", null), SW_RESTORE);
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                ShowWindow(FindWindow("Shell_TrayWnd", null), SW_HIDE);
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        [DllImport("user32.dll")]
        public static extern int ShowWindow(int hwnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        private const int SW_HIDE = 0;  //隐藏任务栏
        private const int SW_RESTORE = 9;//显示任务栏

        #endregion

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


        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        public extern static void ShowCursor(int status);

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.pictureBox1.Size = this.ClientSize;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }
    }
}
