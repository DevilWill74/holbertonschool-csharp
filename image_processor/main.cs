using System;
using System.Drawing;
using System.IO;

public class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (string filepath in filenames)
        {
            try
            {
                // Charger l'image
                using (Bitmap bitmap = new Bitmap(filepath))
                {
                    // Inverser les couleurs pixel par pixel
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            Color pixel = bitmap.GetPixel(x, y);
                            Color invertedColor = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                            bitmap.SetPixel(x, y, invertedColor);
                        }
                    }

                    // Générer le nom de fichier de sortie
                    string directory = Path.GetDirectoryName(filepath);
                    string filenameWithoutExtension = Path.GetFileNameWithoutExtension(filepath);
                    string extension = Path.GetExtension(filepath);
                    string newFileName = $"{filenameWithoutExtension}_inverse{extension}";
                    string newFilePath = Path.Combine(directory, newFileName);

                    // Sauvegarder l'image inversée
                    bitmap.Save(newFilePath);
                }

                Console.WriteLine($"Image inversée créée : {filepath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors du traitement de l'image {filepath}: {e.Message}");
            }
        }
    }
}
