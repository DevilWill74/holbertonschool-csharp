using System;

///<summary>MatrixMath class</summary>
class MatrixMath
{
    ///<summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    ///</summary>
    /// <param name="matrix">A 2x2 matrix to rotate.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>
    /// The resulting matrix after rotation, or a matrix containing -1 if the input is invalid.
    /// </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Validation : Vérifie si la matrice est 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Matrice de rotation
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);
        double[,] rotationMatrix = new double[2, 2]
        {
            { cosTheta, -sinTheta },
            { sinTheta, cosTheta }
        };

        // Résultat
        double[,] result = new double[2, 2];

        // Appliquer la rotation
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
