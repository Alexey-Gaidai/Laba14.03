using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14._03
{
    public class quadMatrix
    {
        public double[,] Matrix;
        public quadMatrix(int n, double A, double B)
        {
                double[,] Matrix = new double[n, n];
                Random Rnd = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        Matrix[i, j] = Math.Round((Rnd.NextDouble() * Math.Abs((A - B)) + Math.Min(A, B)), 0);
                this.Matrix = Matrix;
        }
        public string MatrixToString()
        {
            string text = "";
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (j != Matrix.GetLength(1) - 1) text += Matrix[i, j] + " ";
                    else text += Matrix[i, j];
                }
                if (i != Matrix.GetLength(0) - 1) text += '\n';
            }
            return text;
        }
        public static quadMatrix operator +(quadMatrix A, quadMatrix B)
        {

            for (int i = 0; i < A.Matrix.GetLength(0); i++)
                for (int j = 0; j < A.Matrix.GetLength(1); j++)
                    A.Matrix[i, j] += B.Matrix[i, j];
            return A;

        }

        public static quadMatrix operator -(quadMatrix A, quadMatrix B)
        {
            for (int i = 0; i < A.Matrix.GetLength(0); i++)
                for (int j = 0; j < A.Matrix.GetLength(1); j++)
                    A.Matrix[i, j] -= B.Matrix[i, j];
            return A;
        }

    }
}

