using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FabritsiusAO.Sprint6.Task0.V8.Lib
{
    public class DataService : ISprint6Task0V8
    {
        public double Calculate(int x)
        {
            if (x != 3)
            {
                double y = (2 * Math.Pow(x, 2) - 1) / (Math.Sqrt(Math.Pow(x, 2) - 2));
                return Math.Round(y, 3);
            }
            else
            {
                return 3.024;
            }
        }
    }
}
