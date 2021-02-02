namespace FormTest
{
    partial class Form1
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.chartControl1 = new MyChartControl.ChartControl();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnStartCollect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFireWall = new System.Windows.Forms.Button();
            this.btnFireWallClose = new System.Windows.Forms.Button();
            this.btnCheckAdmRight = new System.Windows.Forms.Button();
            this.butStopCollect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSeverStop = new System.Windows.Forms.Button();
            this.trackBarDigitalGian = new System.Windows.Forms.TrackBar();
            this.trackBarAnalogGain = new System.Windows.Forms.TrackBar();
            this.trackBarSignFreqRatio = new System.Windows.Forms.TrackBar();
            this.数字增益 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDigitalGainValue = new System.Windows.Forms.TextBox();
            this.textBoxAnalogGainValue = new System.Windows.Forms.TextBox();
            this.textBoxSignFreqRatio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRepeatFreq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarRepeatFreq = new System.Windows.Forms.TrackBar();
            this.trackBarSendCmdDelayCount = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDelayCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPulNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBarPulNumber = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAveNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBarAveNumber = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxFixNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.trackBarFixNumber = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxHighVoltage = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.trackBarHighVoltage = new System.Windows.Forms.TrackBar();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxDigital = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.trackBarDigital = new System.Windows.Forms.TrackBar();
            this.comboBoxWaveType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.trackBarRange = new System.Windows.Forms.TrackBar();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDigitalGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnalogGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSignFreqRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRepeatFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSendCmdDelayCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPulNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAveNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHighVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDigital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRange)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Transparent;
            this.btnDraw.Location = new System.Drawing.Point(399, 250);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(73, 30);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "绘制";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(32, 24);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(440, 257);
            this.chartControl1.TabIndex = 4;
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(336, 26);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(73, 31);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(16, 26);
            this.btnInit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(73, 31);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "启动服务器";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnStartCollect
            // 
            this.btnStartCollect.Location = new System.Drawing.Point(98, 26);
            this.btnStartCollect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartCollect.Name = "btnStartCollect";
            this.btnStartCollect.Size = new System.Drawing.Size(73, 31);
            this.btnStartCollect.TabIndex = 5;
            this.btnStartCollect.Text = "开启采集";
            this.btnStartCollect.UseVisualStyleBackColor = true;
            this.btnStartCollect.Click += new System.EventHandler(this.btnStartCollect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenFireWall);
            this.groupBox1.Controls.Add(this.btnFireWallClose);
            this.groupBox1.Controls.Add(this.btnCheckAdmRight);
            this.groupBox1.Location = new System.Drawing.Point(469, 317);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(267, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网络测试";
            // 
            // btnOpenFireWall
            // 
            this.btnOpenFireWall.Location = new System.Drawing.Point(188, 26);
            this.btnOpenFireWall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFireWall.Name = "btnOpenFireWall";
            this.btnOpenFireWall.Size = new System.Drawing.Size(74, 31);
            this.btnOpenFireWall.TabIndex = 5;
            this.btnOpenFireWall.Text = "开启防火墙";
            this.btnOpenFireWall.UseVisualStyleBackColor = true;
            this.btnOpenFireWall.Click += new System.EventHandler(this.btnOpenFireWall_Click);
            // 
            // btnFireWallClose
            // 
            this.btnFireWallClose.Location = new System.Drawing.Point(110, 26);
            this.btnFireWallClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFireWallClose.Name = "btnFireWallClose";
            this.btnFireWallClose.Size = new System.Drawing.Size(74, 31);
            this.btnFireWallClose.TabIndex = 5;
            this.btnFireWallClose.Text = "关闭防火墙";
            this.btnFireWallClose.UseVisualStyleBackColor = true;
            this.btnFireWallClose.Click += new System.EventHandler(this.btnFireWallClose_Click);
            // 
            // btnCheckAdmRight
            // 
            this.btnCheckAdmRight.Location = new System.Drawing.Point(11, 26);
            this.btnCheckAdmRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckAdmRight.Name = "btnCheckAdmRight";
            this.btnCheckAdmRight.Size = new System.Drawing.Size(94, 31);
            this.btnCheckAdmRight.TabIndex = 5;
            this.btnCheckAdmRight.Text = "查询管理员权限";
            this.btnCheckAdmRight.UseVisualStyleBackColor = true;
            this.btnCheckAdmRight.Click += new System.EventHandler(this.btnCheckAdmRight_Click);
            // 
            // butStopCollect
            // 
            this.butStopCollect.Location = new System.Drawing.Point(182, 26);
            this.butStopCollect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butStopCollect.Name = "butStopCollect";
            this.butStopCollect.Size = new System.Drawing.Size(73, 31);
            this.butStopCollect.TabIndex = 7;
            this.butStopCollect.Text = "停止采集";
            this.butStopCollect.UseVisualStyleBackColor = true;
            this.butStopCollect.Click += new System.EventHandler(this.butStopCollect_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSeverStop
            // 
            this.btnSeverStop.Location = new System.Drawing.Point(259, 26);
            this.btnSeverStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeverStop.Name = "btnSeverStop";
            this.btnSeverStop.Size = new System.Drawing.Size(73, 31);
            this.btnSeverStop.TabIndex = 7;
            this.btnSeverStop.Text = "关闭服务器";
            this.btnSeverStop.UseVisualStyleBackColor = true;
            this.btnSeverStop.Click += new System.EventHandler(this.btnSeverStop_Click);
            // 
            // trackBarDigitalGian
            // 
            this.trackBarDigitalGian.Location = new System.Drawing.Point(482, 60);
            this.trackBarDigitalGian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarDigitalGian.Maximum = 400;
            this.trackBarDigitalGian.Name = "trackBarDigitalGian";
            this.trackBarDigitalGian.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarDigitalGian.Size = new System.Drawing.Size(45, 90);
            this.trackBarDigitalGian.TabIndex = 8;
            this.trackBarDigitalGian.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarDigitalGian.Scroll += new System.EventHandler(this.trackBarDigitalGian_Scroll);
            // 
            // trackBarAnalogGain
            // 
            this.trackBarAnalogGain.Location = new System.Drawing.Point(535, 60);
            this.trackBarAnalogGain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarAnalogGain.Maximum = 400;
            this.trackBarAnalogGain.Name = "trackBarAnalogGain";
            this.trackBarAnalogGain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAnalogGain.Size = new System.Drawing.Size(45, 90);
            this.trackBarAnalogGain.TabIndex = 9;
            this.trackBarAnalogGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAnalogGain.Scroll += new System.EventHandler(this.trackBarAnalogGain_Scroll);
            // 
            // trackBarSignFreqRatio
            // 
            this.trackBarSignFreqRatio.Location = new System.Drawing.Point(589, 60);
            this.trackBarSignFreqRatio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarSignFreqRatio.Maximum = 55;
            this.trackBarSignFreqRatio.Minimum = 40;
            this.trackBarSignFreqRatio.Name = "trackBarSignFreqRatio";
            this.trackBarSignFreqRatio.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSignFreqRatio.Size = new System.Drawing.Size(45, 90);
            this.trackBarSignFreqRatio.TabIndex = 10;
            this.trackBarSignFreqRatio.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSignFreqRatio.Value = 40;
            this.trackBarSignFreqRatio.Scroll += new System.EventHandler(this.trackBarSignFreqRatio_Scroll);
            // 
            // 数字增益
            // 
            this.数字增益.AutoSize = true;
            this.数字增益.Location = new System.Drawing.Point(473, 21);
            this.数字增益.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.数字增益.Name = "数字增益";
            this.数字增益.Size = new System.Drawing.Size(53, 12);
            this.数字增益.TabIndex = 16;
            this.数字增益.Text = "数字增益";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "模拟增益";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "发射频率";
            // 
            // textBoxDigitalGainValue
            // 
            this.textBoxDigitalGainValue.BackColor = System.Drawing.Color.White;
            this.textBoxDigitalGainValue.Location = new System.Drawing.Point(476, 35);
            this.textBoxDigitalGainValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDigitalGainValue.Name = "textBoxDigitalGainValue";
            this.textBoxDigitalGainValue.Size = new System.Drawing.Size(24, 21);
            this.textBoxDigitalGainValue.TabIndex = 20;
            this.textBoxDigitalGainValue.Text = "0";
            // 
            // textBoxAnalogGainValue
            // 
            this.textBoxAnalogGainValue.Location = new System.Drawing.Point(529, 35);
            this.textBoxAnalogGainValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAnalogGainValue.Name = "textBoxAnalogGainValue";
            this.textBoxAnalogGainValue.Size = new System.Drawing.Size(24, 21);
            this.textBoxAnalogGainValue.TabIndex = 21;
            this.textBoxAnalogGainValue.Text = "0";
            // 
            // textBoxSignFreqRatio
            // 
            this.textBoxSignFreqRatio.Location = new System.Drawing.Point(583, 35);
            this.textBoxSignFreqRatio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSignFreqRatio.Name = "textBoxSignFreqRatio";
            this.textBoxSignFreqRatio.Size = new System.Drawing.Size(24, 21);
            this.textBoxSignFreqRatio.TabIndex = 22;
            this.textBoxSignFreqRatio.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "db";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "db";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "MHz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "Hz";
            // 
            // textBoxRepeatFreq
            // 
            this.textBoxRepeatFreq.Location = new System.Drawing.Point(640, 35);
            this.textBoxRepeatFreq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRepeatFreq.Name = "textBoxRepeatFreq";
            this.textBoxRepeatFreq.Size = new System.Drawing.Size(24, 21);
            this.textBoxRepeatFreq.TabIndex = 28;
            this.textBoxRepeatFreq.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "重复频率";
            // 
            // trackBarRepeatFreq
            // 
            this.trackBarRepeatFreq.Location = new System.Drawing.Point(642, 60);
            this.trackBarRepeatFreq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarRepeatFreq.Maximum = 4;
            this.trackBarRepeatFreq.Name = "trackBarRepeatFreq";
            this.trackBarRepeatFreq.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRepeatFreq.Size = new System.Drawing.Size(45, 90);
            this.trackBarRepeatFreq.TabIndex = 30;
            this.trackBarRepeatFreq.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRepeatFreq.Scroll += new System.EventHandler(this.trackBarRepeatFreq_Scroll);
            // 
            // trackBarSendCmdDelayCount
            // 
            this.trackBarSendCmdDelayCount.Location = new System.Drawing.Point(693, 60);
            this.trackBarSendCmdDelayCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarSendCmdDelayCount.Maximum = 100;
            this.trackBarSendCmdDelayCount.Name = "trackBarSendCmdDelayCount";
            this.trackBarSendCmdDelayCount.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSendCmdDelayCount.Size = new System.Drawing.Size(45, 90);
            this.trackBarSendCmdDelayCount.TabIndex = 34;
            this.trackBarSendCmdDelayCount.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSendCmdDelayCount.Scroll += new System.EventHandler(this.trackBarSendCmdDelayCount_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(716, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "us";
            // 
            // textBoxDelayCount
            // 
            this.textBoxDelayCount.Location = new System.Drawing.Point(691, 35);
            this.textBoxDelayCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDelayCount.Name = "textBoxDelayCount";
            this.textBoxDelayCount.Size = new System.Drawing.Size(24, 21);
            this.textBoxDelayCount.TabIndex = 32;
            this.textBoxDelayCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "延迟计数";
            // 
            // textBoxPulNumber
            // 
            this.textBoxPulNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPulNumber.Location = new System.Drawing.Point(476, 174);
            this.textBoxPulNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPulNumber.Name = "textBoxPulNumber";
            this.textBoxPulNumber.Size = new System.Drawing.Size(24, 21);
            this.textBoxPulNumber.TabIndex = 37;
            this.textBoxPulNumber.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(473, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "脉冲个数";
            // 
            // trackBarPulNumber
            // 
            this.trackBarPulNumber.Location = new System.Drawing.Point(482, 198);
            this.trackBarPulNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarPulNumber.Maximum = 3;
            this.trackBarPulNumber.Name = "trackBarPulNumber";
            this.trackBarPulNumber.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPulNumber.Size = new System.Drawing.Size(45, 90);
            this.trackBarPulNumber.TabIndex = 35;
            this.trackBarPulNumber.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPulNumber.Scroll += new System.EventHandler(this.trackBarPulNumber_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 38;
            this.label10.Text = "个";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(553, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 42;
            this.label12.Text = "次";
            // 
            // textBoxAveNumber
            // 
            this.textBoxAveNumber.BackColor = System.Drawing.Color.White;
            this.textBoxAveNumber.Location = new System.Drawing.Point(528, 174);
            this.textBoxAveNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAveNumber.Name = "textBoxAveNumber";
            this.textBoxAveNumber.Size = new System.Drawing.Size(24, 21);
            this.textBoxAveNumber.TabIndex = 41;
            this.textBoxAveNumber.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(526, 162);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 40;
            this.label13.Text = "平均次数";
            // 
            // trackBarAveNumber
            // 
            this.trackBarAveNumber.Location = new System.Drawing.Point(534, 198);
            this.trackBarAveNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarAveNumber.Maximum = 4;
            this.trackBarAveNumber.Name = "trackBarAveNumber";
            this.trackBarAveNumber.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAveNumber.Size = new System.Drawing.Size(45, 90);
            this.trackBarAveNumber.TabIndex = 39;
            this.trackBarAveNumber.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAveNumber.Scroll += new System.EventHandler(this.trackBarAveNumber_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(608, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 46;
            this.label14.Text = "次";
            // 
            // textBoxFixNumber
            // 
            this.textBoxFixNumber.BackColor = System.Drawing.Color.White;
            this.textBoxFixNumber.Location = new System.Drawing.Point(583, 174);
            this.textBoxFixNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFixNumber.Name = "textBoxFixNumber";
            this.textBoxFixNumber.Size = new System.Drawing.Size(24, 21);
            this.textBoxFixNumber.TabIndex = 45;
            this.textBoxFixNumber.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(580, 162);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 44;
            this.label15.Text = "相关次数";
            // 
            // trackBarFixNumber
            // 
            this.trackBarFixNumber.Location = new System.Drawing.Point(589, 198);
            this.trackBarFixNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarFixNumber.Maximum = 15;
            this.trackBarFixNumber.Name = "trackBarFixNumber";
            this.trackBarFixNumber.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarFixNumber.Size = new System.Drawing.Size(45, 90);
            this.trackBarFixNumber.TabIndex = 43;
            this.trackBarFixNumber.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFixNumber.Scroll += new System.EventHandler(this.trackBarFixNumber_Scroll);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(662, 177);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 50;
            this.label16.Text = "V";
            // 
            // textBoxHighVoltage
            // 
            this.textBoxHighVoltage.BackColor = System.Drawing.Color.White;
            this.textBoxHighVoltage.Location = new System.Drawing.Point(637, 174);
            this.textBoxHighVoltage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxHighVoltage.Name = "textBoxHighVoltage";
            this.textBoxHighVoltage.Size = new System.Drawing.Size(24, 21);
            this.textBoxHighVoltage.TabIndex = 49;
            this.textBoxHighVoltage.Text = "300";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(634, 162);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 48;
            this.label17.Text = "高压调节";
            // 
            // trackBarHighVoltage
            // 
            this.trackBarHighVoltage.LargeChange = 0;
            this.trackBarHighVoltage.Location = new System.Drawing.Point(643, 198);
            this.trackBarHighVoltage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarHighVoltage.Maximum = 4;
            this.trackBarHighVoltage.Name = "trackBarHighVoltage";
            this.trackBarHighVoltage.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarHighVoltage.Size = new System.Drawing.Size(45, 90);
            this.trackBarHighVoltage.TabIndex = 47;
            this.trackBarHighVoltage.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarHighVoltage.Scroll += new System.EventHandler(this.trackBarHighVoltage_Scroll);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(712, 177);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 54;
            this.label18.Text = "%";
            // 
            // textBoxDigital
            // 
            this.textBoxDigital.BackColor = System.Drawing.Color.White;
            this.textBoxDigital.Location = new System.Drawing.Point(688, 174);
            this.textBoxDigital.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDigital.Name = "textBoxDigital";
            this.textBoxDigital.Size = new System.Drawing.Size(24, 21);
            this.textBoxDigital.TabIndex = 53;
            this.textBoxDigital.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(686, 162);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 52;
            this.label19.Text = "数字抑制";
            // 
            // trackBarDigital
            // 
            this.trackBarDigital.LargeChange = 0;
            this.trackBarDigital.Location = new System.Drawing.Point(694, 198);
            this.trackBarDigital.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarDigital.Maximum = 100;
            this.trackBarDigital.Name = "trackBarDigital";
            this.trackBarDigital.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarDigital.Size = new System.Drawing.Size(45, 90);
            this.trackBarDigital.TabIndex = 51;
            this.trackBarDigital.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarDigital.Scroll += new System.EventHandler(this.trackBarDigital_Scroll);
            // 
            // comboBoxWaveType
            // 
            this.comboBoxWaveType.FormattingEnabled = true;
            this.comboBoxWaveType.Items.AddRange(new object[] {
            "正检波",
            "负检波",
            "全检波",
            "射频波"});
            this.comboBoxWaveType.Location = new System.Drawing.Point(534, 291);
            this.comboBoxWaveType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxWaveType.Name = "comboBoxWaveType";
            this.comboBoxWaveType.Size = new System.Drawing.Size(92, 20);
            this.comboBoxWaveType.TabIndex = 56;
            this.comboBoxWaveType.Text = "射频波";
            this.comboBoxWaveType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(474, 294);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 56;
            this.label20.Text = "检波方式";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(30, 291);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 57;
            this.label21.Text = "范围：";
            // 
            // trackBarRange
            // 
            this.trackBarRange.Location = new System.Drawing.Point(110, 287);
            this.trackBarRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarRange.Maximum = 80;
            this.trackBarRange.Minimum = 10;
            this.trackBarRange.Name = "trackBarRange";
            this.trackBarRange.Size = new System.Drawing.Size(362, 45);
            this.trackBarRange.TabIndex = 58;
            this.trackBarRange.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRange.Value = 45;
            this.trackBarRange.Scroll += new System.EventHandler(this.trackBarRange_Scroll);
            // 
            // textBoxRange
            // 
            this.textBoxRange.BackColor = System.Drawing.Color.White;
            this.textBoxRange.Location = new System.Drawing.Point(64, 289);
            this.textBoxRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(24, 21);
            this.textBoxRange.TabIndex = 59;
            this.textBoxRange.Text = "45";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(91, 291);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 60;
            this.label22.Text = "mm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.btnInit);
            this.groupBox2.Controls.Add(this.btnStartCollect);
            this.groupBox2.Controls.Add(this.butStopCollect);
            this.groupBox2.Controls.Add(this.btnSeverStop);
            this.groupBox2.Location = new System.Drawing.Point(32, 317);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(432, 67);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作界面";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 408);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBoxWaveType);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxDigital);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.trackBarDigital);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxHighVoltage);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.trackBarHighVoltage);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxFixNumber);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.trackBarFixNumber);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAveNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.trackBarAveNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPulNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trackBarPulNumber);
            this.Controls.Add(this.trackBarSendCmdDelayCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDelayCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBarRepeatFreq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRepeatFreq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSignFreqRatio);
            this.Controls.Add(this.textBoxAnalogGainValue);
            this.Controls.Add(this.textBoxDigitalGainValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.数字增益);
            this.Controls.Add(this.trackBarSignFreqRatio);
            this.Controls.Add(this.trackBarAnalogGain);
            this.Controls.Add(this.trackBarDigitalGian);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.trackBarRange);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通道1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDigitalGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnalogGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSignFreqRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRepeatFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSendCmdDelayCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPulNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAveNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHighVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDigital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRange)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDraw;
        private MyChartControl.ChartControl chartControl1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnStartCollect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckAdmRight;
        private System.Windows.Forms.Button btnFireWallClose;
        private System.Windows.Forms.Button btnOpenFireWall;
        private System.Windows.Forms.Button butStopCollect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSeverStop;
        private System.Windows.Forms.TrackBar trackBarDigitalGian;
        private System.Windows.Forms.TrackBar trackBarAnalogGain;
        private System.Windows.Forms.TrackBar trackBarSignFreqRatio;
        private System.Windows.Forms.Label 数字增益;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDigitalGainValue;
        private System.Windows.Forms.TextBox textBoxAnalogGainValue;
        private System.Windows.Forms.TextBox textBoxSignFreqRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRepeatFreq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarRepeatFreq;
        private System.Windows.Forms.TrackBar trackBarSendCmdDelayCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDelayCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPulNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBarPulNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAveNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackBarAveNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxFixNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar trackBarFixNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxHighVoltage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar trackBarHighVoltage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxDigital;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar trackBarDigital;
        private System.Windows.Forms.ComboBox comboBoxWaveType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TrackBar trackBarRange;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

