using System;

/// <summary>MatrixMath class</summary>
class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The square 2D matrix to shear.</param>
    /// <param name="direction">The axis along which to shear ('x' or 'y').</param>
    /// <param name="factor">The shear factor.</param>
    /// <returns>
    /// The resulting matrix after shear transformation, or a matrix containing -1 if invalid.
    /// </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Vérifie si la matrice est 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Vérifie si la direction est valide ('x' ou 'y')
        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } };
        }

        // Crée la matrice de cisaillement
        double[,] shearMatrix = new double[2, 2];
        if (direction == 'x')
        {
            shearMatrix = new double[,]
            {
                { 1, factor },
                { 0, 1 }
            };
        }
        else if (direction == 'y')
        {
            shearMatrix = new double[,]
            {
                { 1, 0 },
                { factor, 1 }
            };
        }

        // Résultat
        double[,] result = new double[2, 2];

        // Applique la transformation
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = Math.Round(
                    matrix[i, 0] * shearMatrix[0, j] +
                    matrix[i, 1] * shearMatrix[1, j],
                    2
                );
            }
        }

        return result;
    }
}
