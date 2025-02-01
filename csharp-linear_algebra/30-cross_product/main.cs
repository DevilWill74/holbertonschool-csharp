using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] vect_A = { 3, -5, 4 };
        double[] vect_B = { 2, 6, 5 };
        double[] cross_P = new double[3];

        cross_P = VectorMath.CrossProduct(vect_A, vect_B);

        foreach (var item in cross_P)
        {
            Console.WriteLine(item);
        }
    }
}
