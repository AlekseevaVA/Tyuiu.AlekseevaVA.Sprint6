namespace Tyuiu.AlekseevaVA.Sprint6.Task4.V7
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxY_AVA = new GroupBox();
            textBoxY_AVA = new TextBox();
            groupBoxVD_AVA = new GroupBox();
            textBoxV2D_AVA = new TextBox();
            textBoxVD_AVA = new TextBox();
            textBoxD_AVA = new TextBox();
            textBoxV_AVA = new TextBox();
            textBoxResult_AVA = new TextBox();
            chartFunction_AVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            buttonDone_AVA = new Button();
            buttonSave_AVA = new Button();
            buttonHelp_AVA = new Button();
            panel2 = new Panel();
            groupBox_Res_AVA = new GroupBox();
            splitter1 = new Splitter();
            panel3 = new Panel();
            groupBoxY_AVA.SuspendLayout();
            groupBoxVD_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AVA).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox_Res_AVA.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxY_AVA
            // 
            groupBoxY_AVA.Controls.Add(textBoxY_AVA);
            groupBoxY_AVA.Location = new Point(3, 4);
            groupBoxY_AVA.Name = "groupBoxY_AVA";
            groupBoxY_AVA.Size = new Size(566, 103);
            groupBoxY_AVA.TabIndex = 0;
            groupBoxY_AVA.TabStop = false;
            groupBoxY_AVA.Text = "Условие";
            // 
            // textBoxY_AVA
            // 
            textBoxY_AVA.Location = new Point(3, 23);
            textBoxY_AVA.Multiline = true;
            textBoxY_AVA.Name = "textBoxY_AVA";
            textBoxY_AVA.Size = new Size(557, 72);
            textBoxY_AVA.TabIndex = 0;
            textBoxY_AVA.Text = "Прогнозировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask.txt по нажатию кнопки.";
            // 
            // groupBoxVD_AVA
            // 
            groupBoxVD_AVA.Controls.Add(textBoxV2D_AVA);
            groupBoxVD_AVA.Controls.Add(textBoxVD_AVA);
            groupBoxVD_AVA.Controls.Add(textBoxD_AVA);
            groupBoxVD_AVA.Controls.Add(textBoxV_AVA);
            groupBoxVD_AVA.Location = new Point(575, 1);
            groupBoxVD_AVA.Name = "groupBoxVD_AVA";
            groupBoxVD_AVA.Size = new Size(279, 103);
            groupBoxVD_AVA.TabIndex = 1;
            groupBoxVD_AVA.TabStop = false;
            groupBoxVD_AVA.Text = "Ввод данных";
            // 
            // textBoxV2D_AVA
            // 
            textBoxV2D_AVA.Location = new Point(147, 56);
            textBoxV2D_AVA.Name = "textBoxV2D_AVA";
            textBoxV2D_AVA.Size = new Size(125, 27);
            textBoxV2D_AVA.TabIndex = 3;
            textBoxV2D_AVA.Text = "5";
            textBoxV2D_AVA.TextChanged += textBox2_TextChanged;
            // 
            // textBoxVD_AVA
            // 
            textBoxVD_AVA.Location = new Point(6, 56);
            textBoxVD_AVA.Name = "textBoxVD_AVA";
            textBoxVD_AVA.Size = new Size(125, 27);
            textBoxVD_AVA.TabIndex = 2;
            textBoxVD_AVA.Text = "-5";
            // 
            // textBoxD_AVA
            // 
            textBoxD_AVA.BackColor = SystemColors.Menu;
            textBoxD_AVA.Location = new Point(147, 23);
            textBoxD_AVA.Name = "textBoxD_AVA";
            textBoxD_AVA.Size = new Size(125, 27);
            textBoxD_AVA.TabIndex = 1;
            textBoxD_AVA.Text = "Конец шага:";
            // 
            // textBoxV_AVA
            // 
            textBoxV_AVA.BackColor = SystemColors.Menu;
            textBoxV_AVA.Location = new Point(6, 23);
            textBoxV_AVA.Name = "textBoxV_AVA";
            textBoxV_AVA.Size = new Size(125, 27);
            textBoxV_AVA.TabIndex = 0;
            textBoxV_AVA.Text = "Старт шага:";
            // 
            // textBoxResult_AVA
            // 
            textBoxResult_AVA.BackColor = SystemColors.HighlightText;
            textBoxResult_AVA.Location = new Point(3, 18);
            textBoxResult_AVA.Multiline = true;
            textBoxResult_AVA.Name = "textBoxResult_AVA";
            textBoxResult_AVA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_AVA.Size = new Size(383, 383);
            textBoxResult_AVA.TabIndex = 4;
            // 
            // chartFunction_AVA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_AVA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_AVA.Legends.Add(legend1);
            chartFunction_AVA.Location = new Point(6, 3);
            chartFunction_AVA.Name = "chartFunction_AVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_AVA.Series.Add(series1);
            chartFunction_AVA.Size = new Size(924, 401);
            chartFunction_AVA.TabIndex = 5;
            chartFunction_AVA.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции F(x)";
            chartFunction_AVA.Titles.Add(title1);
            chartFunction_AVA.Click += chartFunction_AVA_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDone_AVA);
            panel1.Controls.Add(buttonSave_AVA);
            panel1.Controls.Add(buttonHelp_AVA);
            panel1.Controls.Add(groupBoxY_AVA);
            panel1.Controls.Add(groupBoxVD_AVA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1347, 107);
            panel1.TabIndex = 6;
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.BackColor = Color.LightGreen;
            buttonDone_AVA.Location = new Point(904, 24);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(135, 71);
            buttonDone_AVA.TabIndex = 4;
            buttonDone_AVA.Text = "Выполнить";
            buttonDone_AVA.UseVisualStyleBackColor = false;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            // 
            // buttonSave_AVA
            // 
            buttonSave_AVA.BackColor = Color.PeachPuff;
            buttonSave_AVA.Location = new Point(1060, 24);
            buttonSave_AVA.Name = "buttonSave_AVA";
            buttonSave_AVA.Size = new Size(139, 71);
            buttonSave_AVA.TabIndex = 3;
            buttonSave_AVA.Text = "Сохранить";
            buttonSave_AVA.UseVisualStyleBackColor = false;
            buttonSave_AVA.Click += buttonSave_AVA_Click;
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AVA.BackColor = Color.SkyBlue;
            buttonHelp_AVA.Location = new Point(1218, 24);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(117, 71);
            buttonHelp_AVA.TabIndex = 2;
            buttonHelp_AVA.Text = "Справка";
            buttonHelp_AVA.UseVisualStyleBackColor = false;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox_Res_AVA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 407);
            panel2.TabIndex = 7;
            // 
            // groupBox_Res_AVA
            // 
            groupBox_Res_AVA.Controls.Add(textBoxResult_AVA);
            groupBox_Res_AVA.Location = new Point(3, 6);
            groupBox_Res_AVA.Name = "groupBox_Res_AVA";
            groupBox_Res_AVA.Size = new Size(392, 398);
            groupBox_Res_AVA.TabIndex = 5;
            groupBox_Res_AVA.TabStop = false;
            groupBox_Res_AVA.Text = "Результат";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(401, 107);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 407);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(chartFunction_AVA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(405, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 407);
            panel3.TabIndex = 9;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 514);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1365, 561);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 7 | Алексеева. В.А";
            Load += FormMain_Load;
            groupBoxY_AVA.ResumeLayout(false);
            groupBoxY_AVA.PerformLayout();
            groupBoxVD_AVA.ResumeLayout(false);
            groupBoxVD_AVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AVA).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox_Res_AVA.ResumeLayout(false);
            groupBox_Res_AVA.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxY_AVA;
        private TextBox textBoxY_AVA;
        private GroupBox groupBoxVD_AVA;
        private TextBox textBoxD_AVA;
        private TextBox textBoxV_AVA;
        private TextBox textBoxV2D_AVA;
        private TextBox textBoxVD_AVA;
        private TextBox textBoxResult_AVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AVA;
        private Panel panel1;
        private Button buttonHelp_AVA;
        private Panel panel2;
        private GroupBox groupBox_Res_AVA;
        private Splitter splitter1;
        private Panel panel3;
        private Button buttonDone_AVA;
        private Button buttonSave_AVA;
    }
}
