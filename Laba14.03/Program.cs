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
                Console.WriteLine(A.MatrixToString()+"\n");
                Console.WriteLine(B.MatrixToString()+"\n");
                Console.Write("Меню: \n " +
                    "1 - сложить \n " +
                    "2 - вычесть \n " +
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
                    default:
                        Console.WriteLine("Введено некорректное значение");
                        break;
                }
            }
        }
    }
}
