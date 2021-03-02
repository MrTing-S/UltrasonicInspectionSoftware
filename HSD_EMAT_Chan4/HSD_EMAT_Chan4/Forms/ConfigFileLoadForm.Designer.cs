namespace HSD_EMAT_Chan4.Forms
{
    partial class ConfigFileLoadForm
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
            this.checkedListBoxConfigFiles = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.buttonDeletConfig = new System.Windows.Forms.Button();
            this.buttonDeletAllConfig = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxConfigFiles
            // 
            this.checkedListBoxConfigFiles.FormattingEnabled = true;
            this.checkedListBoxConfigFiles.Location = new System.Drawing.Point(30, 38);
            this.checkedListBoxConfigFiles.Name = "checkedListBoxConfigFiles";
            this.checkedListBoxConfigFiles.Size = new System.Drawing.Size(171, 164);
            this.checkedListBoxConfigFiles.TabIndex = 0;
            this.checkedListBoxConfigFiles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxConfigFiles_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "配置文件";
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.Location = new System.Drawing.Point(222, 12);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(100, 40);
            this.buttonLoadConfig.TabIndex = 2;
            this.buttonLoadConfig.Text = "加载配置";
            this.buttonLoadConfig.UseVisualStyleBackColor = true;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
            // 
            // buttonDeletConfig
            // 
            this.buttonDeletConfig.ForeColor = System.Drawing.Color.Red;
            this.buttonDeletConfig.Location = new System.Drawing.Point(222, 64);
            this.buttonDeletConfig.Name = "buttonDeletConfig";
            this.buttonDeletConfig.Size = new System.Drawing.Size(100, 40);
            this.buttonDeletConfig.TabIndex = 3;
            this.buttonDeletConfig.Text = "删除配置";
            this.buttonDeletConfig.UseVisualStyleBackColor = true;
            this.buttonDeletConfig.Click += new System.EventHandler(this.buttonDeletConfig_Click);
            // 
            // buttonDeletAllConfig
            // 
            this.buttonDeletAllConfig.ForeColor = System.Drawing.Color.Red;
            this.buttonDeletAllConfig.Location = new System.Drawing.Point(222, 116);
            this.buttonDeletAllConfig.Name = "buttonDeletAllConfig";
            this.buttonDeletAllConfig.Size = new System.Drawing.Size(100, 40);
            this.buttonDeletAllConfig.TabIndex = 4;
            this.buttonDeletAllConfig.Text = "清空配置";
            this.buttonDeletAllConfig.UseVisualStyleBackColor = true;
            this.buttonDeletAllConfig.Click += new System.EventHandler(this.buttonDeletAllConfig_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose.Location = new System.Drawing.Point(222, 168);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 40);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "取消";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ConfigFileLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 218);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDeletAllConfig);
            this.Controls.Add(this.buttonDeletConfig);
            this.Controls.Add(this.buttonLoadConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxConfigFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigFileLoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigFileLoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxConfigFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.Button buttonDeletConfig;
        private System.Windows.Forms.Button buttonDeletAllConfig;
        private System.Windows.Forms.Button buttonClose;
    }
}