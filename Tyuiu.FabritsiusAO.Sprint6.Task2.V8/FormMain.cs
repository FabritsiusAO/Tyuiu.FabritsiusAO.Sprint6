using Tyuiu.FabritsiusAO.Sprint6.Task2.V8.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task2.V8
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(TBStart.Text);
                int endValue = Convert.ToInt32(TBEnd.Text);

                int len = ds.GetMassFunction(startValue, endValue).Length;

                double[] Array;
                Array = new double[len];
                Array = ds.GetMassFunction(startValue, endValue);
                this.chart1.Titles.Add("График Функции");
                this.chart1.ChartAreas[0].AxisX.Title = "Ось x";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startValue), Convert.ToString(Array[i]));
                    this.chart1.Series[0].Points.AddXY(startValue, Array[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные, переделывай", "Сэр, вы ошиблись", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 Таск 2 Вариант 8 Выполнил Фабрициус Андрей Олегович ИСТНб-24-1","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
