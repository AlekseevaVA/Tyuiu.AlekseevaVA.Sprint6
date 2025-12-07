using Tyuiu.AlekseevaVA.Sprint6.Task1.V8.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] wait = new double[] { -36.41, -22.07, 5.68, 16.72, 8.34, -0.5, 9.63, 16.29, 5.01, -22.40, -36.30 };
            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Используем сравнение с допуском вместо точного равенства
            for (int i = 0; i < wait.Length; i++)
            {
                Assert.AreEqual(wait[i], res[i], 0.01,
                    $"Элемент с индексом {i} не совпадает. Ожидалось: {wait[i]}, Получено: {res[i]}");
            }
        }
    }
}
