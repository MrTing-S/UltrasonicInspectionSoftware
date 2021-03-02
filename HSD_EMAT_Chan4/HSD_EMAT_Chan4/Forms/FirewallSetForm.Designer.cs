namespace HSD_EMAT_Chan4.Forms
{
    partial class FirewallSetForm
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
            this.buttonCheckAdministratorRight = new System.Windows.Forms.Button();
            this.buttonCloseFireWall = new System.Windows.Forms.Button();
            this.buttonOpenFirewall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheckAdministratorRight
            // 
            this.buttonCheckAdministratorRight.Location = new System.Drawing.Point(12, 54);
            this.buttonCheckAdministratorRight.Name = "buttonCheckAdministratorRight";
            this.buttonCheckAdministratorRight.Size = new System.Drawing.Size(133, 40);
            this.buttonCheckAdministratorRight.TabIndex = 0;
            this.buttonCheckAdministratorRight.Text = "查询管理员权限";
            this.buttonCheckAdministratorRight.UseVisualStyleBackColor = true;
            this.buttonCheckAdministratorRight.Click += new System.EventHandler(this.buttonCheckAdministratorRight_Click);
            // 
            // buttonCloseFireWall
            // 
            this.buttonCloseFireWall.Location = new System.Drawing.Point(166, 54);
            this.buttonCloseFireWall.Name = "buttonCloseFireWall";
            this.buttonCloseFireWall.Size = new System.Drawing.Size(100, 40);
            this.buttonCloseFireWall.TabIndex = 0;
            this.buttonCloseFireWall.Text = "关闭防火墙";
            this.buttonCloseFireWall.UseVisualStyleBackColor = true;
            this.buttonCloseFireWall.Click += new System.EventHandler(this.buttonCloseFireWall_Click);
            // 
            // buttonOpenFirewall
            // 
            this.buttonOpenFirewall.Location = new System.Drawing.Point(287, 54);
            this.buttonOpenFirewall.Name = "buttonOpenFirewall";
            this.buttonOpenFirewall.Size = new System.Drawing.Size(100, 40);
            this.buttonOpenFirewall.TabIndex = 0;
            this.buttonOpenFirewall.Text = "开启防火墙";
            this.buttonOpenFirewall.UseVisualStyleBackColor = true;
            this.buttonOpenFirewall.Click += new System.EventHandler(this.buttonOpenFirewall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请设置当前主机IP地址为： 192 168 1 240";
            // 
            // FirewallSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 109);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenFirewall);
            this.Controls.Add(this.buttonCloseFireWall);
            this.Controls.Add(this.buttonCheckAdministratorRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirewallSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "网络/防火墙设置";
            this.Load += new System.EventHandler(this.FirewallSetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckAdministratorRight;
        private System.Windows.Forms.Button buttonCloseFireWall;
        private System.Windows.Forms.Button buttonOpenFirewall;
        private System.Windows.Forms.Label label1;
    }
}