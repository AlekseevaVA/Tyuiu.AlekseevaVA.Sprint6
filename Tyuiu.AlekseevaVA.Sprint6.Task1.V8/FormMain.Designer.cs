namespace Tyuiu.AlekseevaVA.Sprint6.Task1.V8
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
            groupBoxTask = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            textBoxRes = new TextBox();
            groupBoxVar = new GroupBox();
            textBoxEnd_AVA = new TextBox();
            textBoxStart_AVA = new TextBox();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            buttonDone_AVA = new Button();
            buttonHelp_AVA = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBoxVar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBox1);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(472, 269);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 95);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.Location = new Point(3, 23);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(426, 240);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Controls.Add(textBoxRes);
            groupBoxResult.Location = new Point(478, 0);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(325, 373);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных ";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(19, 50);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(300, 311);
            textBoxResult.TabIndex = 1;
            // 
            // textBoxRes
            // 
            textBoxRes.BackColor = SystemColors.Control;
            textBoxRes.Location = new Point(19, 23);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(300, 27);
            textBoxRes.TabIndex = 0;
            textBoxRes.Text = "Результат:";
            // 
            // groupBoxVar
            // 
            groupBoxVar.Controls.Add(textBoxEnd_AVA);
            groupBoxVar.Controls.Add(textBoxStart_AVA);
            groupBoxVar.Controls.Add(textBoxEnd);
            groupBoxVar.Controls.Add(textBoxStart);
            groupBoxVar.Location = new Point(6, 269);
            groupBoxVar.Name = "groupBoxVar";
            groupBoxVar.Size = new Size(244, 113);
            groupBoxVar.TabIndex = 3;
            groupBoxVar.TabStop = false;
            groupBoxVar.Text = "Ввод данных";
            // 
            // textBoxEnd_AVA
            // 
            textBoxEnd_AVA.Location = new Point(120, 62);
            textBoxEnd_AVA.Name = "textBoxEnd_AVA";
            textBoxEnd_AVA.Size = new Size(125, 27);
            textBoxEnd_AVA.TabIndex = 5;
            textBoxEnd_AVA.Text = "5";
            // 
            // textBoxStart_AVA
            // 
            textBoxStart_AVA.Location = new Point(3, 62);
            textBoxStart_AVA.Name = "textBoxStart_AVA";
            textBoxStart_AVA.Size = new Size(113, 27);
            textBoxStart_AVA.TabIndex = 4;
            textBoxStart_AVA.Text = "-5";
            // 
            // textBoxEnd
            // 
            textBoxEnd.BackColor = SystemColors.Control;
            textBoxEnd.Location = new Point(120, 23);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(132, 27);
            textBoxEnd.TabIndex = 1;
            textBoxEnd.Text = "Конец шага:";
            textBoxEnd.TextChanged += textBoxEnd_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.BackColor = SystemColors.Control;
            textBoxStart.Location = new Point(0, 23);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(116, 27);
            textBoxStart.TabIndex = 0;
            textBoxStart.Text = "Старт шага:";
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.BackColor = Color.Green;
            buttonDone_AVA.Location = new Point(357, 292);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(115, 72);
            buttonDone_AVA.TabIndex = 2;
            buttonDone_AVA.Text = "Выполнить";
            buttonDone_AVA.UseVisualStyleBackColor = false;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_AVA.Location = new Point(256, 292);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(94, 69);
            buttonHelp_AVA.TabIndex = 4;
            buttonHelp_AVA.Text = "Справка";
            buttonHelp_AVA.UseVisualStyleBackColor = false;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 385);
            Controls.Add(buttonHelp_AVA);
            Controls.Add(buttonDone_AVA);
            Controls.Add(groupBoxVar);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 8 | Алексеева. В.А";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxVar.ResumeLayout(false);
            groupBoxVar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private TextBox textBoxRes;
        private GroupBox groupBox1;
        private GroupBox groupBoxVar;
        private TextBox textBoxStart_AVA;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private TextBox textBoxEnd_AVA;
        private Button buttonDone_AVA;
        private Button buttonHelp_AVA;
    }
}
