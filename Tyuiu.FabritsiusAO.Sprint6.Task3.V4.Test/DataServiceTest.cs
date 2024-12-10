using Tyuiu.FabritsiusAO.Sprint6.Task3.V4.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] Array = new int[3, 3] { { 1, 2, 2 }, { 2, 1, 2 }, { 3, 1, 1 } };
            int[,] WaitArray = new int[3, 3] { { 1, 2, 2 }, { 0, 1, 0 }, { 3, 1, 1 } };
            int[,] ResArray = new int[3, 3];
            ResArray = ds.Calculate(Array);
            CollectionAssert.AreEqual(WaitArray, ResArray);
        }
    }
}