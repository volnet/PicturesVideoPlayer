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
    abstract class UIConnector : IUIConnector
    {
        public abstract void RefreshStart();
        public abstract void RefreshStop();

        protected Form _form = null;
        protected PictureBox _pictureBox = null;
        protected IContainer _components = null;

        public UIConnector(Form form, PictureBox pictureBox, IContainer components)
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
        }

        protected void UpdateFrameToUI(Image frame)
        {
            //_form.SuspendLayout();
            _pictureBox.Image = frame;
            _pictureBox.Refresh();
            //_form.ResumeLayout(true);
        }
    }
}
