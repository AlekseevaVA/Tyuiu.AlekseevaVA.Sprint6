using Tyuiu.AlekseevaVA.Sprint6.Task0.V23.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = -0.223;
            Assert.AreEqual(wait, res);

        }
    }
}
