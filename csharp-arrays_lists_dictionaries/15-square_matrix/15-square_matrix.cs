using System;

class Matrix
    {
    public static int[,] Square(int[,] myMatrix)
    {
        int width = myMatrix.GetLength(0);
        int height = myMatrix.GetLength(1);
        int[,] newMatrix = new int[width,height];
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                double v = Math.Pow(myMatrix[x, y], 2);
                newMatrix[x, y] = (int)v;
            }
        }
        return newMatrix;
    }
}