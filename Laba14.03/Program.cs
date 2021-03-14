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
                    "3 - умножить матрицы \n " +
                    " 3.1 - умножить А на 2 \n " +
                    " 3.2 - умножить А на 3 \n " +
                    " 3.3 - умножить В на 2 \n " +
                    " 3.4 - умножить В на 3 \n " +
                    "4 - сравнение \n " +
                    "5 - детерминант А \n " +
                    "6 - детерминант B \n " +
                    "7 - GetHashCode A\n " +
                    "8 - GetHashCode B\n " +
                    "9 - Equals A \n " +
                    "10 - Увеличить A на 1 \n " +
                    "11 - Увеличить В на 1 \n " +
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
                    case "3.1":
                        Console.WriteLine((A * 2).MatrixToString());
                        break;
                    case "3.2":
                        Console.WriteLine((A * 3).MatrixToString());
                        break;
                    case "3.3":
                        Console.WriteLine((B * 2).MatrixToString());
                        break;
                    case "3.4":
                        Console.WriteLine((B * 3).MatrixToString());
                        break;
                    case "4":
                        Console.WriteLine(A > B);
                        break;
                    case "5":
                        Console.WriteLine(quadMatrix.Det(A).det);
                        break;
                    case "6":
                        Console.WriteLine(quadMatrix.Det(B).det);
                        break;
                    case "7":
                        Console.WriteLine(A.GetHashCode());
                        break;
                    case "8":
                        Console.WriteLine(B.GetHashCode());
                        break;
                    case "9":
                        Console.WriteLine(A.Equals(A,B));
                        break;
                    case "10":
                        Console.WriteLine((A++).MatrixToString());
                        break;
                    case "11":
                        Console.WriteLine((B++).MatrixToString());
                        break;
                    default:
                        Console.WriteLine("Введено некорректное значение");
                        break;
                }
            }
        }
    }
}
