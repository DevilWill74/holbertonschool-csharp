using System;

///<summary> 20. Matrix rotation #1 </summary>
class MatrixMath
{
	///<summary> method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix. </summary>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		if (matrix.GetLength(1) > 2)
			return new double[,] {{-1}};
		double[,] nmatrix = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
		double[,] tp = new double[2, 2];

		for (int i = 0; i < 2; i++)
        {
			for (int j = 0; j < 2; j++)
            {
				for (int t = 0; t < 2; t++)
                {
					tp[i, j] = Math.Round(tp[i, j] + (matrix[i, t] * nmatrix[t, j]), 2);
                }
            }
        }
		return tp;
	}
}
