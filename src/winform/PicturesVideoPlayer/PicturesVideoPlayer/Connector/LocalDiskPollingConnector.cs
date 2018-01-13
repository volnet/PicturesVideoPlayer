using NLog;
using PicturesVideoPlayer.Helpers;
using System;
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
    class LocalDiskPollingConnector : PollingConnector
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public LocalDiskPollingConnector(Form form, PictureBox pictureBox, IContainer components)
            : base(form, pictureBox, components)
        {
            SetTimer(this.timerForPolling_Tick);
        }

        private void timerForPolling_Tick(object sender, EventArgs e)
        {
            try
            {
                string path = Settings.Setting.Instance.SourceFrameFullPath;
                Image image = ImageHelper.GetImage(path, FileHelper.GetFileStream);
                if (image != null)
                {
                    _logger.Debug("updating " + path);
                    UpdateFrameToUI(image);
                }
            }
            catch (Exception ex)
            {
                _logger.Debug(ex.ToString());
            }
        }
    }
}
