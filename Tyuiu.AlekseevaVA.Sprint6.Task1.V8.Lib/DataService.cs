using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlekseevaVA.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Явно указываем порядок вычислений
                double denominator = x - 0.4;

                // Проверка деления на ноль (хотя для данного диапазона не нужно)
                if (Math.Abs(denominator) < 0.0001)
                {
                    result[index] = 0;
                }
                else
                {
                    double part1 = Math.Cos(x) / denominator;
                    double part2 = Math.Sin(x) * 8 * x;
                    double y = part1 + part2 + 2;

                    // Округляем с помощью форматирования для точности
                    result[index] = Math.Round(y, 2, MidpointRounding.AwayFromZero);
                }

                index++;
            }

            return result;
        }
    }
    
    
}
