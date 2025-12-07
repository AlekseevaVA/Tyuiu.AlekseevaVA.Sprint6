namespace Tyuiu.AlekseevaVA.Sprint6.Task0.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxV_AVA = new GroupBox();
            textBoxVarX_AVA = new TextBox();
            textBoxVar_AVA = new TextBox();
            groupBoxVD_AVA = new GroupBox();
            textBoxResult_AVA = new TextBox();
            textBoxRes_AVA = new TextBox();
            buttonDone_AVA = new Button();
            groupBoxTask = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxTask = new TextBox();
            buttonHelp_AVA = new Button();
            groupBoxV_AVA.SuspendLayout();
            groupBoxVD_AVA.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // groupBoxV_AVA
            // 
            groupBoxV_AVA.Controls.Add(textBoxVarX_AVA);
            groupBoxV_AVA.Controls.Add(textBoxVar_AVA);
            groupBoxV_AVA.Location = new Point(12, 179);
            groupBoxV_AVA.Name = "groupBoxV_AVA";
            groupBoxV_AVA.Size = new Size(232, 81);
            groupBoxV_AVA.TabIndex = 0;
            groupBoxV_AVA.TabStop = false;
            groupBoxV_AVA.Text = "Ввод данных";
            // 
            // textBoxVarX_AVA
            // 
            textBoxVarX_AVA.Location = new Point(3, 48);
            textBoxVarX_AVA.Name = "textBoxVarX_AVA";
            textBoxVarX_AVA.Size = new Size(125, 27);
            textBoxVarX_AVA.TabIndex = 1;
            // 
            // textBoxVar_AVA
            // 
            textBoxVar_AVA.BackColor = SystemColors.Menu;
            textBoxVar_AVA.Location = new Point(3, 23);
            textBoxVar_AVA.Name = "textBoxVar_AVA";
            textBoxVar_AVA.Size = new Size(125, 27);
            textBoxVar_AVA.TabIndex = 0;
            textBoxVar_AVA.Text = "Переменная X:";
            // 
            // groupBoxVD_AVA
            // 
            groupBoxVD_AVA.Controls.Add(textBoxResult_AVA);
            groupBoxVD_AVA.Controls.Add(textBoxRes_AVA);
            groupBoxVD_AVA.Location = new Point(247, 179);
            groupBoxVD_AVA.Name = "groupBoxVD_AVA";
            groupBoxVD_AVA.Size = new Size(220, 81);
            groupBoxVD_AVA.TabIndex = 1;
            groupBoxVD_AVA.TabStop = false;
            groupBoxVD_AVA.Text = "Вывод данных";
            // 
            // textBoxResult_AVA
            // 
            textBoxResult_AVA.Location = new Point(3, 48);
            textBoxResult_AVA.Name = "textBoxResult_AVA";
            textBoxResult_AVA.Size = new Size(125, 27);
            textBoxResult_AVA.TabIndex = 1;
            textBoxResult_AVA.TextChanged += textBox1_TextChanged;
            // 
            // textBoxRes_AVA
            // 
            textBoxRes_AVA.BackColor = SystemColors.Menu;
            textBoxRes_AVA.Location = new Point(3, 23);
            textBoxRes_AVA.Name = "textBoxRes_AVA";
            textBoxRes_AVA.Size = new Size(125, 27);
            textBoxRes_AVA.TabIndex = 0;
            textBoxRes_AVA.Text = "Результат:";
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.Location = new Point(304, 266);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(163, 38);
            buttonDone_AVA.TabIndex = 2;
            buttonDone_AVA.Text = "Выполнить ";
            buttonDone_AVA.UseVisualStyleBackColor = true;
            buttonDone_AVA.Click += button1_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(15, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(452, 161);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(308, 26);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(138, 70);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            pictureBoxFormula.Click += pictureBox1_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(3, 23);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(299, 132);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить выражение по формуле ";
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.Location = new Point(247, 266);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(51, 38);
            buttonHelp_AVA.TabIndex = 3;
            buttonHelp_AVA.Text = "?";
            buttonHelp_AVA.UseVisualStyleBackColor = true;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 316);
            Controls.Add(buttonHelp_AVA);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonDone_AVA);
            Controls.Add(groupBoxVD_AVA);
            Controls.Add(groupBoxV_AVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 23 | Алексеева. В.А";
            groupBoxV_AVA.ResumeLayout(false);
            groupBoxV_AVA.PerformLayout();
            groupBoxVD_AVA.ResumeLayout(false);
            groupBoxVD_AVA.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxV_AVA;
        private TextBox textBoxVarX_AVA;
        private TextBox textBoxVar_AVA;
        private GroupBox groupBoxVD_AVA;
        private TextBox textBoxResult_AVA;
        private TextBox textBoxRes_AVA;
        private Button buttonDone_AVA;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private PictureBox pictureBoxFormula;
        private Button buttonHelp_AVA;
    }
}
