using Tyuiu.AvdeevAS.Sprint4.Task1.V22.Lib;
namespace Tyuiu.AvdeevAS.Sprint4.Task1.V22
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
            Console.WriteLine("*                              Вариант #22                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Подсчитать произведение нечетных элементов массива.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("Введите 12 чисел от 2 до 9, по одному на каждой строке:");

            int[] array = new int[12];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение нечетных элементов массива: " + ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
