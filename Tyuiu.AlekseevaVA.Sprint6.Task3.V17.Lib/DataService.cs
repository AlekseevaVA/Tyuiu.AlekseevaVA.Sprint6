using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlekseevaVA.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] result = (int[,])matrix.Clone();

            // Берем значения из 4-го столбца (индекс 3)
            int[] column = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                column[i] = matrix[i, 3];
            }

            // Сортируем значения 4-го столбца
            Array.Sort(column);

            // Заменяем значения в 4-м столбце на отсортированные
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                result[i, 3] = column[i];
            }

            return result;
        }
    }
}
    

