using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicturesVideoPlayer
{
    class Configs
    {
        private static string frameRelativePath = string.Empty;
        public static string FrameRelativePath
        {
            get
            {
                if (string.IsNullOrEmpty(frameRelativePath))
                {
                    frameRelativePath = "Video\\frame.jpg";
                }
                return frameRelativePath;
            }
            set
            {
                frameRelativePath = value;
            }
        }


        public static string FrameFullPath
        {
            get
            {
                return System.IO.Path.GetFullPath(FrameRelativePath);
            }
        }

        private static int fps = -1;
        public static int FPS
        {
            get
            {
                if (fps == -1)
                {
                    fps = 20;
                }
                return fps;
            }
            set
            {
                fps = value;
            }
        }
    }
}
