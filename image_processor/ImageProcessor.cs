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

    /// <summary> Grayscale Method: produce greyscale image of given image </summary>
    public static void Grayscale(string[] filenames) 
    {
        foreach (string filename in filenames)
        {
            Bitmap bitmap = new Bitmap(filename);
            Color c;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    c = bitmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    bitmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            string new_filename = Path.GetFileNameWithoutExtension(filename) + "_grayscale" + Path.GetExtension(filename);
            bitmap.Save(new_filename);
        }
    }

    /// <summary> BlackWhite Method: produce a black/white image from a given image </summary>
    public static void BlackWhite(string[] filenames, double threshold) {
    {
        foreach (string filename in filenames)
        {
            Bitmap bitmap = new Bitmap(filename);
            Color c;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    c = bitmap.GetPixel(i, j);
                    double luminance = ((c.R * 0.3) + (c.G * 0.59) + (c.B * 0.11));
                    if (luminance < threshold)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            string new_filename = Path.GetFileNameWithoutExtension(filename) + "_bw" + Path.GetExtension(filename);
            bitmap.Save(new_filename);
            }
        }
    }
    /// <summary> Thumbnail Method: produce a thumbnail image from a given image </summary>
    public static void Thumbnail(string[] filenames, int height)
    {
        foreach (string filename in filenames)
        {
            Bitmap bmap = new Bitmap(filename);
            //Color c;
            int imageHeight = bmap.Height;
            int imageWidth = bmap.Width;
            double aspectRatioX = (double)imageWidth / imageHeight;
            int thumbWidth = (int)(height * aspectRatioX);

            Image thumb = bmap.GetThumbnailImage(thumbWidth, height, ()=>false, IntPtr.Zero);

            var qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
            var quality = (long)100; //Image Quality 
            var ratio = new EncoderParameter(qualityEncoder, quality);
            var codecParams = new EncoderParameters(1);
            codecParams.Param[0] = ratio;
            var codecInfo = GetEncoder(ImageFormat.Jpeg);

            string new_filename = Path.GetFileNameWithoutExtension(filename) + "_th" + Path.GetExtension(filename);
            thumb.Save(new_filename, codecInfo, codecParams);
        }
    }

    ///<summary> GetEncoder Method </summary>
    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
        foreach (ImageCodecInfo codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }
}
