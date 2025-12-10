using System.Windows.Forms;
using Tyuiu.AlekseevaVA.Sprint6.Task6.V8.Lib;
using static System.Windows.Forms.DataFormats;

namespace Tyuiu.AlekseevaVA.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {

        string openFilePath = @"C:\Users\виктория\Desktop\DataSprint5\InPutDataFileTask6V8.txt";
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_AVA_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxFile_AVA.Text = File.ReadAllText(openFilePath);

            buttonDone_AVA.Enabled = true;
        }

        private void textBoxY_AVA_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonDone_AVA_Click(object sender, EventArgs e)

        {
            string str = "";
            textBoxRes_AVA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
