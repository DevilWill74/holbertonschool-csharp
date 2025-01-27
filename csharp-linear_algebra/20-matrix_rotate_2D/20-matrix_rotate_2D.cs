using System;

///<summary>MatrixMath class</summary>
class MatrixMath
{
    ///<summary>
    /// Method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    ///</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Retourne une matrice contenant -1 si la matrice d'entrée n'est pas 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Matrice de rotation
        double[,] rotate = new double[2, 2]
        {
            { Math.Cos(angle), Math.Sin(angle) },
            { -Math.Sin(angle), Math.Cos(angle) }
        };

        // Matrice résultante
        double[,] result = new double[2, 2];

        // Calcul de la rotation : multiplication des matrices
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += matrix[i, k] * rotate[k, j];
                }
                // Arrondi à 2 décimales
                result[i, j] = Math.Round(result[i, j], 2);
            }
        }

        return result;
    }
}