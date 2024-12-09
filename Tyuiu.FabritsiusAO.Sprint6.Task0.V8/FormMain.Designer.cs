namespace Tyuiu.FabritsiusAO.Sprint6.Task0.V8
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            textBoxImput = new TextBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            textBoxOutput = new TextBox();
            buttonInfo = new Button();
            buttonRun = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(536, 199);
            textBox1.TabIndex = 5;
            textBox1.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой.\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 199);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBoxImput);
            groupBox2.Location = new Point(12, 245);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(499, 127);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Location = new Point(6, 28);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            textBox5.Text = "Переменная X";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBoxImput
            // 
            textBoxImput.Location = new Point(6, 57);
            textBoxImput.Name = "textBoxImput";
            textBoxImput.Size = new Size(487, 23);
            textBoxImput.TabIndex = 6;
            textBoxImput.TextChanged += textBox3_TextChanged;
            textBoxImput.KeyPress += textBoxImput_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBoxOutput);
            groupBox3.Location = new Point(517, 245);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(271, 127);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(6, 28);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "Результат";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(6, 57);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(259, 23);
            textBoxOutput.TabIndex = 7;
            textBoxOutput.TextChanged += textBoxOutput_TextChanged;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(472, 378);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(62, 60);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += button1_Click;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(540, 378);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(248, 60);
            buttonRun.TabIndex = 3;
            buttonRun.Text = "Выполнить";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRun);
            Controls.Add(buttonInfo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonInfo;
        private Button buttonRun;
        private TextBox textBoxImput;
        private TextBox textBoxOutput;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
    }
}
