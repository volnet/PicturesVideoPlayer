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
        public LocalDiskPollingConnector(Form form, PictureBox pictureBox, IContainer components)
            : base(form, pictureBox, components)
        {
            SetTimer(this.timerForPolling_Tick);
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
                string path = Settings.Setting.Instance.SourceFrameFullPath;
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
    }
}
