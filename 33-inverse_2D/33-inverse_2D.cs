using System;

///<summary> 31. Inverse #2 </summary>
class MatrixMath
{
	///<summary> method that calculates the inverse of a 2D matrix and returns the resulting matrix. </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] inv = new double[2, 2];

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] {{-1}};
        }
        
        double det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        if (det == 0)
        {
            return new double[,] {{-1}};
        }

        inv[0, 0] = matrix[1, 1] / det;
        inv[0, 1] = -matrix[0, 1] / det;
        inv[1, 0] = -matrix[1, 0] / det;
        inv[1, 1] = matrix[0, 0] / det;

        return inv;
    }
}
