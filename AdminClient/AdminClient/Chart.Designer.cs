
namespace AdminClient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labTitle = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxQuestionOne = new System.Windows.Forms.ComboBox();
            this.cbxQuestionTwo = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.cbxQuestionTake = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(885, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(133, 37);
            this.labTitle.TabIndex = 24;
            this.labTitle.Text = "圖表分析";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 110);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(937, 541);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // cbxQuestionOne
            // 
            this.cbxQuestionOne.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxQuestionOne.FormattingEnabled = true;
            this.cbxQuestionOne.Location = new System.Drawing.Point(96, 60);
            this.cbxQuestionOne.Name = "cbxQuestionOne";
            this.cbxQuestionOne.Size = new System.Drawing.Size(285, 28);
            this.cbxQuestionOne.TabIndex = 26;
            this.cbxQuestionOne.Text = "請選擇分析項目...";
            this.cbxQuestionOne.SelectedIndexChanged += new System.EventHandler(this.cbxQuestionOne_SelectedIndexChanged);
            this.cbxQuestionOne.Click += new System.EventHandler(this.cbxQuestionOne_Click);
            // 
            // cbxQuestionTwo
            // 
            this.cbxQuestionTwo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxQuestionTwo.FormattingEnabled = true;
            this.cbxQuestionTwo.Location = new System.Drawing.Point(1061, 60);
            this.cbxQuestionTwo.Name = "cbxQuestionTwo";
            this.cbxQuestionTwo.Size = new System.Drawing.Size(273, 28);
            this.cbxQuestionTwo.TabIndex = 28;
            this.cbxQuestionTwo.Text = "請選擇分析項目...";
            this.cbxQuestionTwo.Click += new System.EventHandler(this.cbxQuestionTwo_Click);
            // 
            // chart2
            // 
            chartArea2.AxisX.Title = "月";
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(955, 110);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(937, 541);
            this.chart2.TabIndex = 27;
            this.chart2.Text = "chart2";
            // 
            // btnShowChart
            // 
            this.btnShowChart.Enabled = false;
            this.btnShowChart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowChart.Location = new System.Drawing.Point(619, 60);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(95, 28);
            this.btnShowChart.TabIndex = 29;
            this.btnShowChart.Text = "分析";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // cbxQuestionTake
            // 
            this.cbxQuestionTake.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxQuestionTake.FormattingEnabled = true;
            this.cbxQuestionTake.Location = new System.Drawing.Point(422, 60);
            this.cbxQuestionTake.Name = "cbxQuestionTake";
            this.cbxQuestionTake.Size = new System.Drawing.Size(118, 28);
            this.cbxQuestionTake.TabIndex = 30;
            this.cbxQuestionTake.Text = "請選擇數目...";
            this.cbxQuestionTake.Click += new System.EventHandler(this.cbxQuestionTake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(387, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(546, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "個商品";
            // 
            // btnShowLine
            // 
            this.btnShowLine.Enabled = false;
            this.btnShowLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowLine.Location = new System.Drawing.Point(1353, 59);
            this.btnShowLine.Name = "btnShowLine";
            this.btnShowLine.Size = new System.Drawing.Size(95, 28);
            this.btnShowLine.TabIndex = 33;
            this.btnShowLine.Text = "分析";
            this.btnShowLine.UseVisualStyleBackColor = true;
            this.btnShowLine.Click += new System.EventHandler(this.btmShowLine_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::AdminClient.Properties.Resources.vector_grunge_stained_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1888, 702);
            this.Controls.Add(this.btnShowLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxQuestionTake);
            this.Controls.Add(this.btnShowChart);
            this.Controls.Add(this.cbxQuestionTwo);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.cbxQuestionOne);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbxQuestionOne;
        private System.Windows.Forms.ComboBox cbxQuestionTwo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.ComboBox cbxQuestionTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowLine;
    }
}