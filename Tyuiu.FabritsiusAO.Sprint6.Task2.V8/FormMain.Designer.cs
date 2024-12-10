namespace Tyuiu.FabritsiusAO.Sprint6.Task2.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            BInfo = new Button();
            BRun = new Button();
            TBEnd = new TextBox();
            textBox2 = new TextBox();
            TBStart = new TextBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            X = new DataGridViewTextBoxColumn();
            Func = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 332);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BInfo);
            groupBox2.Controls.Add(BRun);
            groupBox2.Controls.Add(TBEnd);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(TBStart);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(12, 338);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // BInfo
            // 
            BInfo.BackColor = Color.DodgerBlue;
            BInfo.Location = new Point(248, 70);
            BInfo.Name = "BInfo";
            BInfo.Size = new Size(110, 30);
            BInfo.TabIndex = 0;
            BInfo.Text = "Инфо";
            BInfo.UseVisualStyleBackColor = false;
            BInfo.Click += button2_Click;
            // 
            // BRun
            // 
            BRun.BackColor = Color.FromArgb(0, 192, 0);
            BRun.Location = new Point(248, 19);
            BRun.Name = "BRun";
            BRun.Size = new Size(110, 30);
            BRun.TabIndex = 1;
            BRun.Text = "Выполнить";
            BRun.UseVisualStyleBackColor = false;
            BRun.Click += button3_Click;
            // 
            // TBEnd
            // 
            TBEnd.Location = new Point(124, 71);
            TBEnd.Name = "TBEnd";
            TBEnd.PlaceholderText = "Конец";
            TBEnd.Size = new Size(118, 23);
            TBEnd.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 22);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Конец шага";
            // 
            // TBStart
            // 
            TBStart.Location = new Point(6, 71);
            TBStart.Name = "TBStart";
            TBStart.PlaceholderText = "Старт";
            TBStart.Size = new Size(112, 23);
            TBStart.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 22);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(112, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "Старт шага";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chart1);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(382, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(546, 426);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(113, 19);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(427, 401);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            title1.Name = "Title1";
            chart1.Titles.Add(title1);
            chart1.Click += chart1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, Func });
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(104, 401);
            dataGridView1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.загружено;
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Func
            // 
            Func.HeaderText = "F(x)";
            Func.Name = "Func";
            Func.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Таск 2 Фабрициус Андрей Олегович ИСТНб-24-1";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox TBEnd;
        private TextBox textBox2;
        private TextBox TBStart;
        private TextBox textBox4;
        private Button BInfo;
        private Button BRun;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Func;
    }
}
