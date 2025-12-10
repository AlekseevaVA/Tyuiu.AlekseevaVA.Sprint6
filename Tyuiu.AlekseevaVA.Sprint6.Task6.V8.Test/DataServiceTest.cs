using Tyuiu.AlekseevaVA.Sprint6.Task6.V8.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\виктория\Desktop\DataSprint5\InPutDataFileTask6V8.txt";

            var res = ds.CollectTextFromFile(path);
            string wait = "RizdogMOZpCb GqzgGQOdWpd ztMvvn";
            Assert.AreEqual(wait, res);

        }
    }
}
