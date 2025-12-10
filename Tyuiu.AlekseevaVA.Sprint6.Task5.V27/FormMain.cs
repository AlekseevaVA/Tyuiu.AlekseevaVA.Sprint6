using Tyuiu.AlekseevaVA.Sprint6.Task5.V27.Lib;

namespace Tyuiu.AlekseevaVA.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\виктория\Desktop\DataSprint5\InPutDataFileTask5V27.txt";

        private void buttonDone_AVA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_AVA.ColumnCount = 2;
            dataGridViewRes_AVA.Columns[0].Width = 20;
            dataGridViewRes_AVA.Columns[1].Width = 50;
            chart_AVA.Series[0].Points.Clear();
            double[] mass = new double[ds.len];
            mass = ds.LoadFromDataFile(path);
            for (int i = 0; i < mass.Length; i++)
            {
                dataGridViewRes_AVA.Rows.Add(Convert.ToString(i), Convert.ToString(mass[i]));
                chart_AVA.Series[0].Points.AddXY(i, mass[i]);
            }
        }

        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб 25-1 Алексеева Виктория", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_AVA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
