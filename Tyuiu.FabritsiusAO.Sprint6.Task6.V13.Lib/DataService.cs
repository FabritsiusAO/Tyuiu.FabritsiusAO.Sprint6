using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FabritsiusAO.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            string[] strPath = File.ReadAllLines(path);
            for (int i = 0; i < strPath.Length; i++)
            {
                string[] lastStr = strPath[i].Split(' ');
                if (lastStr.Length >= 2)
                {
                    res += lastStr[lastStr.Length - 2];
                }
            }
            return res;
        }
    }
}