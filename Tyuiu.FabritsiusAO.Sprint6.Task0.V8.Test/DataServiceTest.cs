using Tyuiu.FabritsiusAO.Sprint6.Task0.V8.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int x = 2;
            double wait = 4.95;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}