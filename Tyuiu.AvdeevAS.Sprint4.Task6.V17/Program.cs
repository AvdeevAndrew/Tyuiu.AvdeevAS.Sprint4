using System;
using Tyuiu.AvdeevAS.Sprint4.Task6.V17.Lib;

namespace Tyuiu.AvdeevAS.Sprint4.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            Console.Title = "Спринт #4 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #4                              *");
            Console.WriteLine("* Тема: <...>                                                             *");
            Console.WriteLine("*                              Задание #6                                 *");
            Console.WriteLine("*                              Вариант #17                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Подсчитать количество элементов, длина которых равна 6.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество элементов с длиной 6: " + ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
