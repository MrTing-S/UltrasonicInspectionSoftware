namespace MyChartControl.WaveChart
{
    partial class WaveChartControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelVMark4 = new System.Windows.Forms.Label();
            this.labelVMark3 = new System.Windows.Forms.Label();
            this.labelVMark2 = new System.Windows.Forms.Label();
            this.labelVMark5 = new System.Windows.Forms.Label();
            this.labelVMark1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 241);
            this.panel1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 100F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 100F;
            chartArea2.InnerPlotPosition.Width = 100F;
            chartArea2.Name = "ChartArea2";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1.1";
            series2.ChartArea = "ChartArea2";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea2";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1.2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(504, 241);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopRight;
            title1.Name = "title1";
            title2.Alignment = System.Drawing.ContentAlignment.TopRight;
            title2.Name = "title2";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            // 
            // labelVMark4
            // 
            this.labelVMark4.AutoSize = true;
            this.labelVMark4.Location = new System.Drawing.Point(313, 308);
            this.labelVMark4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVMark4.Name = "labelVMark4";
            this.labelVMark4.Size = new System.Drawing.Size(14, 13);
            this.labelVMark4.TabIndex = 4;
            this.labelVMark4.Text = "0";
            // 
            // labelVMark3
            // 
            this.labelVMark3.AutoSize = true;
            this.labelVMark3.Location = new System.Drawing.Point(203, 308);
            this.labelVMark3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVMark3.Name = "labelVMark3";
            this.labelVMark3.Size = new System.Drawing.Size(14, 13);
            this.labelVMark3.TabIndex = 5;
            this.labelVMark3.Text = "0";
            // 
            // labelVMark2
            // 
            this.labelVMark2.AutoSize = true;
            this.labelVMark2.Location = new System.Drawing.Point(117, 308);
            this.labelVMark2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVMark2.Name = "labelVMark2";
            this.labelVMark2.Size = new System.Drawing.Size(14, 13);
            this.labelVMark2.TabIndex = 6;
            this.labelVMark2.Text = "0";
            // 
            // labelVMark5
            // 
            this.labelVMark5.AutoSize = true;
            this.labelVMark5.Location = new System.Drawing.Point(382, 308);
            this.labelVMark5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVMark5.Name = "labelVMark5";
            this.labelVMark5.Size = new System.Drawing.Size(14, 13);
            this.labelVMark5.TabIndex = 8;
            this.labelVMark5.Text = "0";
            // 
            // labelVMark1
            // 
            this.labelVMark1.AutoSize = true;
            this.labelVMark1.Location = new System.Drawing.Point(41, 308);
            this.labelVMark1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVMark1.Name = "labelVMark1";
            this.labelVMark1.Size = new System.Drawing.Size(14, 13);
            this.labelVMark1.TabIndex = 7;
            this.labelVMark1.Text = "0";
            // 
            // WaveChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelVMark4);
            this.Controls.Add(this.labelVMark3);
            this.Controls.Add(this.labelVMark2);
            this.Controls.Add(this.labelVMark5);
            this.Controls.Add(this.labelVMark1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WaveChartControl";
            this.Size = new System.Drawing.Size(625, 372);
            this.SizeChanged += new System.EventHandler(this.WaveChartControl_SizeChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVMark4;
        private System.Windows.Forms.Label labelVMark3;
        private System.Windows.Forms.Label labelVMark2;
        private System.Windows.Forms.Label labelVMark5;
        private System.Windows.Forms.Label labelVMark1;
        public  System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
