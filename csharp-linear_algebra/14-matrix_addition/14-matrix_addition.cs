using System;

class MatrixMath
{
    /// <summary>
    /// Adds two 2D or 3D matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">First matrix (2D or 3D).</param>
    /// <param name="matrix2">Second matrix (2D or 3D).</param>
    /// <returns>
    /// The resulting matrix of the addition,
    /// or a matrix containing -1 if the inputs are invalid.
    /// </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if ((rows1 != 2 && rows1 != 3) || (cols1 != 2 && cols1 != 3) ||
            rows1 != rows2 || cols1 != cols2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, cols1];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
