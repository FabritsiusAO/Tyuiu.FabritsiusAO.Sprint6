using System.IO;
using System.Windows.Forms;
using Tyuiu.FabritsiusAO.Sprint6.Task7.V12.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task7.V12
{ //1
    public partial class FormMain : Form
    {
        DataService ds = new();
        static int rows;
        static int cols;
        static string path;
        public static int[,] mtr(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;


            int[,] arr = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string[] linr = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arr[r, c] = Convert.ToInt32(linr[c]);
                }
            }
            return arr;
        }
        public FormMain()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
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
            {
                openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog1.Title = "Выберите файл";
                int[,] arr = new int[rows, cols];
                arr = mtr(path);
                DGV_IN.ColumnCount = cols;
                DGV_OUT.ColumnCount = cols;
                DGV_IN.RowCount = rows;
                DGV_OUT.RowCount = rows;
                for (int i = 0; i < cols; i++)
                {
                    DGV_IN.Columns[i].Width = 25;
                    DGV_OUT.Columns[i].Width = 25;
                }
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        DGV_IN.Rows[r].Cells[c].Value = arr[r, c];
                    }
                }
            }
        }

        private void BRun_Click(object sender, EventArgs e)
        {
            {
                int[,] arr = new int[rows, cols];
                arr = ds.GetMatrix(path);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        DGV_OUT.Rows[r].Cells[c].Value = arr[r, c];
                    }
                }
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog.FileName = "OutPutTask7.csv";
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog.ShowDialog();

                string path1 = saveFileDialog.FileName;
                FileInfo fi = new FileInfo(path1);
                bool fe = fi.Exists;
                if (fe)
                {
                    File.Delete(path1);
                }
                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j != cols - 1)
                        {
                            str = str + DGV_OUT.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + DGV_OUT.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path1, str + Environment.NewLine);
                    str = "";
                }

            }

        }
    }
    
}
