namespace Test
{
    partial class ScanFormTest
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonScan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonTest = new System.Windows.Forms.Button();
            this.scanChartControl = new MyChartControl.ScanChart.ScanChartControl();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(628, 401);
            this.buttonScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 32);
            this.buttonScan.TabIndex = 1;
            this.buttonScan.Text = "扫描";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(716, 402);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 32);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "测试";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // scanChartControl
            // 
            this.scanChartControl.Location = new System.Drawing.Point(9, 10);
            this.scanChartControl.Margin = new System.Windows.Forms.Padding(2);
            this.scanChartControl.Name = "scanChartControl";
            this.scanChartControl.Size = new System.Drawing.Size(703, 400);
            this.scanChartControl.TabIndex = 2;
            // 
            // ScanFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 481);
            this.Controls.Add(this.scanChartControl);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonScan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScanFormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonTest;
        private MyChartControl.ScanChart.ScanChartControl scanChartControl;
    }
}

