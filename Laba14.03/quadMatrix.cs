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
        public string text;
        public void MaterialMatrix(int m, int n, double A, double B)
        {

            double[,] Matrix = new double[m, n];
            Random Rnd = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    Matrix[i, j] = Math.Round((Rnd.NextDouble() * Math.Abs((A - B)) + Math.Min(A, B)), 0);
            this.Matrix = Matrix;
        }
        public string MatrixToString()
        {
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
            Console.WriteLine(text);
        }
    }
}

