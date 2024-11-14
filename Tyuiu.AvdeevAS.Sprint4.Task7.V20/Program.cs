using System;
using Tyuiu.AvdeevAS.Sprint4.Task7.V20.Lib;

namespace Tyuiu.AvdeevAS.Sprint4.Task7.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "357951248632587";

            Console.Title = "Спринт #4 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #4                              *");
            Console.WriteLine("* Тема: <...>                                                             *");
            Console.WriteLine("*                              Задание #7                                 *");
            Console.WriteLine("*                              Вариант #20                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Преобразовать строку в матрицу 5x3 и посчитать произведение четных *");
            Console.WriteLine("*      чисел.                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("Строка: " + value);

            Console.WriteLine();
            Console.WriteLine("Матрица 5x3:");
            int[,] matrix = new int[5, 3];
            for (int i = 0, k = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++, k++)
                {
                    matrix[i, j] = int.Parse(value[k].ToString());
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение четных чисел: " + ds.Calculate(5, 3, value));

            Console.ReadKey();
        }
    }
}
