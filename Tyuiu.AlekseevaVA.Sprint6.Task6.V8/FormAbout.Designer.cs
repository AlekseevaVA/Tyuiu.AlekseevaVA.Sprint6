namespace Tyuiu.AlekseevaVA.Sprint6.Task6.V8
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelinfo = new Label();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelinfo
            // 
            labelinfo.AutoSize = true;
            labelinfo.Location = new Point(174, 46);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(213, 40);
            labelinfo.TabIndex = 0;
            labelinfo.Text = "Разработчик: Алексеева. В. А \r\nГруппа ИИПб 25-1";
            labelinfo.Click += labelinfo_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(396, 181);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ок";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 222);
            Controls.Add(buttonOk);
            Controls.Add(labelinfo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelinfo;
        private Button buttonOk;
    }
}