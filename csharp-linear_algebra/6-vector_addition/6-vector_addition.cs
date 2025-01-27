using System;

class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">First vector (2D or 3D).</param>
    /// <param name="vector2">Second vector (2D or 3D).</param>
    /// <returns>
    /// A new vector representing the sum of the two vectors,
    /// or a vector containing -1 if the inputs are invalid.
    /// </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Check if both vectors are either 2D or 3D and have the same size
        if ((vector1.Length != 2 && vector1.Length != 3) || 
            (vector2.Length != 2 && vector2.Length != 3) || 
            (vector1.Length != vector2.Length))
        {
            return new double[] { -1 };
        }

        // Add the corresponding components of the vectors
        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}
