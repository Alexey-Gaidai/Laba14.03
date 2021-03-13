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
            quadMatrix A = new quadMatrix(3, 0, 9);
            Console.WriteLine(A.MatrixToString());
            Console.WriteLine();

            quadMatrix B = new quadMatrix(3, 0, 9);
            Console.WriteLine(B.MatrixToString());
            Console.WriteLine();

            Console.WriteLine((A + B).MatrixToString);
            Console.ReadKey();
        }

    }
}
