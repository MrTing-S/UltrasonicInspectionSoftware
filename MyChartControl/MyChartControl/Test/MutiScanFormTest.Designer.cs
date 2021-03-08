namespace Test
{
    partial class MutiScanFormTest
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
            this.components = new System.ComponentModel.Container();
            this.mutiWaveChart = new MyChartControl.MutiScanChart.MutiScanChartControl();
            this.buttonTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // mutiWaveChart
            // 
            this.mutiWaveChart.BackColor = System.Drawing.Color.White;
            this.mutiWaveChart.Location = new System.Drawing.Point(1, 15);
            this.mutiWaveChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mutiWaveChart.Name = "mutiWaveChart";
            this.mutiWaveChart.Size = new System.Drawing.Size(582, 346);
            this.mutiWaveChart.TabIndex = 0;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(514, 398);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 32);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "测试";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MutiScanFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 459);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.mutiWaveChart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MutiScanFormTest";
            this.Text = "MutiScanFormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private MyChartControl.MutiScanChart.MutiScanChartControl mutiWaveChart;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Timer timer1;
    }
}