using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.ComponentModel.Design.Serialization;

namespace CourseWork
{
    internal static class GaussianMethod
    {
        public static Complex[] CalculateSLAE(SLAE slae, ref int practicalDifficulty)
        {
            Complex[,] coefficient_matrix = MakeMatrixCopy(slae.CoefficientMatrix);
            Complex[] freeMembers = new Complex[slae.Size];
            Array.Copy(slae.FreeMembers, freeMembers, slae.Size);

            Complex[] roots = new Complex[slae.Size];
            int n = slae.Size;

            practicalDifficulty = 0;

            for (int k = 0; k < n; k++)
            {
                Complex pivot = coefficient_matrix[k, k];

                for (int j = k; j < n; j++)
                {
                    coefficient_matrix[k, j] /= pivot;
                    practicalDifficulty++;
                }
                freeMembers[k] /= pivot;

                for (int i = k + 1; i < n; i++)
                {
                    Complex factor = coefficient_matrix[i, k];
                    for (int j = k; j < n; j++)
                    {
                        coefficient_matrix[i, j] -= factor * coefficient_matrix[k, j];
                        practicalDifficulty++;
                    }
                    freeMembers[i] -= factor * freeMembers[k];
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Complex sum = Complex.Zero;
                for (int j = i + 1; j < n; j++)
                {
                    sum += coefficient_matrix[i, j] * roots[j];
                    practicalDifficulty++;
                }
                roots[i] = freeMembers[i] - sum;
            }

            return roots;
        }

        private static Complex[,] MakeMatrixCopy(Complex[,] matrix) 
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            Complex[,] copy = new Complex[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    copy[i, j] = matrix[i, j];
                }
            }

            return copy;
        }

        public static bool CheckMethodConditions(SLAE slae, ref string errorMessage)
        {
            for (int i = 0; i < slae.Size; i++) 
            {
                if (slae.CoefficientMatrix[i, i] == Complex.Zero)
                {
                    errorMessage = "Діагональні елементи не можуть бути 0 для методу Гауса.";
                    return false;
                }
            }
            return true;
        }
    }
}
