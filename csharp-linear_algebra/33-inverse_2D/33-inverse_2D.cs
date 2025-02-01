﻿using System;

///<summary>MatrixMAth class</summary>
class MatrixMath
{
    ///<summary>method that calculates the inverse of a 2D matrix and returns the resulting matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        
        if (row != 2 && column != 2)
        {
            return new double[,] {{-1}};
        }

        double det = (matrix[0,0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        if (det == 0)
        {
            return new double[,] {{-1}};
        }

        double[,] inverse = new double[,] {{Math.Round((1 / det) * matrix[1, 1], 2), Math.Round((1 / det) * -matrix[0, 1], 2)}, {Math.Round((1 / det) * -matrix[1, 0], 2), Math.Round((1 / det) * matrix[0, 0],2)}};
        return inverse;
    }
}
