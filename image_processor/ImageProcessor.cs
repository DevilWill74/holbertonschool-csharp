using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

///<summary>Classe ImageProcessor pour le traitement des images</summary>
class ImageProcessor
{
    ///<summary>Inverse les couleurs d'une liste d'images</summary>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            try
            {
                using (Bitmap bitmap = new Bitmap(filename))
                {
                    Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                    BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);

                    IntPtr ptr = bmpData.Scan0;
                    int bytes = Math.Abs(bmpData.Stride) * bitmap.Height;
                    byte[] rgbValues = new byte[bytes];
                    System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                    for (int i = 0; i < rgbValues.Length; i += 3)
                    {
                        rgbValues[i] = (byte)(255 - rgbValues[i]);     // Blue
                        rgbValues[i + 1] = (byte)(255 - rgbValues[i + 1]); // Green
                        rgbValues[i + 2] = (byte)(255 - rgbValues[i + 2]); // Red
                    }

                    System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
                    bitmap.UnlockBits(bmpData);

                    string newFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                        Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename));

                    bitmap.Save(newFilename);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du traitement de {filename} : {ex.Message}");
            }
        });
    }
}
