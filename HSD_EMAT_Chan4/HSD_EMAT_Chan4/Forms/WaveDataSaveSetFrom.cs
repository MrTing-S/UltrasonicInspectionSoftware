using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HSD_EMAT_Chan4.DLL;
using HSD_EMAT_Chan4.Models;
using System.IO;

namespace HSD_EMAT_Chan4.Forms
{
    public partial class WaveDataSaveSetFrom : Form
    {
        private string waveDataDefaultPath = Application.StartupPath + "\\WaveDataFile\\";//数据文件的地址
        private WaveDataFile m_waveDataFile;
        private string fileNameByTime;
        public WaveDataFileSet.DelGetSaveFileInfo delGetSaveFileInfo;
        public  bool isUsinngDefaultPath;//是否使用默认路径
        public WaveDataSaveSetFrom()
        {
            InitializeComponent();
        }

        private void WaveDataSaveSetFrom_Load(object sender, EventArgs e)
        {
            InitialComboBox();
            this.checkBoxIsRecordAllChannels.Checked = true;
            this.fileNameByTime = Funcations.GetCurTimeSequence()+".txt";
            this.textBoxFileName.Text = fileNameByTime;
            this.isUsinngDefaultPath = true;//默认使用绝对路径
            this.m_waveDataFile = new WaveDataFile();
        }

        private void InitialComboBox()
        {
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                this.comboBoxRecrdChannel.Items.AddRange(new object[] {
            "通道"+(i+1).ToString()});
            }
            this.comboBoxRecrdChannel.SelectedIndex = 0;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (!File.Exists(waveDataDefaultPath))//创建配置文件夹
            {
                Directory.CreateDirectory(waveDataDefaultPath);
            }
            SaveFileDialog objSaveFileDialog = new SaveFileDialog();
            objSaveFileDialog.Title = "请选择保存文件路径";
            objSaveFileDialog.Filter = "文本文档(*.txt)|*.txt";
            objSaveFileDialog.InitialDirectory = waveDataDefaultPath;
            objSaveFileDialog.FileName = fileNameByTime;
            objSaveFileDialog.OverwritePrompt = true;  //是否覆盖当前文件
            objSaveFileDialog.RestoreDirectory = true;  //还原目录
            if (objSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.m_waveDataFile.filePath = objSaveFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(objSaveFileDialog.FileName);
                this.m_waveDataFile.fileName = fileInfo.Name;
                this.textBoxFileName.Text = fileInfo.Name;
                this.textBoxFileName.Enabled = false;
                this.isUsinngDefaultPath = false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxIsRecordAllChannels_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsRecordAllChannels.Checked)
            {
                this.comboBoxRecrdChannel.Enabled = false;
            }
            else
            {
                this.comboBoxRecrdChannel.Enabled = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (this.isUsinngDefaultPath)
            {
                if (this.textBoxFileName.Text.Length == 0)
                {
                    MessageBox.Show("请输入文件名");
                    return;
                }
                this.m_waveDataFile.fileName = this.textBoxFileName.Text;
                this.m_waveDataFile.filePath = this.waveDataDefaultPath + this.textBoxFileName.Text;
            }
            this.delGetSaveFileInfo(this.m_waveDataFile);//传递文件的值给主窗体
            MessageBox.Show("文件保存成功");
            this.DialogResult = DialogResult.OK;
            
        }
    }
}

