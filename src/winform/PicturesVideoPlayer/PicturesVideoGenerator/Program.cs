using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PicturesVideoGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd = new Random(DateTime.Now.Millisecond).Next(0, 10000);
            string outputFramePath = GetOutputFramePath();
            string rawFramePath = GetRawFramePath();
            while (true)
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " creating jpg.");
                rnd = PicturesGenerator.CreatePicture(rnd, outputFramePath, rawFramePath);
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " created.");
                Console.WriteLine();
                Thread.Sleep(1000 / 30); //30fps
            }
        }

        static string GetOutputFramePath()
        {
            return System.IO.Path.GetFullPath(System.Configuration.ConfigurationManager.AppSettings["OutputFramePath"]);
        }

        static string GetRawFramePath()
        {
            string videoFramePath = System.IO.Path.GetFullPath("Video\\raw.bmp");
            return videoFramePath;
        }
    }
}
