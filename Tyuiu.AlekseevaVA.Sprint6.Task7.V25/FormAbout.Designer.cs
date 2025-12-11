namespace Tyuiu.ShabalinaYP.Sprint6.Task7.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_SYP = new PictureBox();
            buttonOK_SYP = new Button();
            labelInfo_SYP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SYP).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_SYP
            // 
            pictureBoxAvatar_SYP.Image = (Image)resources.GetObject("pictureBoxAvatar_SYP.Image");
            pictureBoxAvatar_SYP.Location = new Point(33, 33);
            pictureBoxAvatar_SYP.Name = "pictureBoxAvatar_SYP";
            pictureBoxAvatar_SYP.Size = new Size(178, 253);
            pictureBoxAvatar_SYP.TabIndex = 4;
            pictureBoxAvatar_SYP.TabStop = false;
            // 
            // buttonOK_SYP
            // 
            buttonOK_SYP.FlatStyle = FlatStyle.System;
            buttonOK_SYP.Location = new Point(481, 279);
            buttonOK_SYP.Name = "buttonOK_SYP";
            buttonOK_SYP.Size = new Size(75, 23);
            buttonOK_SYP.TabIndex = 3;
            buttonOK_SYP.Text = "Ок";
            buttonOK_SYP.UseVisualStyleBackColor = true;
            buttonOK_SYP.Click += buttonOK_SYP_Click;
            // 
            // labelInfo_SYP
            // 
            labelInfo_SYP.AutoSize = true;
            labelInfo_SYP.Location = new Point(239, 72);
            labelInfo_SYP.Name = "labelInfo_SYP";
            labelInfo_SYP.Size = new Size(303, 135);
            labelInfo_SYP.TabIndex = 5;
            labelInfo_SYP.Text = resources.GetString("labelInfo_SYP.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 314);
            Controls.Add(labelInfo_SYP);
            Controls.Add(pictureBoxAvatar_SYP);
            Controls.Add(buttonOK_SYP);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SYP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxAvatar_SYP;
        private Button buttonOK_SYP;
        private Label labelInfo_SYP;
    }
}