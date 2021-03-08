 namespace HSD_EMAT_Chan4.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml;
    using HSD_EMAT_Chan4.DLL;
    using HSD_EMAT_Chan4.Models;

    public partial class ParamSetForm : Form
    {
        public int CurrChanNum { get { return currChanNum; } }
        private int currChanNum;//当前窗口设置的参数信息
        public bool IsOriData { get { return isOriData; } }
        private bool isOriData;//是否为原始数据
        //private ChannelParam[] currChannelParam;//当前的参数信息
        private string configPath;//config文件的地址
        List<string> configPathNames;//默认最大目录数目不超过50个

        public ParamSetForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            currChanNum = 0;
            //currChannelParam = new ChannelParam[HSD_EMAT.totalChannelNum];
            configPath = Application.StartupPath + "\\ConfigFile\\";
            configPathNames = new List<string>();
        }

        #region 滚动条事件

        private void trackBar_Scroll(object sender, System.EventArgs e)//通用的滚动条参数数据
        {
            #region 
            TrackBar trackBar = (TrackBar)sender;
            DLL.NetModulDll.SendCmdCurrentChan(currChanNum);
            switch (trackBar.Tag.ToString())
            {
                case "tr1":
                    {
                        this.textBoxDigitalGainValue.Text = (trackBar.Value / 10).ToString();
                        DLL.NetModulDll.SendCmdDB1((uint)trackBar.Value);
                        break;
                    }
                case "tr2":
                    {
                        this.textBoxAnalogGainValue.Text = (trackBar.Value / 10).ToString();
                        DLL.NetModulDll.SendCmdDB2((uint)trackBar.Value);
                        break;
                    }
                case "tr3":
                    {
                        this.textBoxSignFreqRatio.Text = (Convert.ToDouble(trackBar.Value) / 10).ToString();
                        DLL.NetModulDll.SendCmdSignFreqRatio((uint)trackBar.Value * 100000);
                        break;
                    }
                case "tr5":
                    {
                        DLL.NetModulDll.SendCmdDelayCount((uint)trackBar.Value * 100);
                        this.textBoxDelayCount.Text = trackBar.Value.ToString();
                        break;
                    }
                case "tr6":
                    {
                        DLL.NetModulDll.SendCmdPulNumber((uint)(trackBar.Value + 1));
                        this.textBoxPulNumber.Text = (trackBar.Value + 1).ToString();
                        break;
                    }
                case "tr7":
                    {
                        DLL.NetModulDll.SendCmdAveNumber((uint)trackBar.Value);
                        this.textBoxAveNumber.Text = Math.Pow(2, (double)(trackBar.Value)).ToString();
                        break;
                    }
                case "tr8":
                    {
                        DLL.NetModulDll.SendCmdFixNumber((uint)trackBar.Value);
                        this.textBoxFixNumber.Text = (trackBar.Value + 1).ToString();
                        break;
                    }
                case "tr9":
                    {
                        DLL.NetModulDll.SendCmdHighVoltage((uint)trackBar.Value);
                        this.textBoxHighVoltage.Text = (300 + 50 * trackBar.Value).ToString();
                        break;
                    }
                case "tr10":
                    {
                        DLL.NetModulDll.SendCmdDigital((uint)(trackBar.Value));
                        this.textBoxDigital.Text = trackBar.Value.ToString();
                        break;
                    }
                case "tr11":
                    {
                        DLL.NetModulDll.setRange(trackBar.Value);
                        this.textBoxRange.Text = trackBar.Value.ToString();
                        break;
                    }
            }
            #endregion
            UpdateParamFromForm(currChanNum);
            UpdateLableFromParam(currChanNum);
        }

        private void trackBarRepeatFreq_Scroll(object sender, EventArgs e)
        {
            AllChannels.RepeatFreq = (uint)trackBarRepeatFreq.Value;
            switch (AllChannels.RepeatFreq.ToString())
            {
                case "0":
                    this.textBoxRepeatFreq.Text = "15";
                    break;
                case "1":
                    this.textBoxRepeatFreq.Text = "50";
                    break;
                case "2":
                    this.textBoxRepeatFreq.Text = "100";
                    break;
                case "3":
                    this.textBoxRepeatFreq.Text = "200";
                    break;
                case "4":
                    this.textBoxRepeatFreq.Text = "500";
                    break;
            }
            DLL.NetModulDll.SendCmdRepeatFreq(AllChannels.RepeatFreq);
        }

        private void trackBarSoundSpeed_Scroll(object sender, EventArgs e)
        {
            AllChannels.SoundSpeed = this.trackBarSoundSpeed.Value;
            this.textBoxSoundSpeed.Text = AllChannels.SoundSpeed.ToString();
        }
        #endregion

        #region 多选框事件
        private void comboBoxChanNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currChanNum = this.comboBoxChanNum.SelectedIndex;
            UpdateTrackBarFromParam(currChanNum);
            UpdateLableFromParam(currChanNum);
            AllForms.m_GageForm.UpdateGageForm(currChanNum);
            if (FormView.m_aveFromViewType == FromViewType.type2)
            {
                AllFormsSet.UpDateFormLayOut(currChanNum);
            }
            else if (FormView.m_aveFromViewType == FromViewType.type4)
            {
                AllFormsSet.UpDateFormLayOut(currChanNum);
            }
            AllForms.m_WaveForms[currChanNum].Focus();
        }

        private void comboBoxWaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(currChanNum);
            DLL.NetModulDll.SendCmdWaveType((uint)this.comboBoxWaveType.SelectedIndex);
        }

        private void comboBoxDataTpye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxDataTpye.SelectedIndex == 0)
            {
                this.isOriData = false;
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    AllForms.m_WaveForms[i].ChangeWaveFormXScale(300);
                }
            }
            if (this.comboBoxDataTpye.SelectedIndex == 1)
            {
                this.isOriData = true;
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    AllForms.m_WaveForms[i].ChangeWaveFormXScale(2000);
                }
            }
        }

        private void trackBar_Enter(object sender, EventArgs e)
        {
            AllForms.m_WaveForms[currChanNum].Focus();
        }
        #endregion

        #region 配置操作按钮事件

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            ConfigFileSaveForm configFileSaveForm = new ConfigFileSaveForm();
            configFileSaveForm.ShowDialog();
            if (configFileSaveForm.DialogResult == DialogResult.OK)
            {
                if (configFileSaveForm.fileName.Length == 0)
                {
                    MessageBox.Show("请输入配置文件名");
                    return;
                }
                else
                {
                    try
                    {
                        AllChannelsSet.SaveParamToXml(configPath + configFileSaveForm.fileName);
                        MessageBox.Show("配置文件保存成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            FindAllConfigFileName(configPath);//获取所有的文件名
            ConfigFileLoadForm configFileLoadForm = new ConfigFileLoadForm(configPathNames);
            configFileLoadForm.ShowDialog();
            if (configFileLoadForm.DialogResult == DialogResult.Cancel)
            {
                try
                {
                    AllChannelsSet.SaveParamToXml(configPath+"configInfo");//配置清空，重建默认配置
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (configFileLoadForm.DialogResult == DialogResult.Yes)
            {
                try
                {
                    UpdateAllFormFromXml(configPath + configFileLoadForm.fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AllChannelsSet.UpDateSysAllParam();
            }
        }

        private void buttonLoadDefaultCnfig_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAllFormFromXml(configPath + "configInfo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AllChannelsSet.UpDateSysAllParam();
        }

        //从xml文件中读取更新参数窗体与闸门窗体
        private void UpdateAllFormFromXml(string filePath)
        {
            AllChannelsSet.UpdateParamFromXml(filePath);//从配置中读取参数
            UpdateTrackBarFromParam(currChanNum);
            UpdateLableFromParam(currChanNum);
            AllForms.m_GageForm.UpdateGageForm(currChanNum);
        }
        #endregion

        #region 读取与存储配置函数

        private void FindAllConfigFileName(string path)
        {
            configPathNames.Clear();
            DirectoryInfo objDirectoryInfo = new DirectoryInfo(path);
            FileSystemInfo[] objFileSystemInfo = objDirectoryInfo.GetFileSystemInfos();//返回文件夹数组
            foreach (FileSystemInfo item in objFileSystemInfo)
            {
                if (item is DirectoryInfo)//判断是否为文件夹
                {
                    FindAllConfigFileName(item.FullName);//如果有文件夹，则递归
                }
                else
                {
                    configPathNames.Add(item.Name);
                }
            }
        }

        private void UpdateParamFromForm(int channel)
        {
            #region 将当前参数记录到通道数组中
            AllChannels.m_Channels[channel].channelParam.analogGain = (uint)this.trackBarAnalogGain.Value;
            AllChannels.m_Channels[channel].channelParam.digitalGian = (uint)this.trackBarDigitalGian.Value;
            AllChannels.m_Channels[channel].channelParam.freqRatio = (uint)this.trackBarSignFreqRatio.Value;
            AllChannels.m_Channels[channel].channelParam.delayCount = (uint)this.trackBarSendCmdDelayCount.Value;
            AllChannels.m_Channels[channel].channelParam.pulNumber = (uint)this.trackBarPulNumber.Value;
            AllChannels.m_Channels[channel].channelParam.aveNumber = (uint)this.trackBarAveNumber.Value;
            AllChannels.m_Channels[channel].channelParam.fixNumber = (uint)this.trackBarFixNumber.Value;
            AllChannels.m_Channels[channel].channelParam.highVoltage = (uint)trackBarHighVoltage.Value;
            AllChannels.m_Channels[channel].channelParam.digital = (uint)trackBarDigital.Value;
            AllChannels.m_Channels[channel].channelParam.range = trackBarRange.Value;
            AllChannels.RepeatFreq = (uint)this.trackBarRepeatFreq.Value;
            #endregion
            AllChannels.RepeatFreq = (uint )this.trackBarRepeatFreq.Value;
            AllChannels.SoundSpeed = this.trackBarSoundSpeed.Value;
        }

        private void UpdateTrackBarFromParam(int iChan)
        {
            //更新滚动条数据
            this.trackBarAnalogGain.Value = (int)AllChannels.m_Channels[iChan].channelParam.analogGain;
            this.trackBarDigitalGian.Value = (int)AllChannels.m_Channels[iChan].channelParam.digitalGian;
            this.trackBarSignFreqRatio.Value = (int)AllChannels.m_Channels[iChan].channelParam.freqRatio;
            this.trackBarSendCmdDelayCount.Value = (int)AllChannels.m_Channels[iChan].channelParam.delayCount;
            this.trackBarPulNumber.Value = (int)AllChannels.m_Channels[iChan].channelParam.pulNumber;
            this.trackBarAveNumber.Value = (int)AllChannels.m_Channels[iChan].channelParam.aveNumber;
            this.trackBarFixNumber.Value = (int)AllChannels.m_Channels[iChan].channelParam.fixNumber;
            this.trackBarHighVoltage.Value = (int)AllChannels.m_Channels[iChan].channelParam.highVoltage;
            this.trackBarDigital.Value = (int)AllChannels.m_Channels[iChan].channelParam.digital;
            this.trackBarRange.Value = AllChannels.m_Channels[iChan].channelParam.range;
            this.trackBarRepeatFreq.Value = (int)AllChannels.RepeatFreq;
            this.trackBarSoundSpeed.Value = (int)AllChannels.SoundSpeed;
        }

        private void UpdateLableFromParam(int iChan)
        {
            //更新数据框显示
            this.textBoxDigitalGainValue.Text = (AllChannels.m_Channels[iChan].channelParam.digitalGian / 10).ToString();
            this.textBoxAnalogGainValue.Text = (AllChannels.m_Channels[iChan].channelParam.analogGain / 10).ToString();
            this.textBoxRange.Text = AllChannels.m_Channels[iChan].channelParam.range.ToString();
            this.textBoxSignFreqRatio.Text = (AllChannels.m_Channels[iChan].channelParam.freqRatio / 10).ToString();
            this.textBoxDelayCount.Text = AllChannels.m_Channels[iChan].channelParam.delayCount.ToString();
            this.textBoxPulNumber.Text = (AllChannels.m_Channels[iChan].channelParam.pulNumber + 1).ToString();
            this.textBoxAveNumber.Text = Math.Pow(2, (double)(AllChannels.m_Channels[iChan].channelParam.aveNumber)).ToString();
            this.textBoxFixNumber.Text = (AllChannels.m_Channels[iChan].channelParam.fixNumber + 1).ToString();
            this.textBoxHighVoltage.Text = (300 + 50 * AllChannels.m_Channels[iChan].channelParam.highVoltage).ToString();
            this.textBoxDigital.Text = AllChannels.m_Channels[iChan].channelParam.digital.ToString();
            switch (AllChannels.RepeatFreq.ToString())
            {
                case "0":
                    this.textBoxRepeatFreq.Text = "15";
                    break;
                case "1":
                    this.textBoxRepeatFreq.Text = "50";
                    break;
                case "2":
                    this.textBoxRepeatFreq.Text = "100";
                    break;
                case "3":
                    this.textBoxRepeatFreq.Text = "200";
                    break;
                case "4":
                    this.textBoxRepeatFreq.Text = "500";
                    break;
            }
            this.textBoxSoundSpeed.Text = AllChannels.SoundSpeed.ToString();
        }


        #endregion

        #region 窗体加载与关闭事件
        private void ParamSetForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(configPath))//创建配置文件夹
            {
                Directory.CreateDirectory(configPath);
            }
            if (!File.Exists(configPath + "configInfo"))//如果没有配置文件，创建一个初始的配置文件
            {
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    UpdateParamFromForm(i);
                    AllForms.m_GageForm.UpdateGageInfoFormForm(i);
                }
                try
                {
                    AllChannelsSet.SaveParamToXml(configPath+"configInfo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            AllChannelsSet.UpdateParamFromXml(configPath + "configInfo");//从配置中读取参数
            UpdateTrackBarFromParam(currChanNum);//初始化参数显示
            UpdateLableFromParam(currChanNum);
            for (int i = 0; i < HSD_EMAT.totalGageNum; i++)
            {
                AllForms.m_GageForm.UpdateGageForm(i);
            }
            AllForms.m_GageForm.UpdateGageForm(currChanNum);
            AllChannelsSet.UpDateSysAllParam();
        }

        private void ParamSetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                AllChannelsSet.SaveParamToXml(configPath + "configInfo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void trackBarDataProcess_Scroll(object sender, EventArgs e)
        {
            double[] data = new double[300];
            Array.ConstrainedCopy(AllForms.m_MainForm.readDataBuf, (this.trackBarDataProcess.Value - 1) * 300, data, 0,300);
            AllForms.m_WaveForms[0].DrawLine(data);
        }


    }
}
