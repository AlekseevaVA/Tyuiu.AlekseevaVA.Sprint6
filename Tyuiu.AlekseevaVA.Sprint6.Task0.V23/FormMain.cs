using Tyuiu.AlekseevaVA.Sprint6.Task0.V23.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_AVA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_AVA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Пустой метод - ничего не делает
            // Можно оставить его полностью пустым
        }

        private void textBoxVarX_AVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Пустой метод - ничего не делает

        }

        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб 25-1 Алексеева Виктория Александровна", "Сообщение");
        }
    }
}

