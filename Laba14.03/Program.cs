using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14._03
{
    class Program
    {
        static void Main(string[] args)
        {
            quadMatrix one = new quadMatrix();
            int m = 3;
            int n = 3;
            double A = 3;
            double B = 3;
            one.MaterialMatrix(m, n, A, B);
            one.MatrixToString();
           
        }
    }
}
