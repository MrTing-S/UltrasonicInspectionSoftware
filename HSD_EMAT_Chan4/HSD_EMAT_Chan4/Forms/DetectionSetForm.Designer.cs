namespace HSD_EMAT_Chan4.Forms
{
    partial class DetectionSetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSensorLeaveDelayTime = new System.Windows.Forms.TextBox();
            this.labelSenorLeaveDelayTimeUnit = new System.Windows.Forms.Label();
            this.labelSenorEnterDelayTimeUnit = new System.Windows.Forms.Label();
            this.textBoxSensorEnterDelayTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelThicUnit = new System.Windows.Forms.Label();
            this.textBoxthick = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelThickLimitUnit = new System.Windows.Forms.Label();
            this.textBoxthickLimit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1OuterDefectLimit = new System.Windows.Forms.Label();
            this.textBoxOuterDefectLimit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelUnitInnerDefectLimit = new System.Windows.Forms.Label();
            this.textBoxInnerDefectLimit = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtWorkpieceSpec = new System.Windows.Forms.TextBox();
            this.txtWorkpieceKind = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblWorkpieceSpec = new System.Windows.Forms.Label();
            this.lblWorkpieceKind = new System.Windows.Forms.Label();
            this.lblWorkpieceClass = new System.Windows.Forms.Label();
            this.txtWorkpieceClass = new System.Windows.Forms.TextBox();
            this.txtCheckTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkListNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckStandard = new System.Windows.Forms.TextBox();
            this.txtWorkpieceNo = new System.Windows.Forms.TextBox();
            this.txtWorkpieceStatus = new System.Windows.Forms.TextBox();
            this.txtFurnaceNo = new System.Windows.Forms.TextBox();
            this.lblFurnaceNo = new System.Windows.Forms.Label();
            this.lblWorkpieceStatus = new System.Windows.Forms.Label();
            this.lblWorkpieceNo = new System.Windows.Forms.Label();
            this.lblCheckStandard = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPipeLengthUnit = new System.Windows.Forms.Label();
            this.textBoxPipeLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDiameterUnit = new System.Windows.Forms.Label();
            this.textBoxDiameter = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBoxDectionSet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDectionSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(775, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "进入传感器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "离开传感器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "触发延时";
            // 
            // textBoxSensorLeaveDelayTime
            // 
            this.textBoxSensorLeaveDelayTime.Location = new System.Drawing.Point(129, 253);
            this.textBoxSensorLeaveDelayTime.Name = "textBoxSensorLeaveDelayTime";
            this.textBoxSensorLeaveDelayTime.Size = new System.Drawing.Size(35, 21);
            this.textBoxSensorLeaveDelayTime.TabIndex = 4;
            this.textBoxSensorLeaveDelayTime.TextChanged += new System.EventHandler(this.textBoxSensorLeaveDelayTime_TextChanged);
            // 
            // labelSenorLeaveDelayTimeUnit
            // 
            this.labelSenorLeaveDelayTimeUnit.AutoSize = true;
            this.labelSenorLeaveDelayTimeUnit.BackColor = System.Drawing.Color.White;
            this.labelSenorLeaveDelayTimeUnit.ForeColor = System.Drawing.Color.Red;
            this.labelSenorLeaveDelayTimeUnit.Location = new System.Drawing.Point(170, 256);
            this.labelSenorLeaveDelayTimeUnit.Name = "labelSenorLeaveDelayTimeUnit";
            this.labelSenorLeaveDelayTimeUnit.Size = new System.Drawing.Size(27, 13);
            this.labelSenorLeaveDelayTimeUnit.TabIndex = 5;
            this.labelSenorLeaveDelayTimeUnit.Text = "μs";
            // 
            // labelSenorEnterDelayTimeUnit
            // 
            this.labelSenorEnterDelayTimeUnit.AutoSize = true;
            this.labelSenorEnterDelayTimeUnit.BackColor = System.Drawing.Color.White;
            this.labelSenorEnterDelayTimeUnit.ForeColor = System.Drawing.Color.Red;
            this.labelSenorEnterDelayTimeUnit.Location = new System.Drawing.Point(757, 349);
            this.labelSenorEnterDelayTimeUnit.Name = "labelSenorEnterDelayTimeUnit";
            this.labelSenorEnterDelayTimeUnit.Size = new System.Drawing.Size(27, 13);
            this.labelSenorEnterDelayTimeUnit.TabIndex = 8;
            this.labelSenorEnterDelayTimeUnit.Text = "μs";
            // 
            // textBoxSensorEnterDelayTime
            // 
            this.textBoxSensorEnterDelayTime.Location = new System.Drawing.Point(716, 346);
            this.textBoxSensorEnterDelayTime.Name = "textBoxSensorEnterDelayTime";
            this.textBoxSensorEnterDelayTime.Size = new System.Drawing.Size(35, 21);
            this.textBoxSensorEnterDelayTime.TabIndex = 7;
            this.textBoxSensorEnterDelayTime.TextChanged += new System.EventHandler(this.textBoxSensorEnterDelayTime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(655, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "触发延时";
            // 
            // labelThicUnit
            // 
            this.labelThicUnit.AutoSize = true;
            this.labelThicUnit.BackColor = System.Drawing.Color.White;
            this.labelThicUnit.ForeColor = System.Drawing.Color.Red;
            this.labelThicUnit.Location = new System.Drawing.Point(96, 8);
            this.labelThicUnit.Name = "labelThicUnit";
            this.labelThicUnit.Size = new System.Drawing.Size(21, 13);
            this.labelThicUnit.TabIndex = 11;
            this.labelThicUnit.Text = "mm";
            // 
            // textBoxthick
            // 
            this.textBoxthick.Location = new System.Drawing.Point(57, 5);
            this.textBoxthick.Name = "textBoxthick";
            this.textBoxthick.Size = new System.Drawing.Size(35, 21);
            this.textBoxthick.TabIndex = 10;
            this.textBoxthick.TextChanged += new System.EventHandler(this.textBoxthick_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "壁厚";
            // 
            // labelThickLimitUnit
            // 
            this.labelThickLimitUnit.AutoSize = true;
            this.labelThickLimitUnit.BackColor = System.Drawing.Color.White;
            this.labelThickLimitUnit.ForeColor = System.Drawing.Color.Red;
            this.labelThickLimitUnit.Location = new System.Drawing.Point(124, 32);
            this.labelThickLimitUnit.Name = "labelThickLimitUnit";
            this.labelThickLimitUnit.Size = new System.Drawing.Size(21, 13);
            this.labelThickLimitUnit.TabIndex = 14;
            this.labelThickLimitUnit.Text = "mm";
            // 
            // textBoxthickLimit
            // 
            this.textBoxthickLimit.Location = new System.Drawing.Point(83, 29);
            this.textBoxthickLimit.Name = "textBoxthickLimit";
            this.textBoxthickLimit.Size = new System.Drawing.Size(35, 21);
            this.textBoxthickLimit.TabIndex = 13;
            this.textBoxthickLimit.TextChanged += new System.EventHandler(this.textBoxthickLimit_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(22, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "壁厚超限";
            // 
            // label1OuterDefectLimit
            // 
            this.label1OuterDefectLimit.AutoSize = true;
            this.label1OuterDefectLimit.BackColor = System.Drawing.Color.White;
            this.label1OuterDefectLimit.ForeColor = System.Drawing.Color.Red;
            this.label1OuterDefectLimit.Location = new System.Drawing.Point(478, 63);
            this.label1OuterDefectLimit.Name = "label1OuterDefectLimit";
            this.label1OuterDefectLimit.Size = new System.Drawing.Size(21, 13);
            this.label1OuterDefectLimit.TabIndex = 17;
            this.label1OuterDefectLimit.Text = "mm";
            // 
            // textBoxOuterDefectLimit
            // 
            this.textBoxOuterDefectLimit.Location = new System.Drawing.Point(437, 60);
            this.textBoxOuterDefectLimit.Name = "textBoxOuterDefectLimit";
            this.textBoxOuterDefectLimit.Size = new System.Drawing.Size(35, 21);
            this.textBoxOuterDefectLimit.TabIndex = 16;
            this.textBoxOuterDefectLimit.TextChanged += new System.EventHandler(this.textBoxOuterDefectLimit_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(376, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "外伤超限";
            // 
            // labelUnitInnerDefectLimit
            // 
            this.labelUnitInnerDefectLimit.AutoSize = true;
            this.labelUnitInnerDefectLimit.BackColor = System.Drawing.Color.Transparent;
            this.labelUnitInnerDefectLimit.ForeColor = System.Drawing.Color.Red;
            this.labelUnitInnerDefectLimit.Location = new System.Drawing.Point(478, 211);
            this.labelUnitInnerDefectLimit.Name = "labelUnitInnerDefectLimit";
            this.labelUnitInnerDefectLimit.Size = new System.Drawing.Size(21, 13);
            this.labelUnitInnerDefectLimit.TabIndex = 20;
            this.labelUnitInnerDefectLimit.Text = "mm";
            // 
            // textBoxInnerDefectLimit
            // 
            this.textBoxInnerDefectLimit.Location = new System.Drawing.Point(437, 207);
            this.textBoxInnerDefectLimit.Name = "textBoxInnerDefectLimit";
            this.textBoxInnerDefectLimit.Size = new System.Drawing.Size(35, 21);
            this.textBoxInnerDefectLimit.TabIndex = 19;
            this.textBoxInnerDefectLimit.TextChanged += new System.EventHandler(this.textBoxInnerDefectLimit_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(376, 211);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 13);
            this.label.TabIndex = 18;
            this.label.Text = "内伤超限";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(13, 429);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(46, 13);
            this.lblOperator.TabIndex = 21;
            this.lblOperator.Tag = "CheckInfoOperator";
            this.lblOperator.Text = "操作员";
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(99, 423);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(132, 21);
            this.txtOperator.TabIndex = 22;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(99, 458);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(132, 21);
            this.txtProductName.TabIndex = 39;
            // 
            // txtWorkpieceSpec
            // 
            this.txtWorkpieceSpec.Location = new System.Drawing.Point(99, 493);
            this.txtWorkpieceSpec.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkpieceSpec.Name = "txtWorkpieceSpec";
            this.txtWorkpieceSpec.Size = new System.Drawing.Size(132, 21);
            this.txtWorkpieceSpec.TabIndex = 41;
            // 
            // txtWorkpieceKind
            // 
            this.txtWorkpieceKind.Location = new System.Drawing.Point(369, 423);
            this.txtWorkpieceKind.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkpieceKind.Name = "txtWorkpieceKind";
            this.txtWorkpieceKind.Size = new System.Drawing.Size(132, 21);
            this.txtWorkpieceKind.TabIndex = 40;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(13, 464);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 13);
            this.lblProductName.TabIndex = 36;
            this.lblProductName.Tag = "CheckInfoPanellblProductName";
            this.lblProductName.Text = "产品名称";
            // 
            // lblWorkpieceSpec
            // 
            this.lblWorkpieceSpec.AutoSize = true;
            this.lblWorkpieceSpec.Location = new System.Drawing.Point(13, 499);
            this.lblWorkpieceSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkpieceSpec.Name = "lblWorkpieceSpec";
            this.lblWorkpieceSpec.Size = new System.Drawing.Size(33, 13);
            this.lblWorkpieceSpec.TabIndex = 37;
            this.lblWorkpieceSpec.Tag = "CheckInfoPanellblWorkpieceSpec";
            this.lblWorkpieceSpec.Text = "规格";
            // 
            // lblWorkpieceKind
            // 
            this.lblWorkpieceKind.AutoSize = true;
            this.lblWorkpieceKind.Location = new System.Drawing.Point(283, 429);
            this.lblWorkpieceKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkpieceKind.Name = "lblWorkpieceKind";
            this.lblWorkpieceKind.Size = new System.Drawing.Size(33, 13);
            this.lblWorkpieceKind.TabIndex = 38;
            this.lblWorkpieceKind.Tag = "CheckInfoPanellblWorkpieceKind";
            this.lblWorkpieceKind.Text = "钢种";
            // 
            // lblWorkpieceClass
            // 
            this.lblWorkpieceClass.AutoSize = true;
            this.lblWorkpieceClass.Location = new System.Drawing.Point(13, 534);
            this.lblWorkpieceClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkpieceClass.Name = "lblWorkpieceClass";
            this.lblWorkpieceClass.Size = new System.Drawing.Size(33, 13);
            this.lblWorkpieceClass.TabIndex = 34;
            this.lblWorkpieceClass.Tag = "CheckInfoWorkpieceClass";
            this.lblWorkpieceClass.Text = "钢级";
            // 
            // txtWorkpieceClass
            // 
            this.txtWorkpieceClass.Location = new System.Drawing.Point(99, 528);
            this.txtWorkpieceClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkpieceClass.Name = "txtWorkpieceClass";
            this.txtWorkpieceClass.Size = new System.Drawing.Size(132, 21);
            this.txtWorkpieceClass.TabIndex = 35;
            // 
            // txtCheckTime
            // 
            this.txtCheckTime.Location = new System.Drawing.Point(641, 496);
            this.txtCheckTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckTime.Name = "txtCheckTime";
            this.txtCheckTime.Size = new System.Drawing.Size(132, 21);
            this.txtCheckTime.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 499);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 52;
            this.label4.Tag = "CheckTime";
            this.label4.Text = "检测时间";
            // 
            // txtWorkListNo
            // 
            this.txtWorkListNo.Location = new System.Drawing.Point(641, 461);
            this.txtWorkListNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkListNo.Name = "txtWorkListNo";
            this.txtWorkListNo.Size = new System.Drawing.Size(132, 21);
            this.txtWorkListNo.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 50;
            this.label5.Tag = "WorkListNum";
            this.label5.Text = "工单号";
            // 
            // txtCheckStandard
            // 
            this.txtCheckStandard.Location = new System.Drawing.Point(369, 461);
            this.txtCheckStandard.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckStandard.Name = "txtCheckStandard";
            this.txtCheckStandard.Size = new System.Drawing.Size(132, 21);
            this.txtCheckStandard.TabIndex = 46;
            // 
            // txtWorkpieceNo
            // 
            this.txtWorkpieceNo.Location = new System.Drawing.Point(369, 496);
            this.txtWorkpieceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkpieceNo.Name = "txtWorkpieceNo";
            this.txtWorkpieceNo.Size = new System.Drawing.Size(132, 21);
            this.txtWorkpieceNo.TabIndex = 49;
            // 
            // txtWorkpieceStatus
            // 
            this.txtWorkpieceStatus.Location = new System.Drawing.Point(369, 528);
            this.txtWorkpieceStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkpieceStatus.Name = "txtWorkpieceStatus";
            this.txtWorkpieceStatus.Size = new System.Drawing.Size(132, 21);
            this.txtWorkpieceStatus.TabIndex = 48;
            // 
            // txtFurnaceNo
            // 
            this.txtFurnaceNo.Location = new System.Drawing.Point(641, 426);
            this.txtFurnaceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFurnaceNo.Name = "txtFurnaceNo";
            this.txtFurnaceNo.Size = new System.Drawing.Size(132, 21);
            this.txtFurnaceNo.TabIndex = 47;
            // 
            // lblFurnaceNo
            // 
            this.lblFurnaceNo.AutoSize = true;
            this.lblFurnaceNo.Location = new System.Drawing.Point(555, 429);
            this.lblFurnaceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFurnaceNo.Name = "lblFurnaceNo";
            this.lblFurnaceNo.Size = new System.Drawing.Size(46, 13);
            this.lblFurnaceNo.TabIndex = 42;
            this.lblFurnaceNo.Tag = "CheckInfoPanellblFurnaceNo";
            this.lblFurnaceNo.Text = "炉批号";
            // 
            // lblWorkpieceStatus
            // 
            this.lblWorkpieceStatus.AutoSize = true;
            this.lblWorkpieceStatus.Location = new System.Drawing.Point(283, 531);
            this.lblWorkpieceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkpieceStatus.Name = "lblWorkpieceStatus";
            this.lblWorkpieceStatus.Size = new System.Drawing.Size(33, 13);
            this.lblWorkpieceStatus.TabIndex = 43;
            this.lblWorkpieceStatus.Tag = "CheckInfoPanellblWorkpieceStatus";
            this.lblWorkpieceStatus.Text = "状态";
            // 
            // lblWorkpieceNo
            // 
            this.lblWorkpieceNo.AutoSize = true;
            this.lblWorkpieceNo.Location = new System.Drawing.Point(283, 499);
            this.lblWorkpieceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkpieceNo.Name = "lblWorkpieceNo";
            this.lblWorkpieceNo.Size = new System.Drawing.Size(46, 13);
            this.lblWorkpieceNo.TabIndex = 45;
            this.lblWorkpieceNo.Tag = "CheckInfoPanellblWorkpieceNo";
            this.lblWorkpieceNo.Text = "钢管号";
            // 
            // lblCheckStandard
            // 
            this.lblCheckStandard.AutoSize = true;
            this.lblCheckStandard.Location = new System.Drawing.Point(283, 464);
            this.lblCheckStandard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckStandard.Name = "lblCheckStandard";
            this.lblCheckStandard.Size = new System.Drawing.Size(59, 13);
            this.lblCheckStandard.TabIndex = 44;
            this.lblCheckStandard.Tag = "CheckInfoPanellblCheckStandard";
            this.lblCheckStandard.Text = "探伤标准";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(641, 541);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(100, 40);
            this.buttonSet.TabIndex = 54;
            this.buttonSet.Text = "确定";
            this.buttonSet.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 54;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPipeLengthUnit
            // 
            this.labelPipeLengthUnit.AutoSize = true;
            this.labelPipeLengthUnit.BackColor = System.Drawing.Color.White;
            this.labelPipeLengthUnit.ForeColor = System.Drawing.Color.Red;
            this.labelPipeLengthUnit.Location = new System.Drawing.Point(372, 352);
            this.labelPipeLengthUnit.Name = "labelPipeLengthUnit";
            this.labelPipeLengthUnit.Size = new System.Drawing.Size(21, 13);
            this.labelPipeLengthUnit.TabIndex = 57;
            this.labelPipeLengthUnit.Text = "mm";
            // 
            // textBoxPipeLength
            // 
            this.textBoxPipeLength.Location = new System.Drawing.Point(331, 349);
            this.textBoxPipeLength.Name = "textBoxPipeLength";
            this.textBoxPipeLength.Size = new System.Drawing.Size(35, 21);
            this.textBoxPipeLength.TabIndex = 56;
            this.textBoxPipeLength.TextChanged += new System.EventHandler(this.textBoxPipeLength_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(292, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "管长";
            // 
            // labelDiameterUnit
            // 
            this.labelDiameterUnit.AutoSize = true;
            this.labelDiameterUnit.BackColor = System.Drawing.Color.White;
            this.labelDiameterUnit.ForeColor = System.Drawing.Color.Red;
            this.labelDiameterUnit.Location = new System.Drawing.Point(757, 120);
            this.labelDiameterUnit.Name = "labelDiameterUnit";
            this.labelDiameterUnit.Size = new System.Drawing.Size(21, 13);
            this.labelDiameterUnit.TabIndex = 60;
            this.labelDiameterUnit.Text = "mm";
            // 
            // textBoxDiameter
            // 
            this.textBoxDiameter.Location = new System.Drawing.Point(716, 117);
            this.textBoxDiameter.Name = "textBoxDiameter";
            this.textBoxDiameter.Size = new System.Drawing.Size(35, 21);
            this.textBoxDiameter.TabIndex = 59;
            this.textBoxDiameter.TextChanged += new System.EventHandler(this.textBoxDiameter_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(677, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "管径";
            // 
            // pictureBoxDectionSet
            // 
            this.pictureBoxDectionSet.Image = global::HSD_EMAT_Chan4.Properties.Resources.DetectionProcess;
            this.pictureBoxDectionSet.Location = new System.Drawing.Point(1, 4);
            this.pictureBoxDectionSet.Name = "pictureBoxDectionSet";
            this.pictureBoxDectionSet.Size = new System.Drawing.Size(850, 393);
            this.pictureBoxDectionSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDectionSet.TabIndex = 0;
            this.pictureBoxDectionSet.TabStop = false;
            // 
            // DetectionSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 593);
            this.Controls.Add(this.labelDiameterUnit);
            this.Controls.Add(this.textBoxDiameter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelPipeLengthUnit);
            this.Controls.Add(this.textBoxPipeLength);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.txtCheckTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWorkListNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCheckStandard);
            this.Controls.Add(this.txtWorkpieceNo);
            this.Controls.Add(this.txtWorkpieceStatus);
            this.Controls.Add(this.txtFurnaceNo);
            this.Controls.Add(this.lblFurnaceNo);
            this.Controls.Add(this.lblWorkpieceStatus);
            this.Controls.Add(this.lblWorkpieceNo);
            this.Controls.Add(this.lblCheckStandard);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtWorkpieceSpec);
            this.Controls.Add(this.txtWorkpieceKind);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblWorkpieceSpec);
            this.Controls.Add(this.lblWorkpieceKind);
            this.Controls.Add(this.lblWorkpieceClass);
            this.Controls.Add(this.txtWorkpieceClass);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.labelUnitInnerDefectLimit);
            this.Controls.Add(this.textBoxInnerDefectLimit);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1OuterDefectLimit);
            this.Controls.Add(this.textBoxOuterDefectLimit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelThickLimitUnit);
            this.Controls.Add(this.textBoxthickLimit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelThicUnit);
            this.Controls.Add(this.textBoxthick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSenorEnterDelayTimeUnit);
            this.Controls.Add(this.textBoxSensorEnterDelayTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSenorLeaveDelayTimeUnit);
            this.Controls.Add(this.textBoxSensorLeaveDelayTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDectionSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetectionSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检测设置";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDectionSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDectionSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSensorLeaveDelayTime;
        private System.Windows.Forms.Label labelSenorLeaveDelayTimeUnit;
        private System.Windows.Forms.Label labelSenorEnterDelayTimeUnit;
        private System.Windows.Forms.TextBox textBoxSensorEnterDelayTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelThicUnit;
        private System.Windows.Forms.TextBox textBoxthick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelThickLimitUnit;
        private System.Windows.Forms.TextBox textBoxthickLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1OuterDefectLimit;
        private System.Windows.Forms.TextBox textBoxOuterDefectLimit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelUnitInnerDefectLimit;
        private System.Windows.Forms.TextBox textBoxInnerDefectLimit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtWorkpieceSpec;
        private System.Windows.Forms.TextBox txtWorkpieceKind;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblWorkpieceSpec;
        private System.Windows.Forms.Label lblWorkpieceKind;
        private System.Windows.Forms.Label lblWorkpieceClass;
        private System.Windows.Forms.TextBox txtWorkpieceClass;
        private System.Windows.Forms.TextBox txtCheckTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkListNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckStandard;
        private System.Windows.Forms.TextBox txtWorkpieceNo;
        private System.Windows.Forms.TextBox txtWorkpieceStatus;
        private System.Windows.Forms.TextBox txtFurnaceNo;
        private System.Windows.Forms.Label lblFurnaceNo;
        private System.Windows.Forms.Label lblWorkpieceStatus;
        private System.Windows.Forms.Label lblWorkpieceNo;
        private System.Windows.Forms.Label lblCheckStandard;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPipeLengthUnit;
        private System.Windows.Forms.TextBox textBoxPipeLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDiameterUnit;
        private System.Windows.Forms.TextBox textBoxDiameter;
        private System.Windows.Forms.Label label13;
    }
}