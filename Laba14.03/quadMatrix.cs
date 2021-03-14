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
        public double[,] result;
        public double res1 = 0;
        public double res2 = 0;
        public double res3 = 0;
        public double det = 0;
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
            quadMatrix result = new quadMatrix(3, 0, 10);
            for (int i = 0; i < A.Matrix.GetLength(0); i++)
                for (int j = 0; j < A.Matrix.GetLength(1); j++)
                     result.Matrix[i, j] = A.Matrix[i, j] + B.Matrix[i, j];
            return result;
        }

        public static quadMatrix operator -(quadMatrix A, quadMatrix B)
        {
            quadMatrix result = new quadMatrix(3, 0, 10);
            for (int i = 0; i < A.Matrix.GetLength(0); i++)
                for (int j = 0; j < A.Matrix.GetLength(1); j++)
                    result.Matrix[i, j] = A.Matrix[i, j] - B.Matrix[i, j];
            return result;
        }

        public static quadMatrix operator *(quadMatrix A, quadMatrix B)
        {
            quadMatrix result = new quadMatrix(3, 0, 10);
            for (int i = 0; i < A.Matrix.GetLength(0); i++)
                for (int j = 0; j < A.Matrix.GetLength(1); j++)
                    result.Matrix[i, j] = A.Matrix[i, j] * B.Matrix[i, j];
            return result;
        }
        public static quadMatrix operator *(quadMatrix A, int a)
        {
            quadMatrix result = new quadMatrix(3, 0, 10);
            for (int i = 0; i < A.Matrix.GetLength(0); i++)
                for (int j = 0; j < A.Matrix.GetLength(1); j++)
                    result.Matrix[i, j] = A.Matrix[i, j] * a;
            return result;
        }

        public static quadMatrix operator >(quadMatrix A, quadMatrix B)
        {
            quadMatrix result = new quadMatrix(3, 0, 10);
            for (int i = 0; i < A.Matrix.GetLength(0); i++)
                for (int j = 0; j < A.Matrix.GetLength(1); j++)
                {
                    result.res1 += A.Matrix[i, j];
                    result.res2 += B.Matrix[i, j];
                }
            result.res3 = result.res1 - result.res2;
            if (result.res3 > 0)
                Console.WriteLine("Матрица А - больше на " + result.res3);
            if (result.res3 < 0)
                Console.WriteLine("Матрица B - больше на " + result.res3);
            return result;
        }
        public static quadMatrix operator <(quadMatrix A, quadMatrix B)
        {
            quadMatrix result = new quadMatrix(3, 0, 10);
            for (int i = 0; i < A.Matrix.GetLength(0); i++)
                for (int j = 0; j < A.Matrix.GetLength(1); j++)
                {
                    result.res1 += A.Matrix[i, j];
                    result.res2 += B.Matrix[i, j];
                }
            result.res3 = result.res1 - result.res2;
            if (result.res3 > 0)
                Console.WriteLine("Матрица А - больше " + result.res3);
            if (result.res3 < 0)
                Console.WriteLine("Матрица B - больше " + result.res3);
            return result;
        }

        public static quadMatrix Det(quadMatrix A)
        {
            quadMatrix result = new quadMatrix(3, 0, 10);
            result.det = ((A.Matrix[0, 0] * A.Matrix[1, 1] * A.Matrix[2, 2]) + (A.Matrix[0, 1] * A.Matrix[1, 2] * A.Matrix[2, 0]) + (A.Matrix[0, 2] * A.Matrix[1, 0] * A.Matrix[2, 1]))
              - (A.Matrix[0, 2] * A.Matrix[1, 1] * A.Matrix[2, 0]) - (A.Matrix[0, 1] * A.Matrix[1, 0] * A.Matrix[2, 2] - (A.Matrix[0, 0] * A.Matrix[1, 2] * A.Matrix[2, 1]));
            return result;
        }
      
        public override int GetHashCode()
        {
            return this.Matrix.GetHashCode();
        }
        public bool Equals(quadMatrix A, quadMatrix B)
        {
            return B.Matrix == A.Matrix;
        }
    }
}

