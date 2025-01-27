using System;

class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix to be multiplied (2D or 3D).</param>
    /// <param name="scalar">The scalar value to multiply the matrix by.</param>
    /// <returns>
    /// A new matrix with the result of the multiplication,
    /// or a matrix containing -1 if the input is invalid.
    /// </returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if ((rows != 2 && rows != 3) || (cols != 2 && cols != 3))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }
}
