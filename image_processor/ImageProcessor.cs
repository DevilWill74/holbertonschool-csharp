using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

///<summary> Class ImageProcessor </summary>
class ImageProcessor
{
    ///<summary> Inverse Method: produce inverse of given image </summary>
    public static void Inverse(string[] filenames)
    {
        foreach (string filename in filenames)
        {
            Bitmap bitmap = new Bitmap(filename);
            Color c;
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    c = bitmap.GetPixel(x, y);
                    c = Color.FromArgb(255, (255 - c.R), (255 - c.G), (255 - c.B));
                    bitmap.SetPixel(x, y, c);
                }
            }
            string new_filename = Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename);
            bitmap.Save(new_filename);
        }
    }
}
