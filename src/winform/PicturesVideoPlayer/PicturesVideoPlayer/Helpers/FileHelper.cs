using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace PicturesVideoPlayer.Helpers
{
    class FileHelper
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public static Stream GetFileStream(string path)
        {
            try
            {
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
                    _logger.Debug("path IsNullOrEmpty");
                }
            }
            catch (Exception ex)
            {
                _logger.Debug(ex.ToString());
            }

            return null;
        }
    }
}
