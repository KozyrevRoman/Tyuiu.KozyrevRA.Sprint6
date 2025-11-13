using Tyuiu.KozyrevRA.Sprint6.Task4.V12.Lib;
namespace Tyuiu.KozyrevRA.Sprint6.Task4.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_KRA_Click(object sender, EventArgs e)
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
                    textBoxAnswer_KRA.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartFunction_KRA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТБ-25-1 Козырев Роман Артёмович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSave_KRA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V12.txt");
                File.WriteAllText(path, textBoxAnswer_KRA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n  Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}
