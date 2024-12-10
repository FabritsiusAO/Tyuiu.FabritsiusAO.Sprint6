namespace Tyuiu.FabritsiusAO.Sprint6.Task3.V4
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            BInfo = new Button();
            BRun = new Button();
            TBOut = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 438);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TBOut);
            groupBox2.Controls.Add(BRun);
            groupBox2.Controls.Add(BInfo);
            groupBox2.Location = new Point(545, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(243, 426);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результат";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(299, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 426);
            dataGridView1.TabIndex = 0;
            // 
            // BInfo
            // 
            BInfo.Location = new Point(131, 397);
            BInfo.Name = "BInfo";
            BInfo.Size = new Size(25, 23);
            BInfo.TabIndex = 0;
            BInfo.Text = "?";
            BInfo.UseVisualStyleBackColor = true;
            BInfo.Click += BInfo_Click;
            // 
            // BRun
            // 
            BRun.Location = new Point(162, 397);
            BRun.Name = "BRun";
            BRun.Size = new Size(75, 23);
            BRun.TabIndex = 1;
            BRun.Text = "Run";
            BRun.UseVisualStyleBackColor = true;
            BRun.Click += BRun_Click;
            // 
            // TBOut
            // 
            TBOut.Location = new Point(6, 22);
            TBOut.Name = "TBOut";
            TBOut.ReadOnly = true;
            TBOut.Size = new Size(127, 23);
            TBOut.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 410);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 4 | Фабрициус А. О.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox TBOut;
        private Button BRun;
        private Button BInfo;
    }
}
