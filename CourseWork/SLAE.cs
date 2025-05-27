using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Microsoft.VisualBasic.ApplicationServices;
using MathNet.Numerics.LinearAlgebra;
using System.Security.Cryptography.X509Certificates;


namespace CourseWork
{
    internal class SLAE
    {
        private int size;
        private Complex[,] coefficientMatrix;
        private Complex[] freeMembers;
        public Complex[] roots = null;

        public const int MIN_SLAE_SIZE = 2;
        public const int MAX_SLAE_SIZE = 20;

        public const double MIN_VALUE = -10000;
        public const double MAX_VALUE = 10000;

        public int Size {  get { return size; } }
        public Complex[,] CoefficientMatrix { get { return coefficientMatrix; } }
        public Complex[] FreeMembers { get { return freeMembers; }}

        public SLAE(Complex[,] coefficientMatrix, Complex[] freeMembers) 
        {
            this.coefficientMatrix = coefficientMatrix;
            this.freeMembers = freeMembers;
            this.size = freeMembers.Length;
        }

        public bool IsSingular()
        {
            var m = Matrix<Complex>.Build.DenseOfArray(this.coefficientMatrix);
            Complex det = m.Determinant();
            return det != Complex.Zero;
        }

    }
}
