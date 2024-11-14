using System;
using Tyuiu.AvdeevAS.Sprint4.Task3.V30.Lib;

namespace Tyuiu.AvdeevAS.Sprint3.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #4                              *");
            Console.WriteLine("* Тема: <...>                                                             *");
            Console.WriteLine("*                              Задание #3                                 *");
            Console.WriteLine("*                              Вариант #30                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*     Найдите максимальный элемент в третьей строке массива.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");

            int[,] array =
            {
                { 2, 4, 3, 5, 1 },
                { 6, 6, 1, 2, 6 },
                { 3, 3, 2, 1, 5 },
                { 6, 4, 1, 3, 3 },
                { 5, 1, 1, 6, 4 }
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Максимальный элемент в третьей строке: " + ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
