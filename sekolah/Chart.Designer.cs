namespace sekolah
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartdate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartsiswa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartsiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // chartdate
            // 
            chartArea5.Name = "ChartArea1";
            this.chartdate.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartdate.Legends.Add(legend5);
            this.chartdate.Location = new System.Drawing.Point(432, 12);
            this.chartdate.Name = "chartdate";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Date";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chartdate.Series.Add(series5);
            this.chartdate.Size = new System.Drawing.Size(356, 409);
            this.chartdate.TabIndex = 0;
            this.chartdate.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Chart Date User";
            this.chartdate.Titles.Add(title5);
            // 
            // chartsiswa
            // 
            chartArea6.Name = "ChartArea1";
            this.chartsiswa.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartsiswa.Legends.Add(legend6);
            this.chartsiswa.Location = new System.Drawing.Point(12, 12);
            this.chartsiswa.Name = "chartsiswa";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "ScheduleID";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartsiswa.Series.Add(series6);
            this.chartsiswa.Size = new System.Drawing.Size(405, 409);
            this.chartsiswa.TabIndex = 1;
            this.chartsiswa.Text = "chart2";
            title6.Name = "Title1";
            title6.Text = "Chart Schedule User";
            this.chartsiswa.Titles.Add(title6);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(12, 450);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(140, 20);
            this.txtStudent.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Filter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // datestart
            // 
            this.datestart.Location = new System.Drawing.Point(432, 447);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(200, 20);
            this.datestart.TabIndex = 6;
            // 
            // dateend
            // 
            this.dateend.Location = new System.Drawing.Point(432, 484);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(200, 20);
            this.dateend.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(124, 505);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Default";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 540);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.datestart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartsiswa);
            this.Controls.Add(this.chartdate);
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chartdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartsiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartdate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartsiswa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Button button4;
    }
}