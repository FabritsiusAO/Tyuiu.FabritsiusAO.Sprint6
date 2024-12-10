using Tyuiu.FabritsiusAO.Sprint6.Task3.V4.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new();
        int[,] array = new int[5, 5] { { -14, -7, 18, 12, -20, }, { -2, -15, -19, -19, -3, }, { -18, -5, -10, 14, -17 }, { -1, 2, -10, 0, 11, }, { 6, -18, 0, 19, 16 } };

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void BRun_Click(object sender, EventArgs e)
        {
            array = ds.Calculate(array);
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                }
            }
        }

        private void BInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Выполнил студент группы ИСТНб-24-1 Фабрициус Андрей Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
