namespace HSD_EMAT_Chan4.Forms
{
    partial class ConfigFileSaveForm
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
            this.textBoxconfigName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxconfigName
            // 
            this.textBoxconfigName.Location = new System.Drawing.Point(81, 48);
            this.textBoxconfigName.Name = "textBoxconfigName";
            this.textBoxconfigName.Size = new System.Drawing.Size(204, 25);
            this.textBoxconfigName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件名";
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(53, 104);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(100, 40);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "保存";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(184, 104);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(100, 40);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "取消";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // ConfigFileSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 182);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxconfigName);
            this.Name = "ConfigFileSaveForm";
            this.Text = "配置另存为";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxconfigName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butClose;
    }
}