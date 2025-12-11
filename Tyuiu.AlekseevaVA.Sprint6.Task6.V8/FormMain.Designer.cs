namespace Tyuiu.AlekseevaVA.Sprint6.Task6.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp_AVA = new Button();
            buttonDone_AVA = new Button();
            buttonOpenFile_AVA = new Button();
            panel2 = new Panel();
            groupBoxY_AVA = new GroupBox();
            textBoxY_AVA = new TextBox();
            panel3 = new Panel();
            groupBoxFile_AVA = new GroupBox();
            textBoxFile_AVA = new TextBox();
            panel4 = new Panel();
            groupBoxRes_AVA = new GroupBox();
            textBoxRes_AVA = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxY_AVA.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxFile_AVA.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxRes_AVA.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_AVA);
            panel1.Controls.Add(buttonDone_AVA);
            panel1.Controls.Add(buttonOpenFile_AVA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 79);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.Image = (Image)resources.GetObject("buttonHelp_AVA.Image");
            buttonHelp_AVA.Location = new Point(913, 12);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(94, 61);
            buttonHelp_AVA.TabIndex = 2;
            buttonHelp_AVA.UseVisualStyleBackColor = true;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.Enabled = false;
            buttonDone_AVA.FlatStyle = FlatStyle.Flat;
            buttonDone_AVA.Image = (Image)resources.GetObject("buttonDone_AVA.Image");
            buttonDone_AVA.Location = new Point(122, 12);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(94, 61);
            buttonDone_AVA.TabIndex = 1;
            toolTip1.SetToolTip(buttonDone_AVA, "Выводит слова в которых встречается z");
            buttonDone_AVA.UseVisualStyleBackColor = true;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            // 
            // buttonOpenFile_AVA
            // 
            buttonOpenFile_AVA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_AVA.Image = (Image)resources.GetObject("buttonOpenFile_AVA.Image");
            buttonOpenFile_AVA.Location = new Point(12, 12);
            buttonOpenFile_AVA.Name = "buttonOpenFile_AVA";
            buttonOpenFile_AVA.Size = new Size(94, 61);
            buttonOpenFile_AVA.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpenFile_AVA, "Открыть файл \r\nВыберите нужный файл для обработки");
            buttonOpenFile_AVA.UseVisualStyleBackColor = true;
            buttonOpenFile_AVA.Click += buttonOpenFile_AVA_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxY_AVA);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 93);
            panel2.TabIndex = 1;
            // 
            // groupBoxY_AVA
            // 
            groupBoxY_AVA.Controls.Add(textBoxY_AVA);
            groupBoxY_AVA.Location = new Point(3, 6);
            groupBoxY_AVA.Name = "groupBoxY_AVA";
            groupBoxY_AVA.Size = new Size(1004, 81);
            groupBoxY_AVA.TabIndex = 0;
            groupBoxY_AVA.TabStop = false;
            groupBoxY_AVA.Text = "Условие";
            // 
            // textBoxY_AVA
            // 
            textBoxY_AVA.Location = new Point(6, 22);
            textBoxY_AVA.Multiline = true;
            textBoxY_AVA.Name = "textBoxY_AVA";
            textBoxY_AVA.Size = new Size(970, 53);
            textBoxY_AVA.TabIndex = 0;
            textBoxY_AVA.Text = resources.GetString("textBoxY_AVA.Text");
            textBoxY_AVA.TextChanged += textBoxY_AVA_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(groupBoxFile_AVA);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 307);
            panel3.TabIndex = 2;
            // 
            // groupBoxFile_AVA
            // 
            groupBoxFile_AVA.Controls.Add(textBoxFile_AVA);
            groupBoxFile_AVA.Location = new Point(3, 6);
            groupBoxFile_AVA.Name = "groupBoxFile_AVA";
            groupBoxFile_AVA.Size = new Size(445, 289);
            groupBoxFile_AVA.TabIndex = 0;
            groupBoxFile_AVA.TabStop = false;
            groupBoxFile_AVA.Text = "Ввод";
            // 
            // textBoxFile_AVA
            // 
            textBoxFile_AVA.Location = new Point(6, 26);
            textBoxFile_AVA.Multiline = true;
            textBoxFile_AVA.Name = "textBoxFile_AVA";
            textBoxFile_AVA.ScrollBars = ScrollBars.Vertical;
            textBoxFile_AVA.Size = new Size(433, 257);
            textBoxFile_AVA.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxRes_AVA);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(451, 172);
            panel4.Name = "panel4";
            panel4.Size = new Size(568, 307);
            panel4.TabIndex = 3;
            // 
            // groupBoxRes_AVA
            // 
            groupBoxRes_AVA.Controls.Add(textBoxRes_AVA);
            groupBoxRes_AVA.Location = new Point(6, 6);
            groupBoxRes_AVA.Name = "groupBoxRes_AVA";
            groupBoxRes_AVA.Size = new Size(550, 289);
            groupBoxRes_AVA.TabIndex = 0;
            groupBoxRes_AVA.TabStop = false;
            groupBoxRes_AVA.Text = "Вывод";
            // 
            // textBoxRes_AVA
            // 
            textBoxRes_AVA.Location = new Point(0, 26);
            textBoxRes_AVA.Multiline = true;
            textBoxRes_AVA.Name = "textBoxRes_AVA";
            textBoxRes_AVA.ScrollBars = ScrollBars.Vertical;
            textBoxRes_AVA.Size = new Size(544, 257);
            textBoxRes_AVA.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 479);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 8 | Алексеева. В.А";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxY_AVA.ResumeLayout(false);
            groupBoxY_AVA.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxFile_AVA.ResumeLayout(false);
            groupBoxFile_AVA.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxRes_AVA.ResumeLayout(false);
            groupBoxRes_AVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonDone_AVA;
        private Button buttonOpenFile_AVA;
        private Panel panel2;
        private GroupBox groupBoxY_AVA;
        private TextBox textBoxY_AVA;
        private Panel panel3;
        private GroupBox groupBoxFile_AVA;
        private TextBox textBoxFile_AVA;
        private Panel panel4;
        private GroupBox groupBoxRes_AVA;
        private TextBox textBoxRes_AVA;
        private Button buttonHelp_AVA;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
    }
}
