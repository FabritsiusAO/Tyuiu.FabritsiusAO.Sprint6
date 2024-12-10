using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FabritsiusAO.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            throw new NotImplementedException();
        }
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 9; j < cols; j++)
                {
                    if (matrix[i, j] != 10)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
