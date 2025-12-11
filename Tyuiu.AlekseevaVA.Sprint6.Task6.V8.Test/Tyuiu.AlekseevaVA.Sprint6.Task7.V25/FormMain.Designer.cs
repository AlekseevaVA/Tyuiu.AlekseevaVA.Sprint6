namespace Tyuiu.ShabalinaYP.Sprint6.Task7.V25
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelforButtons_SYP = new Panel();
            buttonHelpInfo_SYP = new Button();
            buttonSaveFile_SYP = new Button();
            buttonDone_SYP = new Button();
            buttonOpenFile_SYP = new Button();
            panelTask_SYP = new Panel();
            groupBoxTask_SYP = new GroupBox();
            textBoxTask_SYP = new TextBox();
            panelForInputData_SYP = new Panel();
            groupBoxInPut_SYP = new GroupBox();
            dataGridViewInPut_SYP = new DataGridView();
            panelforOutPutData_SYP = new Panel();
            groupBoxOutPut_SYP = new GroupBox();
            dataGridViewOutPut_SYP = new DataGridView();
            toolTipButton_SYP = new ToolTip(components);
            openFileDialogTask_SYP = new OpenFileDialog();
            saveFileDialogMatrix_SYP = new SaveFileDialog();
            splitterLeftRight_SYP = new Splitter();
            panelforButtons_SYP.SuspendLayout();
            panelTask_SYP.SuspendLayout();
            groupBoxTask_SYP.SuspendLayout();
            panelForInputData_SYP.SuspendLayout();
            groupBoxInPut_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_SYP).BeginInit();
            panelforOutPutData_SYP.SuspendLayout();
            groupBoxOutPut_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_SYP).BeginInit();
            SuspendLayout();
            // 
            // panelforButtons_SYP
            // 
            panelforButtons_SYP.Controls.Add(buttonHelpInfo_SYP);
            panelforButtons_SYP.Controls.Add(buttonSaveFile_SYP);
            panelforButtons_SYP.Controls.Add(buttonDone_SYP);
            panelforButtons_SYP.Controls.Add(buttonOpenFile_SYP);
            panelforButtons_SYP.Dock = DockStyle.Top;
            panelforButtons_SYP.Location = new Point(0, 0);
            panelforButtons_SYP.Name = "panelforButtons_SYP";
            panelforButtons_SYP.Size = new Size(800, 68);
            panelforButtons_SYP.TabIndex = 0;
            // 
            // buttonHelpInfo_SYP
            // 
            buttonHelpInfo_SYP.Dock = DockStyle.Right;
            buttonHelpInfo_SYP.FlatAppearance.BorderColor = Color.Silver;
            buttonHelpInfo_SYP.FlatStyle = FlatStyle.Flat;
            buttonHelpInfo_SYP.Image = (Image)resources.GetObject("buttonHelpInfo_SYP.Image");
            buttonHelpInfo_SYP.Location = new Point(733, 0);
            buttonHelpInfo_SYP.Name = "buttonHelpInfo_SYP";
            buttonHelpInfo_SYP.Size = new Size(67, 68);
            buttonHelpInfo_SYP.TabIndex = 3;
            toolTipButton_SYP.SetToolTip(buttonHelpInfo_SYP, "Откройте для ознакомления");
            buttonHelpInfo_SYP.UseVisualStyleBackColor = true;
            buttonHelpInfo_SYP.Click += buttonHelpInfo_SYP_Click;
            buttonHelpInfo_SYP.MouseEnter += buttonHelpInfo_SYP_MouseEnter;
            // 
            // buttonSaveFile_SYP
            // 
            buttonSaveFile_SYP.Enabled = false;
            buttonSaveFile_SYP.FlatAppearance.BorderColor = Color.Silver;
            buttonSaveFile_SYP.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_SYP.Image = (Image)resources.GetObject("buttonSaveFile_SYP.Image");
            buttonSaveFile_SYP.Location = new Point(158, 6);
            buttonSaveFile_SYP.Name = "buttonSaveFile_SYP";
            buttonSaveFile_SYP.Size = new Size(67, 56);
            buttonSaveFile_SYP.TabIndex = 2;
            toolTipButton_SYP.SetToolTip(buttonSaveFile_SYP, "Нажмите для сохранения файла");
            buttonSaveFile_SYP.UseVisualStyleBackColor = true;
            buttonSaveFile_SYP.Click += buttonSaveFile_SYP_Click;
            buttonSaveFile_SYP.MouseEnter += buttonSaveFile_SYP_MouseEnter;
            // 
            // buttonDone_SYP
            // 
            buttonDone_SYP.Enabled = false;
            buttonDone_SYP.FlatAppearance.BorderColor = Color.Silver;
            buttonDone_SYP.FlatStyle = FlatStyle.Flat;
            buttonDone_SYP.Image = (Image)resources.GetObject("buttonDone_SYP.Image");
            buttonDone_SYP.Location = new Point(85, 6);
            buttonDone_SYP.Name = "buttonDone_SYP";
            buttonDone_SYP.Size = new Size(67, 56);
            buttonDone_SYP.TabIndex = 1;
            toolTipButton_SYP.SetToolTip(buttonDone_SYP, "Выполнить обработку данных");
            buttonDone_SYP.UseVisualStyleBackColor = true;
            buttonDone_SYP.Click += buttonDone_SYP_Click;
            buttonDone_SYP.MouseEnter += buttonDone_SYP_MouseEnter;
            // 
            // buttonOpenFile_SYP
            // 
            buttonOpenFile_SYP.FlatAppearance.BorderColor = Color.Silver;
            buttonOpenFile_SYP.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_SYP.Image = (Image)resources.GetObject("buttonOpenFile_SYP.Image");
            buttonOpenFile_SYP.Location = new Point(12, 6);
            buttonOpenFile_SYP.Name = "buttonOpenFile_SYP";
            buttonOpenFile_SYP.Size = new Size(67, 56);
            buttonOpenFile_SYP.TabIndex = 0;
            toolTipButton_SYP.SetToolTip(buttonOpenFile_SYP, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_SYP.UseVisualStyleBackColor = true;
            buttonOpenFile_SYP.Click += buttonOpenFile;
            buttonOpenFile_SYP.MouseEnter += buttonOpenFile_SYP_MouseEnter;
            // 
            // panelTask_SYP
            // 
            panelTask_SYP.Controls.Add(groupBoxTask_SYP);
            panelTask_SYP.Dock = DockStyle.Top;
            panelTask_SYP.Location = new Point(0, 68);
            panelTask_SYP.Name = "panelTask_SYP";
            panelTask_SYP.Size = new Size(800, 83);
            panelTask_SYP.TabIndex = 1;
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(textBoxTask_SYP);
            groupBoxTask_SYP.Dock = DockStyle.Fill;
            groupBoxTask_SYP.Location = new Point(0, 0);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(800, 83);
            groupBoxTask_SYP.TabIndex = 0;
            groupBoxTask_SYP.TabStop = false;
            groupBoxTask_SYP.Text = "Условие";
            // 
            // textBoxTask_SYP
            // 
            textBoxTask_SYP.BackColor = SystemColors.ButtonFace;
            textBoxTask_SYP.BorderStyle = BorderStyle.None;
            textBoxTask_SYP.Dock = DockStyle.Fill;
            textBoxTask_SYP.Location = new Point(3, 19);
            textBoxTask_SYP.Multiline = true;
            textBoxTask_SYP.Name = "textBoxTask_SYP";
            textBoxTask_SYP.Size = new Size(794, 61);
            textBoxTask_SYP.TabIndex = 0;
            textBoxTask_SYP.Text = resources.GetString("textBoxTask_SYP.Text");
            // 
            // panelForInputData_SYP
            // 
            panelForInputData_SYP.BackColor = SystemColors.ButtonFace;
            panelForInputData_SYP.Controls.Add(groupBoxInPut_SYP);
            panelForInputData_SYP.Dock = DockStyle.Left;
            panelForInputData_SYP.ForeColor = SystemColors.Control;
            panelForInputData_SYP.Location = new Point(0, 151);
            panelForInputData_SYP.Name = "panelForInputData_SYP";
            panelForInputData_SYP.Size = new Size(368, 299);
            panelForInputData_SYP.TabIndex = 2;
            // 
            // groupBoxInPut_SYP
            // 
            groupBoxInPut_SYP.Controls.Add(dataGridViewInPut_SYP);
            groupBoxInPut_SYP.Dock = DockStyle.Fill;
            groupBoxInPut_SYP.Location = new Point(0, 0);
            groupBoxInPut_SYP.Name = "groupBoxInPut_SYP";
            groupBoxInPut_SYP.Size = new Size(368, 299);
            groupBoxInPut_SYP.TabIndex = 1;
            groupBoxInPut_SYP.TabStop = false;
            groupBoxInPut_SYP.Text = "Ввод";
            // 
            // dataGridViewInPut_SYP
            // 
            dataGridViewInPut_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_SYP.ColumnHeadersVisible = false;
            dataGridViewInPut_SYP.Dock = DockStyle.Fill;
            dataGridViewInPut_SYP.Location = new Point(3, 19);
            dataGridViewInPut_SYP.Name = "dataGridViewInPut_SYP";
            dataGridViewInPut_SYP.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewInPut_SYP.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewInPut_SYP.Size = new Size(362, 277);
            dataGridViewInPut_SYP.TabIndex = 1;
            dataGridViewInPut_SYP.Click += buttonOpenFile;
            // 
            // panelforOutPutData_SYP
            // 
            panelforOutPutData_SYP.BackColor = SystemColors.ButtonFace;
            panelforOutPutData_SYP.Controls.Add(groupBoxOutPut_SYP);
            panelforOutPutData_SYP.Dock = DockStyle.Fill;
            panelforOutPutData_SYP.Location = new Point(368, 151);
            panelforOutPutData_SYP.Name = "panelforOutPutData_SYP";
            panelforOutPutData_SYP.Size = new Size(432, 299);
            panelforOutPutData_SYP.TabIndex = 5;
            // 
            // groupBoxOutPut_SYP
            // 
            groupBoxOutPut_SYP.Controls.Add(dataGridViewOutPut_SYP);
            groupBoxOutPut_SYP.Dock = DockStyle.Fill;
            groupBoxOutPut_SYP.Location = new Point(0, 0);
            groupBoxOutPut_SYP.Name = "groupBoxOutPut_SYP";
            groupBoxOutPut_SYP.Size = new Size(432, 299);
            groupBoxOutPut_SYP.TabIndex = 0;
            groupBoxOutPut_SYP.TabStop = false;
            groupBoxOutPut_SYP.Text = "Вывод";
            // 
            // dataGridViewOutPut_SYP
            // 
            dataGridViewOutPut_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_SYP.ColumnHeadersVisible = false;
            dataGridViewOutPut_SYP.Dock = DockStyle.Fill;
            dataGridViewOutPut_SYP.Location = new Point(3, 19);
            dataGridViewOutPut_SYP.Name = "dataGridViewOutPut_SYP";
            dataGridViewOutPut_SYP.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewOutPut_SYP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewOutPut_SYP.Size = new Size(426, 277);
            dataGridViewOutPut_SYP.TabIndex = 0;
            // 
            // toolTipButton_SYP
            // 
            toolTipButton_SYP.IsBalloon = true;
            toolTipButton_SYP.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_SYP.ToolTipTitle = "Выполнить";
            // 
            // openFileDialogTask_SYP
            // 
            openFileDialogTask_SYP.FileName = "openFileDialog1";
            // 
            // splitterLeftRight_SYP
            // 
            splitterLeftRight_SYP.Location = new Point(368, 151);
            splitterLeftRight_SYP.Name = "splitterLeftRight_SYP";
            splitterLeftRight_SYP.Size = new Size(3, 299);
            splitterLeftRight_SYP.TabIndex = 6;
            splitterLeftRight_SYP.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitterLeftRight_SYP);
            Controls.Add(panelforOutPutData_SYP);
            Controls.Add(panelForInputData_SYP);
            Controls.Add(panelTask_SYP);
            Controls.Add(panelforButtons_SYP);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Алексеева В. А.";
            WindowState = FormWindowState.Maximized;
            Activated += FormMain_SYP;
            panelforButtons_SYP.ResumeLayout(false);
            panelTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            panelForInputData_SYP.ResumeLayout(false);
            groupBoxInPut_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_SYP).EndInit();
            panelforOutPutData_SYP.ResumeLayout(false);
            groupBoxOutPut_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_SYP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelforButtons_SYP;
        private Panel panelTask_SYP;
        private Panel panelForInputData_SYP;
        private Panel panelforOutPutData_SYP;
        private Button buttonHelpInfo_SYP;
        private Button buttonSaveFile_SYP;
        private Button buttonDone_SYP;
        private Button buttonOpenFile_SYP;
        private GroupBox groupBoxTask_SYP;
        private TextBox textBoxTask_SYP;
        private GroupBox groupBoxInPut_SYP;
        private GroupBox groupBoxOutPut_SYP;
        private DataGridView dataGridViewOutPut_SYP;
        private ToolTip toolTipButton_SYP;
        private OpenFileDialog openFileDialogTask_SYP;
        private SaveFileDialog saveFileDialogMatrix_SYP;
        private DataGridView dataGridViewInPut_SYP;
        private Splitter splitterLeftRight_SYP;
    }
}
