using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlekseevaVA.Sprint6.Task2.V6.Lib
{
    public class DataService : ISprint6Task2V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            for (int i = 0; i < length; i++)
            {
                int currentX = startValue + i;

                // Проверка деления на ноль
                if (Math.Abs(currentX - 0.7) < 0.0001)
                {
                    resultArray[i] = 0;
                }
                else
                {
                    // Вычисляем значение функции
                    double numerator = Math.Cos(currentX);
                    double denominator = currentX - 0.7;
                    double trigonometricPart = Math.Sin(currentX) * 12 * currentX;

                    double functionValue = (numerator / denominator) - trigonometricPart + 2;

                    // Округляем до двух знаков
                    resultArray[i] = Math.Round(functionValue, 2);
                }
            }

            return resultArray;
        }
    }
    
    
}
