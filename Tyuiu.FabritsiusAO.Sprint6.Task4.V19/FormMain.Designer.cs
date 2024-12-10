namespace Tyuiu.FabritsiusAO.Sprint6.Task4.V19
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
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            TBRes = new TextBox();
            groupBox3 = new GroupBox();
            TBEnd = new TextBox();
            textBox3 = new TextBox();
            TBStart = new TextBox();
            textBox5 = new TextBox();
            BRun = new Button();
            BSave = new Button();
            BInfo = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(412, 68);
            textBox1.TabIndex = 1;
            textBox1.Text = "Протабулировать функцию на диапазоне";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TBRes);
            groupBox2.Location = new Point(18, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 412);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // TBRes
            // 
            TBRes.Location = new Point(3, 19);
            TBRes.Multiline = true;
            TBRes.Name = "TBRes";
            TBRes.ReadOnly = true;
            TBRes.Size = new Size(261, 387);
            TBRes.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TBEnd);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(TBStart);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Location = new Point(442, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(283, 90);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод";
            // 
            // TBEnd
            // 
            TBEnd.Location = new Point(158, 51);
            TBEnd.Name = "TBEnd";
            TBEnd.Size = new Size(119, 23);
            TBEnd.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 22);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(119, 23);
            textBox3.TabIndex = 7;
            textBox3.Text = "Конец шага";
            // 
            // TBStart
            // 
            TBStart.Location = new Point(5, 51);
            TBStart.Name = "TBStart";
            TBStart.Size = new Size(119, 23);
            TBStart.TabIndex = 8;
            TBStart.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(5, 22);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(119, 23);
            textBox5.TabIndex = 9;
            textBox5.Text = "Старт шага";
            // 
            // BRun
            // 
            BRun.Location = new Point(731, 24);
            BRun.Name = "BRun";
            BRun.Size = new Size(95, 66);
            BRun.TabIndex = 3;
            BRun.Text = "Run";
            BRun.UseVisualStyleBackColor = true;
            BRun.Click += BRun_Click;
            // 
            // BSave
            // 
            BSave.Location = new Point(832, 24);
            BSave.Name = "BSave";
            BSave.Size = new Size(95, 66);
            BSave.TabIndex = 4;
            BSave.Text = "Save";
            BSave.UseVisualStyleBackColor = true;
            BSave.Click += BSave_Click;
            // 
            // BInfo
            // 
            BInfo.Location = new Point(933, 24);
            BInfo.Name = "BInfo";
            BInfo.Size = new Size(34, 66);
            BInfo.TabIndex = 5;
            BInfo.Text = "?";
            BInfo.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(294, 114);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(673, 412);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chart1.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 538);
            Controls.Add(chart1);
            Controls.Add(BInfo);
            Controls.Add(BSave);
            Controls.Add(BRun);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт6 | Таск4 | Вариант 19 | Фабрициус А. О.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private TextBox TBEnd;
        private TextBox textBox3;
        private TextBox TBStart;
        private TextBox textBox5;
        private Button BRun;
        private Button BSave;
        private Button BInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox TBRes;
    }
}
