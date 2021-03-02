namespace Test
{
    partial class WaveFormTest
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
            this.buttonScan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonChangeDataType = new System.Windows.Forms.Button();
            this.trackBarGageX = new System.Windows.Forms.TrackBar();
            this.trackBarGageY = new System.Windows.Forms.TrackBar();
            this.trackBarGageLength = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGageType = new System.Windows.Forms.ComboBox();
            this.waveChart = new MyChartControl.WaveChart.WaveChartControl();
            this.buttonTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageLength)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(689, 299);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(100, 40);
            this.buttonScan.TabIndex = 1;
            this.buttonScan.Text = "开始扫描";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonChangeDataType
            // 
            this.buttonChangeDataType.Location = new System.Drawing.Point(583, 299);
            this.buttonChangeDataType.Name = "buttonChangeDataType";
            this.buttonChangeDataType.Size = new System.Drawing.Size(100, 40);
            this.buttonChangeDataType.TabIndex = 1;
            this.buttonChangeDataType.Text = "改变数据类型";
            this.buttonChangeDataType.UseVisualStyleBackColor = true;
            this.buttonChangeDataType.Click += new System.EventHandler(this.buttonChangeDataType_Click);
            // 
            // trackBarGageX
            // 
            this.trackBarGageX.Location = new System.Drawing.Point(1, 290);
            this.trackBarGageX.Maximum = 100;
            this.trackBarGageX.Minimum = 1;
            this.trackBarGageX.Name = "trackBarGageX";
            this.trackBarGageX.Size = new System.Drawing.Size(104, 56);
            this.trackBarGageX.TabIndex = 2;
            this.trackBarGageX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGageX.Value = 1;
            this.trackBarGageX.Scroll += new System.EventHandler(this.trackBarGageX_Scroll);
            // 
            // trackBarGageY
            // 
            this.trackBarGageY.Location = new System.Drawing.Point(111, 290);
            this.trackBarGageY.Maximum = 100;
            this.trackBarGageY.Minimum = 1;
            this.trackBarGageY.Name = "trackBarGageY";
            this.trackBarGageY.Size = new System.Drawing.Size(104, 56);
            this.trackBarGageY.TabIndex = 2;
            this.trackBarGageY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGageY.Value = 1;
            this.trackBarGageY.Scroll += new System.EventHandler(this.trackBarGageY_Scroll);
            // 
            // trackBarGageLength
            // 
            this.trackBarGageLength.Location = new System.Drawing.Point(221, 290);
            this.trackBarGageLength.Maximum = 100;
            this.trackBarGageLength.Minimum = 1;
            this.trackBarGageLength.Name = "trackBarGageLength";
            this.trackBarGageLength.Size = new System.Drawing.Size(104, 56);
            this.trackBarGageLength.TabIndex = 2;
            this.trackBarGageLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGageLength.Value = 1;
            this.trackBarGageLength.Scroll += new System.EventHandler(this.trackBarGageLength_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "闸门X坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "闸门Y坐标";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "闸门长度";
            // 
            // comboBoxGageType
            // 
            this.comboBoxGageType.FormattingEnabled = true;
            this.comboBoxGageType.Items.AddRange(new object[] {
            "A闸门",
            "B闸门"});
            this.comboBoxGageType.Location = new System.Drawing.Point(331, 290);
            this.comboBoxGageType.Name = "comboBoxGageType";
            this.comboBoxGageType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxGageType.TabIndex = 4;
            this.comboBoxGageType.SelectedIndexChanged += new System.EventHandler(this.comboBoxGageType_SelectedIndexChanged);
            // 
            // waveChart
            // 
            this.waveChart.BackColor = System.Drawing.Color.White;
            this.waveChart.Location = new System.Drawing.Point(1, 1);
            this.waveChart.Margin = new System.Windows.Forms.Padding(2);
            this.waveChart.Name = "waveChart";
            this.waveChart.Size = new System.Drawing.Size(778, 281);
            this.waveChart.TabIndex = 0;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(477, 299);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(100, 40);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "测试";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // WaveFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 351);
            this.Controls.Add(this.comboBoxGageType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarGageLength);
            this.Controls.Add(this.trackBarGageY);
            this.Controls.Add(this.trackBarGageX);
            this.Controls.Add(this.buttonChangeDataType);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.waveChart);
            this.Name = "WaveFormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaveFormTest";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyChartControl.WaveChart.WaveChartControl waveChart;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonChangeDataType;
        private System.Windows.Forms.TrackBar trackBarGageX;
        private System.Windows.Forms.TrackBar trackBarGageY;
        private System.Windows.Forms.TrackBar trackBarGageLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGageType;
        private System.Windows.Forms.Button buttonTest;
    }
}