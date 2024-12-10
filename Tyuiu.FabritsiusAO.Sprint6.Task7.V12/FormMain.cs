using System.Windows.Forms;
using Tyuiu.FabritsiusAO.Sprint6.Task7.V12.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new();
        static int rows;
        static int cols;
        static string OpenFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string Data = File.ReadAllText(filePath);

            Data = Data.Replace('\n', '\r');
            string[] lines = Data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] ArrayValues = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    ArrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return ArrayValues;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 Выполнил студент группы ИСТНб-24-1 Фабрициус Андрей Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BOpen_Click(object sender, EventArgs e)
        {
            int[,] ArrayValues = new int[rows, cols];
            DGV_IN.ColumnCount = cols;
            DGV_IN.RowCount = rows;
            DGV_OUT.ColumnCount = cols;
            DGV_OUT.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                DGV_IN.Columns[i].Width = 25;
                DGV_OUT.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    DGV_IN.Rows[i].Cells[j].Value = ArrayValues[i,j];
                }
            }
            ArrayValues = ds.GetMatrix(LoadFromFileData(OpenFilePath));
            BRun.Enabled = true;
        }
    }
}
