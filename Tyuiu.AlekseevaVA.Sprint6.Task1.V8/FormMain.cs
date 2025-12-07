using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Tyuiu.AlekseevaVA.Sprint6.Task1.V8.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonDone_AVA_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_AVA.Text);
                int stop = Convert.ToInt32(textBoxEnd_AVA.Text);
                string str;
                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+-----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("+    X      +    F(x)  +" + Environment.NewLine);
                textBoxResult.AppendText("+-----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {

                    str = String.Format("|{0,6:d}   |  {1,7:f2}   |", start, value[i]);
                    textBoxResult.AppendText(str + Environment.NewLine);
                    start++;
                }
                textBoxResult.AppendText("+-----------+----------+" + Environment.NewLine);
                

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Таск 1 выполнила студентка группы ИИПб 25-1 Алексеева Виктория",
                               "Сообщение");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }


    }
}
