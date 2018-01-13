using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

            Console.WriteLine("It will generate new picture here:");
            Console.WriteLine(outputFramePath);
            Console.WriteLine("Please enter frame name like 'frame.jpg' for replacing or press 'Enter' key by default '<datetime>.jpg':");
            string fileName = Console.ReadLine();
            GetFileNameDelegate getFileName = null;

            if (string.IsNullOrEmpty(fileName))
            {
                getFileName = () => { return DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg"; };
            }
            else
            {
                getFileName = () => { return fileName; };
            }

            while (true)
            {
                string path = outputFramePath + getFileName();
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " creating jpg.");
                rnd = PicturesGenerator.CreatePicture(rnd, path, rawFramePath);
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + path + " created.");
                Console.WriteLine();
                Thread.Sleep(1000 ); //30fps
            }
        }

        public delegate string GetFileNameDelegate();

        /// <summary>
        /// DownloadFile("http://192.168.1.102:8080/shot.jpg", @"E:\MyCSharpProject\Projects\wanda\github.com\volnet\PicturesVideoPlayer\src\winform\PicturesVideoPlayer\PicturesVideoPlayer\bin\Debug\Video\frame.jpg");
        /// </summary>
        /// <param name="url"></param>
        /// <param name="savePath"></param>
        public static void DownloadFile(string url, string savePath)
        {
            try
            {
                int blocksize = 1024 * 100 * 100;
                byte[] buffer = new byte[blocksize];

                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                using (Stream reader = response.GetResponseStream())
                {
                    using (FileStream writer = new FileStream(savePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        int c = 0;
                        while ((c = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            writer.Write(buffer, 0, c);
                        }
                        writer.Close();
                    }
                    reader.Close();
                }
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
