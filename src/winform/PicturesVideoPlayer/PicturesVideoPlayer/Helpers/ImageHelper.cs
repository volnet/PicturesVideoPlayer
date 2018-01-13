using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicturesVideoPlayer.Helpers
{
    class ImageHelper
    {
        public delegate Stream GetStreamDelegate(string path);
        public static Image GetImage(string path, GetStreamDelegate handler)
        {
            Image img = null;
            Stream ms = handler(path);
            if (ms != null)
            {
                img = Image.FromStream(ms);
            }
            return img;
        }
    }
}
