using Tyuiu.AlekseevaVA.Sprint6.Task4.V7.Lib;


namespace Tyuiu.AlekseevaVA.Sprint6.Task4.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartFunction_AVA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_AVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVD_AVA.Text);
                int stopStep = Convert.ToInt32(textBoxV2D_AVA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] array = new double[len];

                array = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_AVA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AVA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_AVA.Text = "";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_AVA.Series[0].Points.AddXY(startStep, array[i]);

                    textBoxResult_AVA.AppendText(array[i] + Environment.NewLine);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб 25-1 Алексеева Виктория", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_AVA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4v7.txt";
                File.WriteAllText(path, textBoxResult_AVA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        

    }



    

}
