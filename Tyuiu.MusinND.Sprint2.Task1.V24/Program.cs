using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusinND.Sprint2.Task1.V24.Lib;

namespace Tyuiu.MusinND.Sprint1.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Мусин Никита Денисович | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Базовые навыки работы в C#                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Мусин Никита Денисович | ИИПБ-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений(==, !=, <, >, <=, >=,          *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций(|, &, ||, &&, !, ^, последовательность *");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False,     *");
            Console.WriteLine("* True, False, True, False)                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* a = 325, b = 325, c = 242, d = 324                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите d:");
            int d = Convert.ToInt32(Console.ReadLine());

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.WriteLine();       
            Console.ReadKey();
        }
    }
}
