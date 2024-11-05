using Tyuiu.BrezinaYS.Sprint3.Task2.V19.Lib;
namespace Tyuiu.BrezinaYS.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int st = 1;
            int en = 10;
            double res = ds.GetSumSeries(st, en);
            double wait = -0.709;
            Assert.AreEqual(wait, res);
        }
    }
}