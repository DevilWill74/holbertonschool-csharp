using System;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;

public class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            try
            {
                using (Bitmap original = new Bitmap(filename))
                {
                    int width = original.Width;
                    int height = original.Height;
                    
                    Bitmap invertedImage = new Bitmap(width, height);

                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            Color pixel = original.GetPixel(x, y);
                            Color invertedPixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                            invertedImage.SetPixel(x, y, invertedPixel);
                        }
                    }
                    
                    string directory = AppDomain.CurrentDomain.BaseDirectory;
                    string newFileName = Path.Combine(directory, Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename));
                    invertedImage.Save(newFileName);
                    invertedImage.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing {filename}: {ex.Message}");
            }
        });
    }
}
