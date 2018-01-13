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
    abstract class PollingConnector : UIConnector
    {
        public PollingConnector(Form form, PictureBox pictureBox, IContainer components)
            : base(form, pictureBox, components)
        {
            InitTimer();
        }

        public override void RefreshStart()
        {
            this._timerForPolling.Start();
        }

        public override void RefreshStop()
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
    }
}
