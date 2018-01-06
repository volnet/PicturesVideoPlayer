using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PicturesVideoGenerator
{
    class PicturesGenerator
    {
        public static int CreatePicture(int rnd, string fileName, string rawFileName)
        {
            try
            {
                Image img = null;
                if (string.IsNullOrEmpty(rawFileName))
                {
                    img = new Bitmap(500, 500);
                }
                else
                {
                    img = Bitmap.FromFile(rawFileName);
                }
                Graphics g = Graphics.FromImage(img);
                
                RectangleF rectangle1 = new RectangleF(rnd % 300 + 150, rnd % 300, rnd % 2000, rnd % 2000);
                g.FillEllipse(Brushes.Red, rectangle1);
                
                RectangleF rectangle2 = new RectangleF(rnd % 300, rnd % 300 + 200, rnd % 2000, rnd % 2000);
                g.FillEllipse(Brushes.Yellow, rectangle2);

                RectangleF rectangle3 = new RectangleF(rnd % 300 + 300, rnd % 300 + 200, rnd % 2000, rnd % 2000);
                g.FillEllipse(Brushes.Blue, rectangle3);

                img.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Dispose();
                g.Dispose();

                rnd += 10;
                return rnd % int.MaxValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return rnd;
            }
        }
    }
}
