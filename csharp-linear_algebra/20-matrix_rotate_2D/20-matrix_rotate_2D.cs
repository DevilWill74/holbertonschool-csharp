using System;

/// <summary>MatrixMath class</summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">A square 2D matrix (values only).</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>
    /// The resulting matrix after rotation,
    /// or a matrix containing -1 if the input is invalid.
    /// </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Validate that the input matrix is 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Create the resulting matrix
        double[,] result = new double[2, 2];

        // Apply rotation to each value of the matrix
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                double value = matrix[i, j];
                result[i, j] = Math.Round(
                    value * Math.Cos(angle) - value * Math.Sin(angle),
                    2
                );
            }
        }

        return result;
    }
}
