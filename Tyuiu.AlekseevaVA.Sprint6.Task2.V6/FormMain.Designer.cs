namespace Tyuiu.AlekseevaVA.Sprint6.Task2.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxY_AVA = new GroupBox();
            textBoxY_AVA = new TextBox();
            groupBoxVD_AVA = new GroupBox();
            textBoxStop_AVA = new TextBox();
            textBoxStart_AVA = new TextBox();
            textBoxSt_AVA = new TextBox();
            textBoxS_AVA = new TextBox();
            buttonDone_AVA = new Button();
            groupBoxD_AVA = new GroupBox();
            chartFunction_AVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_AVA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            textBoxResult_AVA = new TextBox();
            buttonHelp_AVA = new Button();
            groupBoxY_AVA.SuspendLayout();
            groupBoxVD_AVA.SuspendLayout();
            groupBoxD_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxY_AVA
            // 
            groupBoxY_AVA.Controls.Add(textBoxY_AVA);
            groupBoxY_AVA.Location = new Point(12, 12);
            groupBoxY_AVA.Name = "groupBoxY_AVA";
            groupBoxY_AVA.Size = new Size(555, 287);
            groupBoxY_AVA.TabIndex = 0;
            groupBoxY_AVA.TabStop = false;
            groupBoxY_AVA.Text = "Условие ";
            // 
            // textBoxY_AVA
            // 
            textBoxY_AVA.Location = new Point(6, 26);
            textBoxY_AVA.Multiline = true;
            textBoxY_AVA.Name = "textBoxY_AVA";
            textBoxY_AVA.Size = new Size(543, 255);
            textBoxY_AVA.TabIndex = 1;
            textBoxY_AVA.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxVD_AVA
            // 
            groupBoxVD_AVA.Controls.Add(textBoxStop_AVA);
            groupBoxVD_AVA.Controls.Add(textBoxStart_AVA);
            groupBoxVD_AVA.Controls.Add(textBoxSt_AVA);
            groupBoxVD_AVA.Controls.Add(textBoxS_AVA);
            groupBoxVD_AVA.Location = new Point(12, 305);
            groupBoxVD_AVA.Name = "groupBoxVD_AVA";
            groupBoxVD_AVA.Size = new Size(282, 102);
            groupBoxVD_AVA.TabIndex = 2;
            groupBoxVD_AVA.TabStop = false;
            groupBoxVD_AVA.Text = "Ввод данных";
            // 
            // textBoxStop_AVA
            // 
            textBoxStop_AVA.Location = new Point(151, 59);
            textBoxStop_AVA.Name = "textBoxStop_AVA";
            textBoxStop_AVA.Size = new Size(125, 27);
            textBoxStop_AVA.TabIndex = 3;
            textBoxStop_AVA.Text = "5";
            // 
            // textBoxStart_AVA
            // 
            textBoxStart_AVA.Location = new Point(6, 59);
            textBoxStart_AVA.Name = "textBoxStart_AVA";
            textBoxStart_AVA.Size = new Size(125, 27);
            textBoxStart_AVA.TabIndex = 2;
            textBoxStart_AVA.Text = "-5";
            // 
            // textBoxSt_AVA
            // 
            textBoxSt_AVA.BackColor = SystemColors.Control;
            textBoxSt_AVA.Location = new Point(151, 26);
            textBoxSt_AVA.Name = "textBoxSt_AVA";
            textBoxSt_AVA.Size = new Size(125, 27);
            textBoxSt_AVA.TabIndex = 1;
            textBoxSt_AVA.Text = "Конец шага:";
            // 
            // textBoxS_AVA
            // 
            textBoxS_AVA.BackColor = SystemColors.Control;
            textBoxS_AVA.Location = new Point(6, 26);
            textBoxS_AVA.Name = "textBoxS_AVA";
            textBoxS_AVA.Size = new Size(125, 27);
            textBoxS_AVA.TabIndex = 0;
            textBoxS_AVA.Text = "Старт шага:";
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.BackColor = Color.Green;
            buttonDone_AVA.Location = new Point(422, 319);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(139, 85);
            buttonDone_AVA.TabIndex = 4;
            buttonDone_AVA.Text = "Выполнить ";
            buttonDone_AVA.UseVisualStyleBackColor = false;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            buttonDone_AVA.MouseDown += buttonDone_AVA_MouseDown;
            buttonDone_AVA.MouseEnter += buttonDone_AVA_MouseEnter;
            buttonDone_AVA.MouseLeave += buttonDone_AVA_MouseLeave;
            // 
            // groupBoxD_AVA
            // 
            groupBoxD_AVA.Controls.Add(chartFunction_AVA);
            groupBoxD_AVA.Controls.Add(dataGridViewFunction_AVA);
            groupBoxD_AVA.Controls.Add(textBoxResult_AVA);
            groupBoxD_AVA.Location = new Point(573, 12);
            groupBoxD_AVA.Name = "groupBoxD_AVA";
            groupBoxD_AVA.Size = new Size(611, 392);
            groupBoxD_AVA.TabIndex = 5;
            groupBoxD_AVA.TabStop = false;
            groupBoxD_AVA.Text = "Вывод данных";
            // 
            // chartFunction_AVA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_AVA.ChartAreas.Add(chartArea1);
            chartFunction_AVA.Location = new Point(162, 26);
            chartFunction_AVA.Name = "chartFunction_AVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            chartFunction_AVA.Series.Add(series1);
            chartFunction_AVA.Size = new Size(436, 353);
            chartFunction_AVA.TabIndex = 6;
            chartFunction_AVA.Text = "chart1";
            // 
            // dataGridViewFunction_AVA
            // 
            dataGridViewFunction_AVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_AVA.Columns.AddRange(new DataGridViewColumn[] { X, Column1 });
            dataGridViewFunction_AVA.Location = new Point(3, 23);
            dataGridViewFunction_AVA.Name = "dataGridViewFunction_AVA";
            dataGridViewFunction_AVA.RowHeadersVisible = false;
            dataGridViewFunction_AVA.RowHeadersWidth = 51;
            dataGridViewFunction_AVA.Size = new Size(153, 363);
            dataGridViewFunction_AVA.TabIndex = 1;
            dataGridViewFunction_AVA.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 60;
            // 
            // Column1
            // 
            Column1.HeaderText = "F(X)";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 60;
            // 
            // textBoxResult_AVA
            // 
            textBoxResult_AVA.BackColor = SystemColors.Menu;
            textBoxResult_AVA.Location = new Point(6, 26);
            textBoxResult_AVA.Name = "textBoxResult_AVA";
            textBoxResult_AVA.Size = new Size(125, 27);
            textBoxResult_AVA.TabIndex = 0;
            textBoxResult_AVA.Text = "Результат:";
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.BackColor = SystemColors.Highlight;
            buttonHelp_AVA.Location = new Point(313, 319);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(94, 79);
            buttonHelp_AVA.TabIndex = 7;
            buttonHelp_AVA.Text = "Справка";
            buttonHelp_AVA.UseVisualStyleBackColor = false;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 416);
            Controls.Add(buttonHelp_AVA);
            Controls.Add(groupBoxD_AVA);
            Controls.Add(buttonDone_AVA);
            Controls.Add(groupBoxVD_AVA);
            Controls.Add(groupBoxY_AVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 6 | Алексеева. В.А";
            groupBoxY_AVA.ResumeLayout(false);
            groupBoxY_AVA.PerformLayout();
            groupBoxVD_AVA.ResumeLayout(false);
            groupBoxVD_AVA.PerformLayout();
            groupBoxD_AVA.ResumeLayout(false);
            groupBoxD_AVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxY_AVA;
        private TextBox textBoxY_AVA;
        private GroupBox groupBoxVD_AVA;
        private TextBox textBoxStop_AVA;
        private TextBox textBoxStart_AVA;
        private TextBox textBoxSt_AVA;
        private TextBox textBoxS_AVA;
        private Button buttonDone_AVA;
        private GroupBox groupBoxD_AVA;
        private DataGridView dataGridViewFunction_AVA;
        private TextBox textBoxResult_AVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AVA;
        private Button buttonHelp_AVA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
    }
}
