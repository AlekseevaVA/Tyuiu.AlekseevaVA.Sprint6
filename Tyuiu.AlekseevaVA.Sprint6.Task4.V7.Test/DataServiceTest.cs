using Tyuiu.AlekseevaVA.Sprint6.Task4.V7.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startStep = -5;
            int stopStep = 5;
            double[] wait = { 15.19, 11.67, 9, 0, 4.08, 1.5, -2.28, -6.52, -10.19, -12.76, -14.68 };
            double[] res = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
