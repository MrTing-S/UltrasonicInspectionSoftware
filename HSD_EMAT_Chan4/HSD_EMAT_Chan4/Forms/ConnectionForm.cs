using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using HSD_EMAT_Chan4.DLL;

namespace HSD_EMAT_Chan4.Forms
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();  
        }

        private void buttonStopConnect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            ConnectStrat();
            timer1.Start();
        }
        private void ConnectStrat()
        {
            Thread thread = new Thread(() =>
            {
                NetModuleHelper.NetModuleConnect();
            });
            thread.IsBackground = true;
            thread.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NetModuleHelper.connectStatus == 1)
            {
                this.labelDialog.Text = "连接成功";
                GetAllStatus.SetIsSeverConnecting(true);
                Thread.Sleep(500);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
