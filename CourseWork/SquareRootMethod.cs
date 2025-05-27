using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal static class SquareRootMethod
    {
        public static Complex[] CalculateSLAE(SLAE slae, ref int practicalDifficulty)
        {
            int n = slae.Size;
            Complex[,] A = MakeMatrixCopy(slae.CoefficientMatrix);
            Complex[] b = new Complex[n];
            Array.Copy(slae.FreeMembers, b, n);

            Complex[,] L = new Complex[n, n];
            practicalDifficulty = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Complex sum = Complex.Zero;
                    for (int k = 0; k < j; k++)
                    {
                        sum += L[i, k] * Complex.Conjugate(L[j, k]);
                        practicalDifficulty++;
                    }

                    if (i == j)
                    {
                        L[i, j] = Complex.Sqrt(A[i, i] - sum);
                    }
                    else
                    {
                        L[i, j] = (A[i, j] - sum) / L[j, j];
                    }
                }
            }

            Complex[] y = new Complex[n];
            for (int i = 0; i < n; i++)
            {
                Complex sum = Complex.Zero;
                for (int k = 0; k < i; k++)
                {
                    sum += L[i, k] * y[k];
                    practicalDifficulty++;
                }
                y[i] = (b[i] - sum) / L[i, i];
            }

            Complex[] x = new Complex[n];
            for (int i = n - 1; i >= 0; i--)
            {
                Complex sum = Complex.Zero;
                for (int k = i + 1; k < n; k++)
                {
                    sum += Complex.Conjugate(L[k, i]) * x[k];
                    practicalDifficulty++;
                }
                x[i] = (y[i] - sum) / Complex.Conjugate(L[i, i]);
            }

            return x;
        }


        private static Complex[,] TransposeMatrix(Complex[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Complex[,] result = new Complex[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
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
            if (!IsPositiveDefinite(slae.CoefficientMatrix))
            {
                errorMessage = "Матриця коефіцієнтів повинна бути додатно визначеною для застосування методу Гауса-Холецького.";
                return false;
            }
            else if (!IsHermitian(slae.CoefficientMatrix))
            {
                errorMessage = "Матриця коефіцієнтів повинна бути ермітовою для застосування методу Гауса-Холецького.";
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool IsPositiveDefinite(Complex[,] matrix)
        {
            int n = matrix.GetLength(0);
            Complex[,] T = new Complex[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Complex sum = Complex.Zero;
                    for (int k = 0; k < i; k++)
                    {
                        sum += T[k, i] * Complex.Conjugate(T[k, j]);
                    }

                    if (i == j)
                    {
                        Complex val = matrix[i, i] - sum;
                        if (val.Real <= 0 || val.Imaginary != 0)
                            return false;

                        T[i, i] = Complex.Sqrt(val);
                    }
                    else
                    {
                        T[i, j] = (matrix[i, j] - sum) / T[i, i];
                    }
                }
            }

            return true;
        }

        private static bool IsHermitian(Complex[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != Complex.Conjugate(matrix[j, i]))
                        return false;
                }
            }
            return true;
        }

    }
}
