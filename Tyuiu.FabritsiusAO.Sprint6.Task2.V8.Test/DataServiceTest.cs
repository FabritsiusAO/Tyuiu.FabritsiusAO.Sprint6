using Tyuiu.FabritsiusAO.Sprint6.Task2.V8.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int startValue = 0;
            int endValue = 0;
            int len = startValue - endValue + 1;
            double[] waitArray = new double[len];
            double[] res = new double[len];
            waitArray[0] = 1;
            res = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(waitArray, res);
        }
    }
}