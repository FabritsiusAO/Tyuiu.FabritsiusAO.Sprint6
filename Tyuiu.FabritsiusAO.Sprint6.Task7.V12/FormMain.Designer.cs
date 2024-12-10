namespace Tyuiu.FabritsiusAO.Sprint6.Task7.V12
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
            BOpen = new Button();
            BRun = new Button();
            BSave = new Button();
            BInfo = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            DGV_IN = new DataGridView();
            groupBox3 = new GroupBox();
            DGV_OUT = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_IN).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_OUT).BeginInit();
            SuspendLayout();
            // 
            // BOpen
            // 
            BOpen.Location = new Point(12, 12);
            BOpen.Name = "BOpen";
            BOpen.Size = new Size(84, 67);
            BOpen.TabIndex = 0;
            BOpen.Text = "Open File";
            BOpen.UseVisualStyleBackColor = true;
            BOpen.Click += BOpen_Click;
            // 
            // BRun
            // 
            BRun.Enabled = false;
            BRun.Location = new Point(102, 12);
            BRun.Name = "BRun";
            BRun.Size = new Size(84, 67);
            BRun.TabIndex = 1;
            BRun.Text = "Run";
            BRun.UseVisualStyleBackColor = true;
            // 
            // BSave
            // 
            BSave.Enabled = false;
            BSave.Location = new Point(192, 12);
            BSave.Name = "BSave";
            BSave.Size = new Size(84, 67);
            BSave.TabIndex = 2;
            BSave.Text = "Save";
            BSave.UseVisualStyleBackColor = true;
            // 
            // BInfo
            // 
            BInfo.Location = new Point(742, 12);
            BInfo.Name = "BInfo";
            BInfo.Size = new Size(84, 67);
            BInfo.TabIndex = 3;
            BInfo.Text = "Info";
            BInfo.UseVisualStyleBackColor = true;
            BInfo.Click += BInfo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 74);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(802, 46);
            textBox1.TabIndex = 7;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DGV_IN);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 278);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // DGV_IN
            // 
            DGV_IN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_IN.Location = new Point(6, 19);
            DGV_IN.Name = "DGV_IN";
            DGV_IN.Size = new Size(363, 253);
            DGV_IN.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DGV_OUT);
            groupBox3.Location = new Point(445, 165);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(375, 278);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // DGV_OUT
            // 
            DGV_OUT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_OUT.Location = new Point(6, 19);
            DGV_OUT.Name = "DGV_OUT";
            DGV_OUT.Size = new Size(363, 253);
            DGV_OUT.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 455);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BInfo);
            Controls.Add(BSave);
            Controls.Add(BRun);
            Controls.Add(BOpen);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 12 | Фабрициус А. О.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_IN).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_OUT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BOpen;
        private Button BRun;
        private Button BSave;
        private Button BInfo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView DGV_IN;
        private GroupBox groupBox3;
        private DataGridView DGV_OUT;
        private TextBox textBox1;
    }
}
