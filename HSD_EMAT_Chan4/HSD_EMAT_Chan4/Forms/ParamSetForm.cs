 namespace HSD_EMAT_Chan4.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml;
    using HSD_EMAT_Chan4.Models;

    public partial class ParamSetForm : Form
    {
        private int currChanNum = 0;//当前窗口设置的参数信息
        private ChannelParam[] currChannelParam=new ChannelParam[HSD_EMAT.totalChannelNum];//当前的参数信息
        private string configPath = Application.StartupPath + "\\ConfigFile\\";//config文件的地址
        List<string> configPathNames = new List<string>();//默认最大目录数目不超过50个

        public ParamSetForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            switch (trackBarRepeatFreq.Value.ToString())
            {
                case "0":
                    this.textBoxRepeatFreq.Text = "15Hz";
                    break;
                case "1":
                    this.textBoxRepeatFreq.Text = "50Hz";
                    break;
                case "2":
                    this.textBoxRepeatFreq.Text = "100Hz";
                    break;
                case "3":
                    this.textBoxRepeatFreq.Text = "200Hz";
                    break;
                case "4":
                    this.textBoxRepeatFreq.Text = "500Hz";
                    break;
            }
            DLL.NetModulDll.SendCmdRepeatFreq((uint)trackBarRepeatFreq.Value);
        }
        #endregion

        #region 多选框事件
        private void comboBoxChanNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currChanNum = this.comboBoxChanNum.SelectedIndex;
            UpdateTrackBarFromParam(currChanNum);
            UpdateLableFromParam(currChanNum);
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
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    AllForms.m_WaveForms[i].waveChart.ChartXSizeZoomChange(300);
                }
            }
            if (this.comboBoxDataTpye.SelectedIndex == 1)
            {
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    AllForms.m_WaveForms[i].waveChart.ChartXSizeZoomChange(2000);
                }
            }
        }
        #endregion

        #region 配置操作按钮事件

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            ConfigFileSaveForm configFileSaveForm = new ConfigFileSaveForm();
            configFileSaveForm.ShowDialog();
            UpdateParamFromForm(currChanNum);
            if (configFileSaveForm.DialogResult == DialogResult.OK)
            {
                if (configFileSaveForm.fileName.Length == 0)
                {
                    MessageBox.Show("请输入配置文件名");
                    return;
                }
                else
                {
                    SaveParamToXml(configFileSaveForm.fileName);
                    MessageBox.Show("配置文件保存成功");
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
                SaveParamToXml("configInfo");//配置清空，重建默认配置
            }
            if (configFileLoadForm.DialogResult == DialogResult.Yes)
            {
                UpdateParamFromXml(configFileLoadForm.fileName);
                UpdateTrackBarFromParam(currChanNum);
                UpdateLableFromParam(currChanNum);
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    UpDateSysParam(i);
                }
            }
        }

        private void buttonLoadDefaultCnfig_Click(object sender, EventArgs e)
        {
            UpdateParamFromXml("configInfo");//从配置中读取参数
            UpdateTrackBarFromParam(currChanNum);
            UpdateLableFromParam(currChanNum);
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                UpDateSysParam(i);
            }
        }
        #endregion

        #region 读取与存储配置函数
        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }

        private void SaveParamToXml(string fileName)
        {
            //保存窗口数据到xml文件中
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode rootFileName = xmlDoc.CreateElement("configInfo");
            xmlDoc.AppendChild(rootFileName);
            CreateNode(xmlDoc, rootFileName, "fileName", fileName);

            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                XmlNode root = xmlDoc.CreateElement("channel"+i.ToString());
                xmlDoc.DocumentElement.AppendChild(root);
                CreateNode(xmlDoc, root, "analogGain", currChannelParam[i].analogGain.ToString());
                CreateNode(xmlDoc, root, "digitalGian", currChannelParam[i].digitalGian.ToString());
                CreateNode(xmlDoc, root, "freqRatio", currChannelParam[i].freqRatio.ToString());
                CreateNode(xmlDoc, root, "delayCount", currChannelParam[i].delayCount.ToString());
                CreateNode(xmlDoc, root, "pulNumber", currChannelParam[i].pulNumber.ToString());
                CreateNode(xmlDoc, root, "aveNumber", currChannelParam[i].aveNumber.ToString());
                CreateNode(xmlDoc, root, "fixNumber", currChannelParam[i].fixNumber.ToString());
                CreateNode(xmlDoc, root, "highVoltage", currChannelParam[i].highVoltage.ToString());
                CreateNode(xmlDoc, root, "digital", currChannelParam[i].digital.ToString());
                CreateNode(xmlDoc, root, "range", currChannelParam[i].range.ToString());
            }
            try
            {
                string filePath = configPath + fileName;
                xmlDoc.Save(filePath);//如果文件存在会直接覆盖
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message.ToString());
            }
        }

        private void UpdateParamFromXml(string xmlFilePath)
        {
            try
            {
                //初始化一个xml实例
                XmlDocument myXmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                myXmlDoc.Load(configPath+ xmlFilePath);
                //获得第一个姓名匹配的节点（SelectSingleNode）：此xml文件的根节点
                XmlNode topRootNode = myXmlDoc.SelectSingleNode("configInfo");
                XmlNode rootNode;
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    rootNode = topRootNode.SelectSingleNode("channel"+i.ToString());
                    currChannelParam[i].analogGain = Convert.ToUInt32(rootNode.SelectSingleNode("analogGain").FirstChild.InnerText);
                    currChannelParam[i].digitalGian = Convert.ToUInt32(rootNode.SelectSingleNode("digitalGian").FirstChild.InnerText);
                    currChannelParam[i].freqRatio=Convert.ToUInt32(rootNode.SelectSingleNode("freqRatio").FirstChild.InnerText);
                    currChannelParam[i].delayCount = Convert.ToUInt32(rootNode.SelectSingleNode("delayCount").FirstChild.InnerText);
                    currChannelParam[i].pulNumber = Convert.ToUInt32(rootNode.SelectSingleNode("pulNumber").FirstChild.InnerText);
                    currChannelParam[i].aveNumber = Convert.ToUInt32(rootNode.SelectSingleNode("aveNumber").FirstChild.InnerText);
                    currChannelParam[i].fixNumber = Convert.ToUInt32(rootNode.SelectSingleNode("fixNumber").FirstChild.InnerText);
                    currChannelParam[i].highVoltage = Convert.ToUInt32(rootNode.SelectSingleNode("highVoltage").FirstChild.InnerText);
                    currChannelParam[i].digital = Convert.ToUInt32(rootNode.SelectSingleNode("digital").FirstChild.InnerText);
                    currChannelParam[i].range  = Convert.ToInt32(rootNode.SelectSingleNode("range").FirstChild.InnerText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

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

        private void UpdateParamFromForm(int iChan)
        {
            #region 将当前参数记录到currChannelParam[]数组中
            currChannelParam[iChan] = new ChannelParam()
            {
                analogGain = (uint)this.trackBarAnalogGain.Value,
                digitalGian = (uint)this.trackBarDigitalGian.Value,
                freqRatio = (uint)this.trackBarSignFreqRatio.Value,
                delayCount = (uint)this.trackBarSendCmdDelayCount.Value,
                pulNumber = (uint)this.trackBarPulNumber.Value,
                aveNumber = (uint)this.trackBarAveNumber.Value,
                fixNumber = (uint)this.trackBarFixNumber.Value,
                highVoltage = (uint)trackBarHighVoltage.Value,
                digital = (uint)trackBarDigital.Value,
                range = trackBarRange.Value   
                };
            #endregion
        }

        private void UpdateTrackBarFromParam(int iChan)
        {
            //更新滚动条数据
            this.trackBarAnalogGain.Value = (int)currChannelParam[iChan].analogGain;
            this.trackBarDigitalGian.Value = (int)currChannelParam[iChan].digitalGian;
            this.trackBarSignFreqRatio.Value = (int)currChannelParam[iChan].freqRatio;
            this.trackBarSendCmdDelayCount.Value = (int)currChannelParam[iChan].delayCount;
            this.trackBarPulNumber.Value = (int)currChannelParam[iChan].pulNumber;
            this.trackBarAveNumber.Value = (int)currChannelParam[iChan].aveNumber;
            this.trackBarFixNumber.Value = (int)currChannelParam[iChan].fixNumber;
            this.trackBarHighVoltage.Value = (int)currChannelParam[iChan].highVoltage;
            this.trackBarDigital.Value = (int)currChannelParam[iChan].digital;
            this.trackBarRange.Value = currChannelParam[iChan].range;
        }

        private void UpdateLableFromParam(int iChan)
        { 
            //更新数据框显示
            this.textBoxDigitalGainValue.Text = (this.trackBarDigitalGian.Value / 10).ToString();
            this.textBoxAnalogGainValue.Text = (this.trackBarAnalogGain.Value / 10).ToString();
            this.textBoxRange.Text = this.trackBarRange.Value.ToString();
            this.textBoxSignFreqRatio.Text = (Convert.ToDouble(this.trackBarSignFreqRatio.Value) / 10).ToString();
            this.textBoxDelayCount.Text = this.trackBarSendCmdDelayCount.Value.ToString();
            this.textBoxPulNumber.Text = (this.trackBarPulNumber.Value + 1).ToString();
            this.textBoxAveNumber.Text = Math.Pow(2, (double)(this.trackBarAveNumber.Value)).ToString();
            this.textBoxFixNumber.Text = (this.trackBarFixNumber.Value + 1).ToString();
            this.textBoxHighVoltage.Text = (300 + 50 * this.trackBarHighVoltage.Value).ToString();
            this.textBoxDigital.Text = this.trackBarDigital.Value.ToString();
        }

        private void UpDateSysParam(int iChan)
        {
            DLL.NetModulDll.SendCmdCurrentChan(iChan);
            DLL.NetModulDll.SendCmdDB1(currChannelParam[iChan].digitalGian);
            DLL.NetModulDll.SendCmdDB2(currChannelParam[iChan].analogGain);
            DLL.NetModulDll.SendCmdSignFreqRatio(currChannelParam[iChan].freqRatio * 100000);
            DLL.NetModulDll.SendCmdDelayCount(currChannelParam[iChan].delayCount * 100);
            DLL.NetModulDll.SendCmdPulNumber(currChannelParam[iChan].pulNumber+1);
            DLL.NetModulDll.SendCmdAveNumber(currChannelParam[iChan].aveNumber);
            DLL.NetModulDll.SendCmdFixNumber(currChannelParam[iChan].fixNumber);
            DLL.NetModulDll.SendCmdHighVoltage(currChannelParam[iChan].highVoltage);
            DLL.NetModulDll.SendCmdDigital(currChannelParam[iChan].digital);
            DLL.NetModulDll.setRange(currChannelParam[iChan].range);
            DLL.NetModulDll.SendCmdRepeatFreq((uint)this.trackBarRepeatFreq.Value);
        }
        #endregion

        #region 窗体加载与关闭事件
        private void ParamSetForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                currChannelParam[i] = new ChannelParam();//初始化参数数组
            }
            if (!File.Exists(configPath))//创建配置文件夹
            {
                Directory.CreateDirectory(configPath);
            }
            if (!File.Exists(configPath + "configInfo"))//如果没有配置文件，创建一个初始的配置文件
            {
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    UpdateParamFromForm(i);
                }
                SaveParamToXml("configInfo");
            }
            UpdateParamFromXml("configInfo");//从配置中读取参数
            UpdateTrackBarFromParam(currChanNum);//初始化参数显示
            UpdateLableFromParam(currChanNum);
            UpDateSysParam(currChanNum);
        }

        private void ParamSetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateParamFromForm(currChanNum);
            SaveParamToXml("configInfo");//记录退出前的配置
        }
        #endregion

        private void trackBarDataProcess_Scroll(object sender, EventArgs e)
        {
            double[] data = new double[300];
            Array.ConstrainedCopy(AllForms.m_MainForm.readDataBuf, (this.trackBarDataProcess.Value - 1) * 300, data, 0,300);
            AllForms.m_WaveForms[0].waveChart.DrawLine(data);
        }

        private void trackBarGagePosX_Scroll(object sender, EventArgs e)
        {
            Gage gage = AllForms.m_MainForm.gageA;
            AllForms.m_MainForm.gageA.InitIndexX = this.trackBarGagePosX.Value;
            AllForms.m_WaveForms[0].waveChart.SetGage(gage.gageTpye, new Point(gage.InitIndexX, gage.InitIndexY), gage.IndexLength);
        }

        private void trackBarGagePosY_Scroll(object sender, EventArgs e)
        {
            Gage gage = AllForms.m_MainForm.gageA;
            AllForms.m_MainForm.gageA.InitIndexY = this.trackBarGagePosY.Value;
            AllForms.m_WaveForms[0].waveChart.SetGage(gage.gageTpye, new Point(gage.InitIndexX, gage.InitIndexY), gage.IndexLength);
        }

        private void trackBarGageLength_Scroll(object sender, EventArgs e)
        {
            Gage gage = AllForms.m_MainForm.gageA;
            AllForms.m_MainForm.gageA.IndexLength = this.trackBarGageLength.Value;
            AllForms.m_WaveForms[0].waveChart.SetGage(gage.gageTpye, new Point(gage.InitIndexX, gage.InitIndexY), gage.IndexLength);
        }
    }
}
