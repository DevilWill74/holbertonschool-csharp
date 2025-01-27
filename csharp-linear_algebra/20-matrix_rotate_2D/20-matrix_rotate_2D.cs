using System;

/// <summary>MatrixMath class</summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Vérifie que la matrice est carrée et de dimensions 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Définition de la matrice de rotation
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);
        double[,] rotationMatrix = new double[2, 2]
        {
            { cosTheta, -sinTheta },
            { sinTheta, cosTheta }
        };

        // Crée une nouvelle matrice pour stocker le résultat
        double[,] result = new double[2, 2];

        // Effectue la rotation : Multiplication des matrices
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = Math.Round(
                    matrix[i, 0] * rotationMatrix[0, j] +
                    matrix[i, 1] * rotationMatrix[1, j],
                    2
                );
            }
        }

        return result;
    }
}
