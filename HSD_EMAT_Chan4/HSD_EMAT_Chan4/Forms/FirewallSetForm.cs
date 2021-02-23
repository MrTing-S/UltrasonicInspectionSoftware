using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HSD_EMAT_Chan4.Models;
using HSD_EMAT_Chan4.DLL;
using System.Net;

namespace HSD_EMAT_Chan4.Forms
{
    public partial class FirewallSetForm : Form
    {
        Firewall m_Firewall;
        public FirewallSetForm()
        {
            InitializeComponent();
        }

        private void FirewallSetForm_Load(object sender, EventArgs e)
        {
            m_Firewall = new Firewall();
        }

        private void buttonCheckAdministratorRight_Click(object sender, EventArgs e)
        {
            try
            {
                m_Firewall.administratorRight = DLL.FirewallSet.IsAdministrator();
            }
            catch (Exception a)
            {
                m_Firewall.administratorRight = false;
                MessageBox.Show(a.Message);
            }
            if (m_Firewall.administratorRight)
            {
                MessageBox.Show("已授权管理员权限","结果",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("未授权管理员权限，请以管理员身份运行程序","结果", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void buttonCloseFireWall_Click(object sender, EventArgs e)
        {
            if (!m_Firewall.administratorRight)
            {
                MessageBox.Show("未授权管理员权限，请以管理员身份运行程序", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                m_Firewall.fireWallStatus = !DLL.FirewallSet.FirewallOperateByObject(false, false, false);
                MessageBox.Show("关闭防火墙成功");
            }
            catch (Exception a)
            {
                m_Firewall.fireWallStatus = false;
                MessageBox.Show(a.Message);
            }
        }

        private void buttonOpenFirewall_Click(object sender, EventArgs e)
        {
            if (!m_Firewall.administratorRight)
            {
                MessageBox.Show("未授权管理员权限，请以管理员身份运行程序", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                m_Firewall.fireWallStatus = !DLL.FirewallSet.FirewallOperateByObject();
                MessageBox.Show("开启防火墙成功");
            }
            catch (Exception a)
            {
                m_Firewall.fireWallStatus = false;
                MessageBox.Show(a.Message);
            }
        }
    }
}
