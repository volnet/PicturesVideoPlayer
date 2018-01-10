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
        public HttpGetPollingConnector(Form form, PictureBox pictureBox, IContainer components)
            : base(form, pictureBox, components)
        {
            SetTimer(timerForPolling_Tick);
        }

        private bool isGetting = false;

        private void timerForPolling_Tick(object sender, EventArgs e)
        {
            if (!isGetting)
            {
                isGetting = true;
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
                finally
                {
                    isGetting = false;
                }
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
                string uri = Settings.Setting.Instance.SourceFrameURI;
                if (!string.IsNullOrEmpty(uri))
                {
                    Console.WriteLine("Download URI = " + uri);
                    return DownloadFile(uri);
                }
                else
                {
                    Console.WriteLine("Download URI = [null]");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }
        
        public static Stream DownloadFile(string url)
        {
            MemoryStream writer = null;
            try
            {
                int blocksize = 1024 * 100 * 100;
                byte[] buffer = new byte[blocksize];

                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                using (Stream reader = response.GetResponseStream())
                {
                    writer = new MemoryStream();
                    int c = 0;
                    while ((c = reader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        writer.Write(buffer, 0, c);
                    }
                    reader.Close();
                }
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return writer;
        }
    }
}
