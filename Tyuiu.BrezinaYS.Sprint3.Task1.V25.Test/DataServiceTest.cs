using Tyuiu.BrezinaYS.Sprint3.Task1.V25.Lib;
namespace Tyuiu.BrezinaYS.Sprint3.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 2;
            int st = 1;
            int en = 6;
            double res = ds.GetMultiplySeries(value, st, en);
            double wait = 844.664;
            Assert.AreEqual(wait, res);
        }
    }
}