using System;

class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two 2D or 3D vectors.
    /// </summary>
    /// <param name="vector1">First vector (2D or 3D).</param>
    /// <param name="vector2">Second vector (2D or 3D).</param>
    /// <returns>
    /// The dot product of the two vectors,
    /// or -1 if the vectors are not 2D/3D or are not of the same size.
    /// </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // Validate that both vectors are either 2D or 3D and of the same size
        if ((vector1.Length != 2 && vector1.Length != 3) || 
            (vector2.Length != 2 && vector2.Length != 3) || 
            vector1.Length != vector2.Length)
        {
            return -1;
        }

        // Calculate the dot product
        double dotProduct = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return dotProduct;
    }
}
