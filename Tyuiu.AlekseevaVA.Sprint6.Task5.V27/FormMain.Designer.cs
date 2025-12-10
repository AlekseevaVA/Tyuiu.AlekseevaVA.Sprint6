namespace Tyuiu.AlekseevaVA.Sprint6.Task5.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            groupBoxY_AVA = new GroupBox();
            buttonHelp_AVA = new Button();
            buttonOpen_AVA = new Button();
            buttonDone_AVA = new Button();
            textBoxY_AVA = new TextBox();
            panel2 = new Panel();
            groupBoxVD_AVA = new GroupBox();
            dataGridViewRes_AVA = new DataGridView();
            panel3 = new Panel();
            chart_AVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBoxY_AVA.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxVD_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_AVA).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_AVA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxY_AVA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 105);
            panel1.TabIndex = 0;
            // 
            // groupBoxY_AVA
            // 
            groupBoxY_AVA.Controls.Add(buttonHelp_AVA);
            groupBoxY_AVA.Controls.Add(buttonOpen_AVA);
            groupBoxY_AVA.Controls.Add(buttonDone_AVA);
            groupBoxY_AVA.Controls.Add(textBoxY_AVA);
            groupBoxY_AVA.Location = new Point(3, 3);
            groupBoxY_AVA.Name = "groupBoxY_AVA";
            groupBoxY_AVA.Size = new Size(1007, 101);
            groupBoxY_AVA.TabIndex = 0;
            groupBoxY_AVA.TabStop = false;
            groupBoxY_AVA.Text = "Условие";
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.BackColor = Color.Green;
            buttonHelp_AVA.Location = new Point(880, 23);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(109, 72);
            buttonHelp_AVA.TabIndex = 3;
            buttonHelp_AVA.Text = "Справка";
            buttonHelp_AVA.UseVisualStyleBackColor = false;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // buttonOpen_AVA
            // 
            buttonOpen_AVA.BackColor = SystemColors.Highlight;
            buttonOpen_AVA.Location = new Point(764, 26);
            buttonOpen_AVA.Name = "buttonOpen_AVA";
            buttonOpen_AVA.Size = new Size(94, 69);
            buttonOpen_AVA.TabIndex = 2;
            buttonOpen_AVA.Text = "Открыть файл";
            buttonOpen_AVA.UseVisualStyleBackColor = false;
            buttonOpen_AVA.Click += buttonOpen_AVA_Click;
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.BackColor = Color.RosyBrown;
            buttonDone_AVA.Location = new Point(644, 26);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(101, 69);
            buttonDone_AVA.TabIndex = 1;
            buttonDone_AVA.Text = "Выполнить";
            buttonDone_AVA.UseVisualStyleBackColor = false;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            // 
            // textBoxY_AVA
            // 
            textBoxY_AVA.Location = new Point(6, 23);
            textBoxY_AVA.Multiline = true;
            textBoxY_AVA.Name = "textBoxY_AVA";
            textBoxY_AVA.Size = new Size(598, 72);
            textBoxY_AVA.TabIndex = 0;
            textBoxY_AVA.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView. Вывести все числа не кратные 5. Построить диаграмму по этим значениям.";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxVD_AVA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 378);
            panel2.TabIndex = 1;
            // 
            // groupBoxVD_AVA
            // 
            groupBoxVD_AVA.Controls.Add(dataGridViewRes_AVA);
            groupBoxVD_AVA.Location = new Point(3, 6);
            groupBoxVD_AVA.Name = "groupBoxVD_AVA";
            groupBoxVD_AVA.Size = new Size(241, 360);
            groupBoxVD_AVA.TabIndex = 0;
            groupBoxVD_AVA.TabStop = false;
            groupBoxVD_AVA.Text = "Вывод данных";
            // 
            // dataGridViewRes_AVA
            // 
            dataGridViewRes_AVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_AVA.Location = new Point(3, 23);
            dataGridViewRes_AVA.Name = "dataGridViewRes_AVA";
            dataGridViewRes_AVA.RowHeadersVisible = false;
            dataGridViewRes_AVA.RowHeadersWidth = 51;
            dataGridViewRes_AVA.Size = new Size(224, 331);
            dataGridViewRes_AVA.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(chart_AVA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(772, 378);
            panel3.TabIndex = 2;
            // 
            // chart_AVA
            // 
            chartArea2.Name = "ChartArea1";
            chart_AVA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_AVA.Legends.Add(legend2);
            chart_AVA.Location = new Point(17, 0);
            chart_AVA.Name = "chart_AVA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_AVA.Series.Add(series2);
            chart_AVA.Size = new Size(743, 375);
            chart_AVA.TabIndex = 0;
            chart_AVA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 483);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 27 | Алексеева. В.А";
            panel1.ResumeLayout(false);
            groupBoxY_AVA.ResumeLayout(false);
            groupBoxY_AVA.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxVD_AVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_AVA).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_AVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBoxY_AVA;
        private Button buttonHelp_AVA;
        private Button buttonOpen_AVA;
        private Button buttonDone_AVA;
        private TextBox textBoxY_AVA;
        private GroupBox groupBoxVD_AVA;
        private DataGridView dataGridViewRes_AVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_AVA;
    }
}
