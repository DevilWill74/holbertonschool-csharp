using System;

/// <summary>MatrixMath class</summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a 2D or 3D matrix.
    /// </summary>
    /// <param name="matrix">The matrix to calculate the determinant of.</param>
    /// <returns>
    /// The determinant of the matrix, or -1 if the matrix is not 2D or 3D.
    /// </returns>
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Vérification des dimensions de la matrice
        if (rows != cols || (rows != 2 && rows != 3))
        {
            return -1;
        }

        // Cas d'une matrice 2x2
        if (rows == 2)
        {
            return Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
        }

        // Cas d'une matrice 3x3
        if (rows == 3)
        {
            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[0, 2];
            double d = matrix[1, 0];
            double e = matrix[1, 1];
            double f = matrix[1, 2];
            double g = matrix[2, 0];
            double h = matrix[2, 1];
            double i = matrix[2, 2];

            return Math.Round(
                a * ((e * i) - (f * h)) -
                b * ((d * i) - (f * g)) +
                c * ((d * h) - (e * g)),
                2
            );
        }

        return -1; // Ce point ne sera jamais atteint
    }
}
