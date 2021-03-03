namespace HSD_EMAT_Chan4.Forms
{
    partial class GageForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxGageTpye = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.trackBarGageLength = new System.Windows.Forms.TrackBar();
            this.trackBarGagePosY = new System.Windows.Forms.TrackBar();
            this.trackBarGagePosX = new System.Windows.Forms.TrackBar();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGagePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGagePosX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxGageTpye);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.trackBarGageLength);
            this.groupBox3.Controls.Add(this.trackBarGagePosY);
            this.groupBox3.Controls.Add(this.trackBarGagePosX);
            this.groupBox3.Location = new System.Drawing.Point(9, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(280, 162);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "闸门设置";
            // 
            // comboBoxGageTpye
            // 
            this.comboBoxGageTpye.FormattingEnabled = true;
            this.comboBoxGageTpye.Items.AddRange(new object[] {
            "闸门A",
            "闸门B"});
            this.comboBoxGageTpye.Location = new System.Drawing.Point(46, 18);
            this.comboBoxGageTpye.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGageTpye.Name = "comboBoxGageTpye";
            this.comboBoxGageTpye.Size = new System.Drawing.Size(72, 20);
            this.comboBoxGageTpye.TabIndex = 160;
            this.comboBoxGageTpye.Text = "闸门A";
            this.comboBoxGageTpye.SelectedIndexChanged += new System.EventHandler(this.comboBoxGageTpye_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(2, 20);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 159;
            this.label23.Text = "闸门：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(2, 94);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 13);
            this.label28.TabIndex = 158;
            this.label28.Text = "长度";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(2, 66);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 157;
            this.label27.Text = "y";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(2, 40);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 152;
            this.label26.Text = "x";
            // 
            // trackBarGageLength
            // 
            this.trackBarGageLength.Location = new System.Drawing.Point(27, 94);
            this.trackBarGageLength.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarGageLength.Maximum = 50;
            this.trackBarGageLength.Name = "trackBarGageLength";
            this.trackBarGageLength.Size = new System.Drawing.Size(247, 56);
            this.trackBarGageLength.TabIndex = 156;
            this.trackBarGageLength.Tag = "tr6";
            this.trackBarGageLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGageLength.Value = 5;
            this.trackBarGageLength.Scroll += new System.EventHandler(this.trackBarGageLength_Scroll);
            // 
            // trackBarGagePosY
            // 
            this.trackBarGagePosY.Location = new System.Drawing.Point(27, 66);
            this.trackBarGagePosY.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarGagePosY.Maximum = 100;
            this.trackBarGagePosY.Minimum = 1;
            this.trackBarGagePosY.Name = "trackBarGagePosY";
            this.trackBarGagePosY.Size = new System.Drawing.Size(247, 56);
            this.trackBarGagePosY.TabIndex = 155;
            this.trackBarGagePosY.Tag = "tr6";
            this.trackBarGagePosY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGagePosY.Value = 50;
            this.trackBarGagePosY.Scroll += new System.EventHandler(this.trackBarGagePosY_Scroll);
            // 
            // trackBarGagePosX
            // 
            this.trackBarGagePosX.Location = new System.Drawing.Point(27, 40);
            this.trackBarGagePosX.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarGagePosX.Maximum = 100;
            this.trackBarGagePosX.Minimum = 1;
            this.trackBarGagePosX.Name = "trackBarGagePosX";
            this.trackBarGagePosX.Size = new System.Drawing.Size(247, 56);
            this.trackBarGagePosX.TabIndex = 154;
            this.trackBarGagePosX.Tag = "tr6";
            this.trackBarGagePosX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGagePosX.Value = 50;
            this.trackBarGagePosX.Scroll += new System.EventHandler(this.trackBarGagePosX_Scroll);
            // 
            // GageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 494);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GageForm";
            this.Text = "检测设置";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGagePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGagePosX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TrackBar trackBarGageLength;
        private System.Windows.Forms.TrackBar trackBarGagePosY;
        private System.Windows.Forms.TrackBar trackBarGagePosX;
        private System.Windows.Forms.ComboBox comboBoxGageTpye;
        private System.Windows.Forms.Label label23;
    }
}