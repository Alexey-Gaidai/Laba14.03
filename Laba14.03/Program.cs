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
            quadMatrix A = new quadMatrix(3, 0, 10);//матрица а
            quadMatrix aclone = A.DeepCopy();//копия а

            quadMatrix B = new quadMatrix(3, 0, 10);//матрица б
            quadMatrix bclone = B.DeepCopy();//копия б


            string choice;//переменная ввода


            while (true)//менюшка по приколу(логика)
            {
                Console.WriteLine("\n=======================\n"); //выводы
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
                        Console.WriteLine((aclone + bclone).MatrixToString());//используем прототип, я жек его зачем то создал, правильно?
                        break;
                    case "2":
                        Console.WriteLine((aclone - bclone).MatrixToString());
                        break;
                    case "3":
                        Console.WriteLine((aclone * bclone).MatrixToString());
                        break;
                    case "3.1":
                        Console.WriteLine((aclone * 2).MatrixToString());
                        break;
                    case "3.2":
                        Console.WriteLine((aclone * 3).MatrixToString());
                        break;
                    case "3.3":
                        Console.WriteLine((bclone * 2).MatrixToString());
                        break;
                    case "3.4":
                        Console.WriteLine((bclone * 3).MatrixToString());
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
                        Console.WriteLine(B.Equals(A,B));//по сути не имеет значения к методу какого класса обращаться, главное что он сравнивает отправляемые в него значеня
                        break;
                    case "10":
                        Console.WriteLine((A++).MatrixToString());
                        /*кстати интересный факт: когда меняется класс то дипкопи меняется вместе с ним, копируя полностью его поведение, 
                        это я проверил на инкременте. Когда мы увеличивает матрицу на один, то и клон так же увеличивается на один. 
                        например запустим программу: сделаем сложение, запомним, увеличим и сложим опять, вау, разные результаты обалдеть,mindblowing!!!*/
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
