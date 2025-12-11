using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShabalinaYP.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            string[] fileData = File.ReadAllText(path).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);
            int rows = fileData.Length;
            int columns = fileData[0].Split(';').Length;
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line = fileData[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 6] % 5 == 0)
                {
                        matrix[i, 6] = 2;
                    
                }
            }
            return matrix;
        }
        public int[,] GetStartMatrix(string path)
        {
            string[] fileData = File.ReadAllText(path).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);

            int rows = fileData.Length;
            int columns = fileData[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = fileData[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return arrayValues;
        }
    }
}
