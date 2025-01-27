using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if matrix is null
        if (matrix == null)
            return new double[,] { { -1 } };

        // Get matrix dimensions
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if matrix is square
        if (rows != cols)
            return new double[,] { { -1 } };

        // Create result matrix with same dimensions
        double[,] rotated = new double[rows, cols];

        // Create rotation matrix
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        // Apply rotation to each element
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Apply 2D rotation formula
                double x = matrix[i, j];
                rotated[i, j] = x * cos;
            }
        }

        return rotated;
    }
}
