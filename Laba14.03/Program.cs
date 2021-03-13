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
            quadMatrix A = new quadMatrix(3, 0, 10);

            quadMatrix B = new quadMatrix(3, 0, 10);
            
            string choice;//переменная ввода


            while (true)
            {
                Console.WriteLine("\n=======================\n");
                Console.WriteLine("Matrix A:");
                Console.WriteLine(A.MatrixToString()+"\n");
                Console.WriteLine("Matrix B:");
                Console.WriteLine(B.MatrixToString()+"\n");
                Console.Write("Меню: \n " +
                    "1 - сложить \n " +
                    "2 - вычесть \n " +
                    "3 - умножить \n " +
                    "4 - сравнение \n " +
                    "5 - детерминант А \n " +
                    "6 - детерминант B \n " +
                    "f - ВЫХОД ИЗ ПРОГРАММЫ \n " +
                    "Ввод: ");
                choice = Console.ReadLine();
                Console.Clear();

                //проверка на выход
                if (choice == "f")
                {
                    Console.WriteLine("\n\n\n\nВЫХОД\n\n\n\n");
                    break;
                }
                switch (choice)//действия по нажатию
                {
                    case "1":
                        Console.WriteLine((A + B).MatrixToString());
                        break;
                    case "2":
                        Console.WriteLine((A - B).MatrixToString());
                        break;
                    case "3":
                        Console.WriteLine((A * B).MatrixToString());
                        break;
                    case "4":
                        Console.WriteLine(A > B);
                        break;
                    case "5":
                        Console.WriteLine(quadMatrix.Deta(A).det);
                        break;
                    case "6":
                        Console.WriteLine(quadMatrix.Deta(B).det);
                        break;
                    default:
                        Console.WriteLine("Введено некорректное значение");
                        break;
                }
            }
        }
    }
}
