using System;

class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians.
    /// </summary>
    /// <param name="matrix">A 2x2 matrix to rotate.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>
    /// The resulting matrix after rotation,
    /// or a matrix containing -1 if the input is invalid.
    /// </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the matrix is 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Rotation matrix
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        // Resulting matrix
        double[,] result = new double[2, 2];

        // Perform the rotation on each element
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                // Apply rotation to the element value
                result[i, j] = Math.Round(matrix[i, j] * cosTheta - matrix[i, j] * sinTheta, 2);
            }
        }

        return result;
    }
}
