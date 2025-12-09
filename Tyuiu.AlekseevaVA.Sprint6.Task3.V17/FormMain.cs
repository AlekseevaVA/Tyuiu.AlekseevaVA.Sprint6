using Tyuiu.AlekseevaVA.Sprint6.Task3.V17.Lib;


namespace Tyuiu.AlekseevaVA.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = {
                {  22 , 32, -16 , 24 , 27 },
                {  3, -20,  24, -20,  25 },
                { 21, 17  ,-8 ,-19 , 17 },
                { 8 , 22 , 28,  27,  19 },
                { 11,  20,  12,  27,  29 }
            };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;    // количество строк
            int columns = matrix.Length / rows;        // количество столбцов
                                                       // или так  int columns = number

            dataGridViewMatrix_AVA.ColumnCount = columns;
            dataGridViewMatrix_AVA.RowCount = rows;

            // задаем ширину столбцов
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_AVA.Columns[i].Width = 40;
            }
            // заполнение таблицы значениями из матрицы
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_AVA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }


        }









        private void dataGridViewMatrix_AVA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDoneRes_AVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            // Исходная матрица
            int[,] mtrx = new int[5, 5] {
                { 22 , 32, -16 , -20 ,  27},
                {   3, -20,  24, -19,  25},
                {  21,  17  ,-8 ,24,  17},
                { 8 , 22 ,    28, 27,  19},
                {  11,  20,  12,  27,  29} };

            // Получаем отсортированную матрицу (wait)
            int[,] wait = ds.Calculate(mtrx);

            // Настраиваем DataGridView
            dataGridViewResult_AVA.ColumnCount = 5;
            dataGridViewResult_AVA.RowCount = 5;

            // Задаем ширину столбцов
            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_AVA.Columns[i].Width = 40;
            }

            // Заполняем значениями из wait матрицы
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewResult_AVA.Rows[i].Cells[j].Value = wait[i, j].ToString();
                }
            }
        }

        private void buttonDoneHelp_AVA_Click(object sender, EventArgs e)
        {
           
        
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб 25-1 Алексеева Виктория", "Сообщение");
        
        }
    }
}
