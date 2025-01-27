using System;

class VectorMath
{
    /// <summary>
    /// Calculates and returns the magnitude (length) of a given vector.
    /// </summary>
    /// <param name="vector">A double array representing the vector.</param>
    /// <returns>The magnitude rounded to the nearest hundredth, or -1 if the vector is not 2D or 3D.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }
        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += Math.Pow(component, 2);
        }

        double magnitude = Math.Sqrt(sumOfSquares);

        return Math.Round(magnitude, 2);
    }
}
