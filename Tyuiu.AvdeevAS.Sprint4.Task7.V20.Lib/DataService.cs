using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AvdeevAS.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int product = 1;
            bool hasEven = false;

            // Заполнение матрицы из строки
            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++, k++)
                {
                    matrix[i, j] = int.Parse(value[k].ToString());

                    // Если элемент четный, включаем его в произведение
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                    }
                }
            }

            return hasEven ? product : 0; // Если нет четных чисел, возвращаем 0
        }
    }
}
