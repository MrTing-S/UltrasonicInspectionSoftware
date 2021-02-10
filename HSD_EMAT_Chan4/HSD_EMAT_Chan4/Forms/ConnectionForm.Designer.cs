namespace HSD_EMAT_Chan4.Forms
{
    partial class ConnectionForm
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
            this.buttonStopConnect = new System.Windows.Forms.Button();
            this.labelDialog = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonStopConnect
            // 
            this.buttonStopConnect.Location = new System.Drawing.Point(499, 288);
            this.buttonStopConnect.Name = "buttonStopConnect";
            this.buttonStopConnect.Size = new System.Drawing.Size(100, 40);
            this.buttonStopConnect.TabIndex = 0;
            this.buttonStopConnect.Text = "取消连接";
            this.buttonStopConnect.UseVisualStyleBackColor = true;
            this.buttonStopConnect.Click += new System.EventHandler(this.buttonStopConnect_Click);
            // 
            // labelDialog
            // 
            this.labelDialog.AutoSize = true;
            this.labelDialog.Location = new System.Drawing.Point(12, 301);
            this.labelDialog.Name = "labelDialog";
            this.labelDialog.Size = new System.Drawing.Size(136, 15);
            this.labelDialog.TabIndex = 1;
            this.labelDialog.Text = "获取连接状态中...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 340);
            this.Controls.Add(this.labelDialog);
            this.Controls.Add(this.buttonStopConnect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接至主机中...";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStopConnect;
        private System.Windows.Forms.Label labelDialog;
        private System.Windows.Forms.Timer timer1;
    }
}