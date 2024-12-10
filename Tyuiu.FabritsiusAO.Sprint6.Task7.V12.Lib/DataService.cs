using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FabritsiusAO.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            string[] lines = fileData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] mtrx = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    mtrx[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                if (mtrx[i, 8] != 10)
                {
                    mtrx[i, 8] = 0;
                }


            }
            return mtrx;
        }
    }
}
