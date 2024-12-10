using System.Windows.Forms;
using Tyuiu.FabritsiusAO.Sprint6.Task7.V12.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task7.V12
{ //1
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
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.Title = "Выберите файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string[] lines = File.ReadAllLines(path);
                if (lines.Length == 0)
                {
                    MessageBox.Show("Ошибка");
                    return;
                }
                DGV_IN.Rows.Clear();
                DGV_IN.Columns.Clear();
                string[] firstrow = lines[0].Split(';');
                for (int i = 0; i < firstrow.Length; i++)
                {
                    DGV_IN.Columns.Add($"Column{i + 1}", $"Column{i + 1}");
                }
                foreach (string line in lines)
                {
                    string[] row = line.Split(';');
                    DGV_IN.Rows.Add(row);
                }
            }
        }

        private void BRun_Click(object sender, EventArgs e)
        {
            int rowcount = 10;
            int columncount = 10;
            int[,] matrix = new int[rowcount, columncount];
            for (int i = 0; i < rowcount; i++)
            {
                for (int j = 0; j < columncount; j++)
                {
                    if (DGV_IN.Rows[i].IsNewRow) continue;
                    string cellValue = DGV_IN[j, i].Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(cellValue) && int.TryParse(cellValue, out int result))
                    {
                        matrix[i, j] = result;
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка преобразования в строке {i + 1}, колонке {j + 1}: '{cellValue}' не является числом.");
                        return;
                    }
                }
            }
            DataService ds = new DataService();
            matrix = ds.GetMatrix(matrix);
            for (int i = 0; i < columncount; i++)
            {
                DGV_OUT.Columns.Add($"Column{i + 1}", $"Column{i + 1}");
            }
            for (int i = 0; i < rowcount; i++)
            {
                object[] newmatrix = new object[columncount];
                for (int j = 0; j < columncount; j++)
                {
                    newmatrix[j] = matrix[i, j];
                }
                DGV_OUT.Rows.Add(newmatrix);
            }
        }
    }
}
