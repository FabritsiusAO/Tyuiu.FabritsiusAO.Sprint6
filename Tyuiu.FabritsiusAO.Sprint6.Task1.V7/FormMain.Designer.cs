namespace Tyuiu.FabritsiusAO.Sprint6.Task1.V7
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
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxOUT = new TextBox();
            textBox3 = new TextBox();
            groupBox3 = new GroupBox();
            textBoxEND = new TextBox();
            textBoxSTART = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonHelp = new Button();
            buttonRun = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 22);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(501, 292);
            textBox4.TabIndex = 3;
            textBox4.Text = "Написать программу выводящую значения функции";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxOUT);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(531, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 426);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBoxOUT
            // 
            textBoxOUT.Location = new Point(6, 51);
            textBoxOUT.Multiline = true;
            textBoxOUT.Name = "textBoxOUT";
            textBoxOUT.Size = new Size(245, 366);
            textBoxOUT.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Результат";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxEND);
            groupBox3.Controls.Add(textBoxSTART);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(12, 338);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // textBoxEND
            // 
            textBoxEND.Location = new Point(123, 51);
            textBoxEND.Name = "textBoxEND";
            textBoxEND.Size = new Size(100, 23);
            textBoxEND.TabIndex = 4;
            textBoxEND.TextChanged += textBoxEND_TextChanged;
            // 
            // textBoxSTART
            // 
            textBoxSTART.Location = new Point(6, 51);
            textBoxSTART.Name = "textBoxSTART";
            textBoxSTART.Size = new Size(100, 23);
            textBoxSTART.TabIndex = 5;
            textBoxSTART.TextChanged += textBoxSTART_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Конец шага";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Старт шага";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(256, 348);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(62, 81);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(324, 348);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(201, 81);
            buttonRun.TabIndex = 2;
            buttonRun.Text = "Выполнить";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRun);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private TextBox textBoxOUT;
        private TextBox textBox3;
        private GroupBox groupBox3;
        private TextBox textBoxEND;
        private TextBox textBoxSTART;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonHelp;
        private Button buttonRun;
    }
}
