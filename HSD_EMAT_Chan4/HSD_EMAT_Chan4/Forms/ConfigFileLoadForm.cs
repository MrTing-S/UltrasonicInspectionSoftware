using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HSD_EMAT_Chan4.Forms
{
    public partial class ConfigFileLoadForm : Form
    {
        public string fileName;
        private string configPath = Application.StartupPath + "\\ConfigFile\\";//config文件的地址
        private  List<string> m_configPathNames;
        public ConfigFileLoadForm()
        {
            InitializeComponent();
        }

        public ConfigFileLoadForm(List<string> configPathNames)
        {
            InitializeComponent();
            checkedListBoxConfigFiles.Items.AddRange(configPathNames.ToArray());
            m_configPathNames = configPathNames;
            checkedListBoxConfigFiles.CheckOnClick = true;//点击立即切换
            if (checkedListBoxConfigFiles.SelectedItems.Count == 0)
            {
                buttonLoadConfig.Enabled = false;
                buttonDeletConfig.Enabled = false;
            }

        }

        private void checkedListBoxConfigFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int checkNum=0;
            foreach (int nIndex in checkedListBoxConfigFiles.CheckedIndices)
            {
                if (nIndex != e.Index)
                {
                    checkedListBoxConfigFiles.SetItemCheckState(nIndex, CheckState.Unchecked);
                }
            }
            for (int i = 0; i < checkedListBoxConfigFiles.Items.Count; i++)
            {
                if (checkedListBoxConfigFiles.GetItemChecked(i))
                { 
                    checkNum++; 
                }
            }
            if (checkNum == 0)
            {
                buttonLoadConfig.Enabled = true;
                buttonDeletConfig.Enabled = true;
            }
            else
            {
                buttonLoadConfig.Enabled = false;
                buttonDeletConfig.Enabled = false;
            }
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            this.fileName = this.checkedListBoxConfigFiles.SelectedItem.ToString();
            this.DialogResult = DialogResult.Yes;//加载信号
            this.Close();
        }

        private void buttonDeletConfig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要删除所选配置？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    File.Delete(configPath + this.checkedListBoxConfigFiles.SelectedItem.ToString());
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
                this.Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeletAllConfig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要清空所有配置？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (string item in m_configPathNames)
                {
                    try
                    {
                        File.Delete(configPath + item);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
