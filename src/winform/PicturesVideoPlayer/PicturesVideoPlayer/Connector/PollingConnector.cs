using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesVideoPlayer.Connector
{
    abstract class PollingConnector : IUIConnector
    {
        private Form _form = null;
        private PictureBox _pictureBox = null;
        private IContainer _components = null;

        public PollingConnector(Form form, PictureBox pictureBox, IContainer components)
        {
            if (form == null)
                throw new ArgumentNullException("form");
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
            this._timerForPolling.Interval = 1000 / Settings.Setting.Instance.FPS;
        }

        protected void SetTimer(EventHandler handler)
        {
            this._timerForPolling.Tick += new System.EventHandler(handler);
        }

        protected void UpdateFrameToUI(Image frame)
        {
            _form.SuspendLayout();
            _pictureBox.Image = frame;
            _pictureBox.Refresh();
            _form.ResumeLayout(true);
        }
    }
}
