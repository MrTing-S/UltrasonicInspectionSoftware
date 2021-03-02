namespace HSD_EMAT_Chan4.Forms
{
    partial class WaveForm
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
            this.waveChart = new MyChartControl.WaveChart.WaveChartControl();
            this.ScanChart = new MyChartControl.WaveChart.WaveChartControl();
            this.SuspendLayout();
            // 
            // waveChart
            // 
            this.waveChart.BackColor = System.Drawing.Color.White;
            this.waveChart.Location = new System.Drawing.Point(12, 245);
            this.waveChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waveChart.Name = "waveChart";
            this.waveChart.Size = new System.Drawing.Size(776, 194);
            this.waveChart.TabIndex = 0;
            // 
            // ScanChart
            // 
            this.ScanChart.BackColor = System.Drawing.Color.White;
            this.ScanChart.Location = new System.Drawing.Point(12, 21);
            this.ScanChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScanChart.Name = "ScanChart";
            this.ScanChart.Size = new System.Drawing.Size(776, 194);
            this.ScanChart.TabIndex = 0;
            // 
            // WaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScanChart);
            this.Controls.Add(this.waveChart);
            this.Name = "WaveForm";
            this.Text = "WaveForm";
            this.ResumeLayout(false);

        }

        public  MyChartControl.WaveChart.WaveChartControl waveChart;

        #endregion

        public MyChartControl.WaveChart.WaveChartControl ScanChart;
    }
}