using System;

class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">A double array representing the vector (2D or 3D).</param>
    /// <param name="scalar">A double representing the scalar value.</param>
    /// <returns>
    /// A new vector with the result of the multiplication,
    /// or a vector containing -1 if the input vector is invalid.
    /// </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return new double[] { -1 };
        }

        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}
