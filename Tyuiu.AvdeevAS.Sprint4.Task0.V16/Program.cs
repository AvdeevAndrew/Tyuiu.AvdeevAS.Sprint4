using System;
using Tyuiu.AvdeevAS.Sprint4.Task0.V16.Lib;

namespace Tyuiu.AvdeevAS.Sprint3.Task0.V16
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
            Console.WriteLine("*                              Задание #0                                 *");
            Console.WriteLine("*                              Вариант #16                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Подсчитать произведение четных элементов массива.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            Console.WriteLine("Массив: { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 }");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение четных элементов массива: " + ds.GetMultEvenArrEl(array));

            Console.ReadKey();
        }
    }
}
