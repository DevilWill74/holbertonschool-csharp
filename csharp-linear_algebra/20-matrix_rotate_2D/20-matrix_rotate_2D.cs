using System;

class MatrixMath
{
    /// <summary>
    /// Rotates the values of a square 2D matrix by a given angle in radians.
    /// </summary>
    /// <param name="matrix">A square 2D matrix.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>
    /// A new matrix with rotated values,
    /// or a matrix containing -1 if the input matrix is invalid.
    /// </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the matrix is square
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        // Calculate rotation matrix
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        double[,] result = new double[rows, cols];

        // Rotate each element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = matrix[i, j];
                result[i, j] = x * cosTheta + x * sinTheta;
            }
        }

        return result;
    }
}
