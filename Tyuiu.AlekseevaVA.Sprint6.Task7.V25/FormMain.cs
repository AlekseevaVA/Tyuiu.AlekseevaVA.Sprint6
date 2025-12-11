using Tyuiu.AlekseevaVA.Sprint6.Task7.V25.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SYP.Filter = "Значения, разделённые запятым(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SYP.Filter = "Значения, разделённые запятым(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_SYP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SYP.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_SYP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SYP.ToolTipTitle = "Выполнить";
        }
        private void buttonSaveFile_SYP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SYP.ToolTipTitle = "Сохранить файл";
        }
        private void buttonHelpInfo_SYP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SYP.ToolTipTitle = "Справка";
        }
        private void buttonHelpInfo_SYP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonDone_SYP_Click(Object sender, EventArgs e)
        {
            int[,] values = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_SYP.Rows[i].Cells[j].Value = values[i, j];
                }
            }
            buttonSaveFile_SYP.Enabled = true;
        }

        private void buttonOpenFile(object sender, EventArgs e)
        {
            openFileDialogTask_SYP.ShowDialog();
            openFilePath = openFileDialogTask_SYP.FileName;
            if (openFilePath != null)
            {
                int[,] arrayValues = ds.GetStartMatrix(openFilePath);

                rows = arrayValues.GetLength(0);
                columns = arrayValues.GetLength(1);

                dataGridViewInPut_SYP.ColumnCount = columns;
                dataGridViewInPut_SYP.RowCount = rows;
                dataGridViewOutPut_SYP.ColumnCount = columns;
                dataGridViewOutPut_SYP.RowCount = rows;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInPut_SYP.Columns[i].Width = 25;
                    dataGridViewOutPut_SYP.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInPut_SYP.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
            }
            buttonDone_SYP.Enabled = true;
        }
        private void FormMain_SYP(object sender, EventArgs e)
        {
            dataGridViewInPut_SYP.ColumnCount = 50;
            dataGridViewOutPut_SYP.ColumnCount = 50;
            dataGridViewInPut_SYP.RowCount = 50;    
            dataGridViewOutPut_SYP.RowCount = 50;
            panelForInputData_SYP.Width = this.Width/2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_SYP.Columns[i].Width = 25;
                dataGridViewOutPut_SYP.Columns[i].Width = 25;
            }
        }
        private void buttonSaveFile_SYP_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SYP.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SYP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SYP.ShowDialog();

            string path = saveFileDialogMatrix_SYP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }
            string str = "";
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutPut_SYP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut_SYP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
