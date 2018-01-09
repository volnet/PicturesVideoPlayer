﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesVideoPlayer.Connector
{
    class LocalDiskPollingConnector : IUIConnector
    {
        private Form _form = null;
        private PictureBox _pictureBox = null;
        private IContainer _components = null;

        public LocalDiskPollingConnector(Form form, PictureBox pictureBox, IContainer components)
        {
            if (form == null)
                throw new ArgumentNullException("from");
            if (pictureBox == null)
                throw new ArgumentNullException("pictureBox");
            if (components == null)
                throw new ArgumentNullException("components");
            _form = form;
            _pictureBox = pictureBox;
            _components = components;
            InitTimer();
        }

        public void RefreshStart()
        {
            this._timerForPolling.Start();
        }

        public void RefreshStop()
        {
            this._timerForPolling.Stop();
        }

        private System.Windows.Forms.Timer _timerForPolling;

        private void InitTimer()
        {
            this._timerForPolling = new System.Windows.Forms.Timer(_components);
            this._timerForPolling.Tick += new System.EventHandler(this.timerForPolling_Tick);
            this._timerForPolling.Interval = 1000 / Settings.Setting.Instance.FPS;
        }

        private void timerForPolling_Tick(object sender, EventArgs e)
        {
            try
            {
                Image image = GetImage();
                if (image != null)
                {
                    UpdateFrameToUI(image);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private Image GetImage()
        {
            Image img = null;
            Stream ms = GetFrameStream();
            if (ms != null)
            {
                img = Image.FromStream(ms);
            }
            return img;
        }

        private Stream GetFrameStream()
        {
            try
            {
                string path = Settings.Setting.Instance.FrameFullPath;
                if (!string.IsNullOrEmpty(path))
                {
                    byte[] buffer = System.IO.File.ReadAllBytes(path);
                    if (buffer != null)
                    {
                        MemoryStream ms = new MemoryStream(buffer);
                        return ms;
                    }
                }
                else
                {
                    Console.WriteLine("path IsNullOrEmpty");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        private void UpdateFrameToUI(Image frame)
        {
            _form.SuspendLayout();
            _pictureBox.Image = frame;
            _pictureBox.Refresh();
            _form.ResumeLayout(true);
        }
    }
}