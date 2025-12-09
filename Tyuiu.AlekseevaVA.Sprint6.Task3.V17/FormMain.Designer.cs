namespace Tyuiu.AlekseevaVA.Sprint6.Task3.V17
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
            groupBoxY_AVA = new GroupBox();
            dataGridViewMatrix_AVA = new DataGridView();
            textBox1 = new TextBox();
            groupBoxResult_AVA = new GroupBox();
            buttonDoneHelp_AVA = new Button();
            buttonDoneRes_AVA = new Button();
            dataGridViewResult_AVA = new DataGridView();
            textBoxResult_AVA = new TextBox();
            groupBoxY_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AVA).BeginInit();
            groupBoxResult_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxY_AVA
            // 
            groupBoxY_AVA.Controls.Add(dataGridViewMatrix_AVA);
            groupBoxY_AVA.Controls.Add(textBox1);
            groupBoxY_AVA.Location = new Point(0, 0);
            groupBoxY_AVA.Name = "groupBoxY_AVA";
            groupBoxY_AVA.Size = new Size(603, 334);
            groupBoxY_AVA.TabIndex = 0;
            groupBoxY_AVA.TabStop = false;
            groupBoxY_AVA.Text = "Условие";
            // 
            // dataGridViewMatrix_AVA
            // 
            dataGridViewMatrix_AVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_AVA.Location = new Point(312, 26);
            dataGridViewMatrix_AVA.Name = "dataGridViewMatrix_AVA";
            dataGridViewMatrix_AVA.RowHeadersVisible = false;
            dataGridViewMatrix_AVA.RowHeadersWidth = 51;
            dataGridViewMatrix_AVA.Size = new Size(248, 250);
            dataGridViewMatrix_AVA.TabIndex = 1;
            dataGridViewMatrix_AVA.CellContentClick += dataGridViewMatrix_AVA_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(3, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 181);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дана матрица 5 на 5\r\n22 32 -16 24 27\r\n3 -20 24 -20 25\r\n21 17 -8-19 17\r\n8 22 28 27 19\r\n11 20 12 27 29\r\nВыполнить сортировку 4 столбца по возрастанию";
            // 
            // groupBoxResult_AVA
            // 
            groupBoxResult_AVA.Controls.Add(buttonDoneHelp_AVA);
            groupBoxResult_AVA.Controls.Add(buttonDoneRes_AVA);
            groupBoxResult_AVA.Controls.Add(dataGridViewResult_AVA);
            groupBoxResult_AVA.Controls.Add(textBoxResult_AVA);
            groupBoxResult_AVA.Location = new Point(609, 12);
            groupBoxResult_AVA.Name = "groupBoxResult_AVA";
            groupBoxResult_AVA.Size = new Size(340, 353);
            groupBoxResult_AVA.TabIndex = 2;
            groupBoxResult_AVA.TabStop = false;
            groupBoxResult_AVA.Text = "Вывод данных";
            // 
            // buttonDoneHelp_AVA
            // 
            buttonDoneHelp_AVA.Location = new Point(119, 303);
            buttonDoneHelp_AVA.Name = "buttonDoneHelp_AVA";
            buttonDoneHelp_AVA.Size = new Size(55, 41);
            buttonDoneHelp_AVA.TabIndex = 4;
            buttonDoneHelp_AVA.Text = "?";
            buttonDoneHelp_AVA.UseVisualStyleBackColor = true;
            buttonDoneHelp_AVA.Click += buttonDoneHelp_AVA_Click;
            // 
            // buttonDoneRes_AVA
            // 
            buttonDoneRes_AVA.BackColor = SystemColors.HighlightText;
            buttonDoneRes_AVA.Location = new Point(180, 303);
            buttonDoneRes_AVA.Name = "buttonDoneRes_AVA";
            buttonDoneRes_AVA.Size = new Size(137, 41);
            buttonDoneRes_AVA.TabIndex = 3;
            buttonDoneRes_AVA.Text = "Выполнить ";
            buttonDoneRes_AVA.UseVisualStyleBackColor = false;
            buttonDoneRes_AVA.Click += buttonDoneRes_AVA_Click;
            // 
            // dataGridViewResult_AVA
            // 
            dataGridViewResult_AVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_AVA.Location = new Point(6, 59);
            dataGridViewResult_AVA.Name = "dataGridViewResult_AVA";
            dataGridViewResult_AVA.RowHeadersVisible = false;
            dataGridViewResult_AVA.RowHeadersWidth = 51;
            dataGridViewResult_AVA.Size = new Size(267, 226);
            dataGridViewResult_AVA.TabIndex = 2;
            dataGridViewResult_AVA.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxResult_AVA
            // 
            textBoxResult_AVA.Location = new Point(6, 26);
            textBoxResult_AVA.Name = "textBoxResult_AVA";
            textBoxResult_AVA.Size = new Size(125, 27);
            textBoxResult_AVA.TabIndex = 0;
            textBoxResult_AVA.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(961, 368);
            Controls.Add(groupBoxResult_AVA);
            Controls.Add(groupBoxY_AVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 17 | Алексеева. В.А";
            Load += FormMain_Load;
            groupBoxY_AVA.ResumeLayout(false);
            groupBoxY_AVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AVA).EndInit();
            groupBoxResult_AVA.ResumeLayout(false);
            groupBoxResult_AVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxY_AVA;
        private TextBox textBox1;
        private DataGridView dataGridViewMatrix_AVA;
        private GroupBox groupBoxResult_AVA;
        private DataGridView dataGridViewResult_AVA;
        private TextBox textBoxResult_AVA;
        private Button buttonDoneRes_AVA;
        private Button buttonDoneHelp_AVA;
    }
}
