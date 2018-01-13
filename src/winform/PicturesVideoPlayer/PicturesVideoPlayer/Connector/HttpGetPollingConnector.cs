using NLog;
using PicturesVideoPlayer.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesVideoPlayer.Connector
{
    class HttpGetPollingConnector : PollingConnector
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public HttpGetPollingConnector(Form form, PictureBox pictureBox, IContainer components)
            : base(form, pictureBox, components)
        {
            SetTimer(timerForPolling_Tick);
        }

        private bool updating = false;

        private void timerForPolling_Tick(object sender, EventArgs e)
        {
            if (!updating)
            {
                try
                {
                    updating = true;
                    string uri = Settings.Setting.Instance.SourceFrameURI;
                    Image image = ImageHelper.GetImage(uri, HttpHelper.GetFileStream);
                    if (image != null)
                    {
                        _logger.Debug("updating " + uri);
                        UpdateFrameToUI(image);
                    }
                }
                catch (Exception ex)
                {
                    _logger.Debug(ex.ToString());
                }
                finally
                {
                    updating = false;
                }
            }
        }
    }
}
