using Tyuiu.FabritsiusAO.Sprint6.Task1.V7.Lib;
namespace Tyuiu.FabritsiusAO.Sprint6.Task1.V7
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxSTART.Text);
                int endValue = Convert.ToInt32(textBoxEND.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, endValue).Length;
                double[] array;
                array = new double[len];

                array = ds.GetMassFunction(startValue, endValue);
                textBoxOUT.Text = "";
                textBoxOUT.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOUT.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxOUT.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}    |    {1,5:f2}  |", startValue, array[i]);
                    textBoxOUT.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxOUT.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSTART_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEND_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Выполнил студент группы ИСТНб-24-1 Фабрициус Андрей Олегович","Сообщение",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
