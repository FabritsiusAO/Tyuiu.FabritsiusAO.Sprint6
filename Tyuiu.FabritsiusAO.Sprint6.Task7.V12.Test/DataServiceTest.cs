using Tyuiu.FabritsiusAO.Sprint6.Task7.V12.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Temp\InPutDataFileTask7V12.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] wait = { { -20, -12 }, { 7, 20 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}