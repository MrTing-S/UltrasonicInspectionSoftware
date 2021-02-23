namespace HSD_EMAT_Chan4.Forms
{
    partial class WaveDataSaveSetFrom
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRecrdChannel = new System.Windows.Forms.ComboBox();
            this.checkBoxIsRecordAllChannels = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(441, 22);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(100, 40);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "浏览";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件名：";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(89, 32);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(346, 25);
            this.textBoxFileName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "保存通道：";
            // 
            // comboBoxRecrdChannel
            // 
            this.comboBoxRecrdChannel.FormattingEnabled = true;
            this.comboBoxRecrdChannel.Location = new System.Drawing.Point(89, 91);
            this.comboBoxRecrdChannel.Name = "comboBoxRecrdChannel";
            this.comboBoxRecrdChannel.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRecrdChannel.TabIndex = 4;
            // 
            // checkBoxIsRecordAllChannels
            // 
            this.checkBoxIsRecordAllChannels.AutoSize = true;
            this.checkBoxIsRecordAllChannels.Location = new System.Drawing.Point(235, 95);
            this.checkBoxIsRecordAllChannels.Name = "checkBoxIsRecordAllChannels";
            this.checkBoxIsRecordAllChannels.Size = new System.Drawing.Size(149, 19);
            this.checkBoxIsRecordAllChannels.TabIndex = 5;
            this.checkBoxIsRecordAllChannels.Text = "保存所有通道参数";
            this.checkBoxIsRecordAllChannels.UseVisualStyleBackColor = true;
            this.checkBoxIsRecordAllChannels.CheckedChanged += new System.EventHandler(this.checkBoxIsRecordAllChannels_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(335, 172);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 40);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "开始记录";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(449, 172);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 40);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "取消";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // WaveDataSaveSetFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 229);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxIsRecordAllChannels);
            this.Controls.Add(this.comboBoxRecrdChannel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaveDataSaveSetFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.WaveDataSaveSetFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRecrdChannel;
        private System.Windows.Forms.CheckBox checkBoxIsRecordAllChannels;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClose;
    }
}