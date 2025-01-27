using System;

class MatrixMath
{
    /// <summary>
    /// Rotates the values of a square 2D matrix by a given angle in radians.
    /// </summary>
    /// <param name="matrix">A square 2D matrix.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>
    /// A new matrix with the rotated values,
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

        // Calculate cos(angle) and sin(angle)
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        // Create a new matrix for the rotated values
        double[,] result = new double[rows, cols];

        // Apply rotation to each value in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double value = matrix[i, j];
                result[i, j] = (value * cosTheta) - (value * sinTheta);
            }
        }

        return result;
    }
}
