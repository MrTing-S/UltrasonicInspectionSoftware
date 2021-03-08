namespace HSD_EMAT_Chan4.Forms
{
    partial class MutiScanForm
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
            this.mutiScanChart = new MyChartControl.MutiScanChart.MutiScanChartControl();
            this.SuspendLayout();
            // 
            // mutiScanChart
            // 
            this.mutiScanChart.BackColor = System.Drawing.Color.Transparent;
            this.mutiScanChart.Location = new System.Drawing.Point(11, 11);
            this.mutiScanChart.Margin = new System.Windows.Forms.Padding(2);
            this.mutiScanChart.Name = "mutiScanChart";
            this.mutiScanChart.Size = new System.Drawing.Size(580, 335);
            this.mutiScanChart.TabIndex = 0;
            // 
            // MutiScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mutiScanChart);
            this.Name = "MutiScanForm";
            this.Text = "MutiScanForm";
            this.SizeChanged += new System.EventHandler(this.MutiScanForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private MyChartControl.MutiScanChart.MutiScanChartControl mutiScanChart;
    }
}