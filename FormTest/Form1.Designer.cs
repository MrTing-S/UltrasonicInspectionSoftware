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
            this.btnDraw = new System.Windows.Forms.Button();
            this.chartControl1 = new MyChartControl.ChartControl();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnChnnelConfig = new System.Windows.Forms.Button();
            this.btnGlobalConfig = new System.Windows.Forms.Button();
            this.btnStartCollect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFireWall = new System.Windows.Forms.Button();
            this.btnFireWallClose = new System.Windows.Forms.Button();
            this.btnCheckAdmRight = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(691, 105);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(97, 38);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(42, 30);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(580, 252);
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
            this.btnTest.Location = new System.Drawing.Point(691, 176);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(97, 39);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(42, 318);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(97, 39);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnChnnelConfig
            // 
            this.btnChnnelConfig.Location = new System.Drawing.Point(161, 318);
            this.btnChnnelConfig.Name = "btnChnnelConfig";
            this.btnChnnelConfig.Size = new System.Drawing.Size(97, 39);
            this.btnChnnelConfig.TabIndex = 5;
            this.btnChnnelConfig.Text = "通道数据";
            this.btnChnnelConfig.UseVisualStyleBackColor = true;
            this.btnChnnelConfig.Click += new System.EventHandler(this.btnChnnelConfig_Click);
            // 
            // btnGlobalConfig
            // 
            this.btnGlobalConfig.Location = new System.Drawing.Point(280, 318);
            this.btnGlobalConfig.Name = "btnGlobalConfig";
            this.btnGlobalConfig.Size = new System.Drawing.Size(97, 39);
            this.btnGlobalConfig.TabIndex = 5;
            this.btnGlobalConfig.Text = "全局数据";
            this.btnGlobalConfig.UseVisualStyleBackColor = true;
            this.btnGlobalConfig.Click += new System.EventHandler(this.btnGlobalConfig_Click);
            // 
            // btnStartCollect
            // 
            this.btnStartCollect.Location = new System.Drawing.Point(399, 318);
            this.btnStartCollect.Name = "btnStartCollect";
            this.btnStartCollect.Size = new System.Drawing.Size(97, 39);
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
            this.groupBox1.Location = new System.Drawing.Point(42, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网络测试";
            // 
            // btnOpenFireWall
            // 
            this.btnOpenFireWall.Location = new System.Drawing.Point(250, 44);
            this.btnOpenFireWall.Name = "btnOpenFireWall";
            this.btnOpenFireWall.Size = new System.Drawing.Size(98, 39);
            this.btnOpenFireWall.TabIndex = 5;
            this.btnOpenFireWall.Text = "开启防火墙";
            this.btnOpenFireWall.UseVisualStyleBackColor = true;
            this.btnOpenFireWall.Click += new System.EventHandler(this.btnOpenFireWall_Click);
            // 
            // btnFireWallClose
            // 
            this.btnFireWallClose.Location = new System.Drawing.Point(146, 44);
            this.btnFireWallClose.Name = "btnFireWallClose";
            this.btnFireWallClose.Size = new System.Drawing.Size(98, 39);
            this.btnFireWallClose.TabIndex = 5;
            this.btnFireWallClose.Text = "关闭防火墙";
            this.btnFireWallClose.UseVisualStyleBackColor = true;
            this.btnFireWallClose.Click += new System.EventHandler(this.btnFireWallClose_Click);
            // 
            // btnCheckAdmRight
            // 
            this.btnCheckAdmRight.Location = new System.Drawing.Point(15, 44);
            this.btnCheckAdmRight.Name = "btnCheckAdmRight";
            this.btnCheckAdmRight.Size = new System.Drawing.Size(125, 39);
            this.btnCheckAdmRight.TabIndex = 5;
            this.btnCheckAdmRight.Text = "查询管理员权限";
            this.btnCheckAdmRight.UseVisualStyleBackColor = true;
            this.btnCheckAdmRight.Click += new System.EventHandler(this.btnCheckAdmRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartCollect);
            this.Controls.Add(this.btnGlobalConfig);
            this.Controls.Add(this.btnChnnelConfig);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDraw;
        private MyChartControl.ChartControl chartControl1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnChnnelConfig;
        private System.Windows.Forms.Button btnGlobalConfig;
        private System.Windows.Forms.Button btnStartCollect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckAdmRight;
        private System.Windows.Forms.Button btnFireWallClose;
        private System.Windows.Forms.Button btnOpenFireWall;
    }
}

