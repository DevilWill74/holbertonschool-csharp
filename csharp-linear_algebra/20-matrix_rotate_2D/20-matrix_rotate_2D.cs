using System;

///<summary>MatrixMath class</summary>
class MatrixMath
{
    ///<summary>method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix</summary>
    // resource : https://math.stackexchange.com/questions/1404484/how-is-that-a-rotation-by-an-angle-%CE%B8-about-the-origin-can-be-represented-by-this
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] defaultMatrix = new double[,] {{-1}};
        double[,] twoDmatrix = new double [2,2];
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}}; 
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);

        if (r != 2 || c != 2)
        {
           return defaultMatrix;
        }
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    twoDmatrix[i, j] = Math.Round(twoDmatrix[i, j] + (matrix[i, k] * rotate[k, j]), 2);
                }
            }
        }
        return twoDmatrix;
    }
}