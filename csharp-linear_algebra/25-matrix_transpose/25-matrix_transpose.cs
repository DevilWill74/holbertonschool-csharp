using System;

/// <summary> 23. Transpose matrix </summary>
class MatrixMath
{
    /// <summary> method to transpose a matrix and return the resulting matrix. </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return new double[,] {};
        double[,] trmatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                trmatrix[j, i] = matrix[i, j];
            }
        }
        return trmatrix;
    }
}
