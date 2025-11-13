using Tyuiu.KozyrevRA.Sprint6.Task2.V17.Lib;
namespace Tyuiu.KozyrevRA.Sprint6.Task2.V17
{
    public partial class FormMain_KRA : Form
    {
        public FormMain_KRA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KRA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KRA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_KRA.Titles.Add("График функции ");
                this.chartFunction_KRA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KRA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewAnswer_KRA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_KRA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТБ-25-1 Козырев Роман Артёмович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KRA.BackColor = Color.Blue;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KRA.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KRA.BackColor = Color.Green;
        }

        private void FormMain_KRA_Load(object sender, EventArgs e)
        {

        }
    }
}
