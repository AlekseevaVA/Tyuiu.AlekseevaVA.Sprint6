using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlekseevaVA.Sprint6.Task4.V7.Lib
{
    public class DataService : ISprint6Task4V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            double[] valueArray; // объявляем пустой массив
            int len = (stopValue - startValue) + 1; // вычисляем длину массива
            valueArray = new double[len]; // создаем массив с указанной длиной

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                // Проверка деления на ноль
                if (x + 2 == 0) // Проверяем знаменатель дроби cos(x)/(x+2)
                {
                    y = 0; // При делении на ноль возвращаем 0
                }
                else
                {
                    // Вычисляем F(x) = cos(x) + cos(x)/(x+2) - 3x
                    y = Math.Cos(x) + (Math.Cos(x) / (x + 2)) - (3 * x);

                    // Округляем значение до 2 знаков после запятой
                    y = Math.Round(y, 2);
                }

                valueArray[count] = y; // присваиваем значение в массив с индексом count
                count++;
            }

            return valueArray;
        }
    }
}
