using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PicturesVideoPlayer.Helpers
{
    class HttpHelper
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public static Stream GetFileStream(string url)
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
                _logger.Debug(e.Message);
            }
            return writer;
        }
    }
}
