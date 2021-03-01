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
            this.chartControl1 = new MyChartControl.WaveChart.WaveChartControl();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(-3, 1);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(535, 264);
            this.chartControl1.TabIndex = 0;
            // 
            // WaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartControl1);
            this.Name = "WaveForm";
            this.Text = "WaveForm";
            this.ResumeLayout(false);

        }

        #endregion

        public MyChartControl.WaveChart.WaveChartControl chartControl1;
    }
}