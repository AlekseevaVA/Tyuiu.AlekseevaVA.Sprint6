using Tyuiu.AlekseevaVA.Sprint6.Task2.V6.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] wait = { 59.49, 38.47, -2.81, -19.67, -8.42, 0.57, -6.30, -20.14, -3.51, 38.13, 59.60 };
            double[] res = ds.GetMassFunction(-5, 5);
            for (int i = 0; i < wait.Length; i++) Assert.AreEqual(wait[i], res[i], 0.01, $"Index {i}");
        }
    }
}
