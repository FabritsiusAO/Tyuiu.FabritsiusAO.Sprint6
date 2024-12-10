using Tyuiu.FabritsiusAO.Sprint6.Task4.V19.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task4.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BRun_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(TBStart.Text);
                int end = Convert.ToInt32((TBEnd.Text));


                double[] valueArray = ds.GetMassFunction(start, end);

                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                TBRes.Text = string.Empty;

                this.chart1.Series[0].Points.Clear();
                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.chart1.Series[0].Points.AddXY(start, valueArray[i]);
                    this.TBRes.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Вышла ошибка", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetTempFileName();
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, TBRes.Text);



                DialogResult dialogResult = MessageBox.Show("Файл сохранён.\nОткрыть его в блокноте?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Произошел сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
