using Tyuiu.AlekseevaVA.Sprint6.Task2.V6.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task2.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_AVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_AVA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_AVA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArr = new double[len];

                valueArr = ds.GetMassFunction(startStep, stopStep);
                
                this.chartFunction_AVA.Titles.Add("График функции F(x)");

                this.chartFunction_AVA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AVA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_AVA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArr[i]));
                    this.chartFunction_AVA.Series[0].Points.AddXY(startStep, valueArr[i]);

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

        private void buttonDone_AVA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_AVA.BackColor = Color.Red;
        }

        private void buttonDone_AVA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_AVA.BackColor = Color.Green;
        }

        private void buttonDone_AVA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_AVA.BackColor = Color.Blue;
        }

       

        private void buttonHelp_AVA_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб 25-1 Алексеева Виктория", "Сообщение");
        }
    }
}
