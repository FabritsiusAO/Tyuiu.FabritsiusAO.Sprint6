using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FabritsiusAO.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 8] != 10)
                {
                    matrix[i, 8] = 0;
                }
            }
            return matrix;
        }

        int[,] ISprint6Task7V12.GetMatrix(string path)
        {
            int[,] array = new int[10, 10]
{
            {17, 17, -7, -19, -4, 6, 4, -17, 0, 13},
            {-13, -13, -7, -15, -12, -1, 15, 18, 0, -19},
            {9, -12, -9, 8, -12, 20, 10, -6, 0, -1},
            {-15, -19, 19, 16, -15, -19, 8, -2, 0, -18},
            {-14, -9, -19, 20, -3, 8, -10, 4, 0, 12},
            {-18, -4, -14, 20, -20, 17, -18, -19, 0, 6},
            {17, 14, 1, -18, 0, 2, -3, -9, 0, -13},
            {-14, -10, -15, 19, 12, -18, 6, 15, 0, -16},
            {19, 18, 14, 5, 8, 4, -13, 10, 0, 20},
            {-7, 3, 12, 7, -1, -13, -6, 3, 0, -8}
};
            return array;
        }
    }
}
