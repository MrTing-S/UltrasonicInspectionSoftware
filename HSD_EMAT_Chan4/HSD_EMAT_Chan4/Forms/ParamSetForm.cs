namespace HSD_EMAT_Chan4.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Xml;
    using HSD_EMAT_Chan4.Models;

    public partial class ParamSetForm : Form
    {
        private int ChanNum = 0;//当前窗口设置的参数信息
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
        private void trackBarRange_Scroll(object sender, System.EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(ChanNum);
            DLL.NetModulDll.setRange(this.trackBarRange.Value);
            this.textBoxRange.Text = this.trackBarRange.Value.ToString();
        }

        private void trackBar_Scroll(object sender, System.EventArgs e)//通用的滚动条参数数据
        {
            DLL.NetModulDll.SendCmdCurrentChan(ChanNum);//设置当前通道
            TrackBar trackBar = (TrackBar)sender;
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
                case "tr4":
                    {
                        switch (trackBar.Value.ToString())
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
                        DLL.NetModulDll.SendCmdRepeatFreq((uint)trackBar.Value);
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
            }

        }

        #endregion

        #region 多选框事件
        private void comboBoxChanNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChanNum = this.comboBoxChanNum.SelectedIndex;
            AllForms.m_WaveForms[ChanNum].Focus();
        }

        private void comboBoxWaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(ChanNum);
            DLL.NetModulDll.SendCmdWaveType((uint)this.comboBoxWaveType.SelectedIndex);
        }

        private void comboBoxDataTpye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxDataTpye.SelectedIndex == 0)
            {
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    AllForms.m_WaveForms[i].chartControl1.ChartXSizeZoomIn(300);
                }
            }

            if (this.comboBoxDataTpye.SelectedIndex == 1)
            {
                for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
                {
                    AllForms.m_WaveForms[i].chartControl1.ChartXSizeZoomIn(2000);
                }
            }
        }

        #endregion 

        private void  UpDateParam(Channel channel)
        {
            
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {

        }

        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }

        private void SaveParamToXml()
        {
            //保存窗口数据到xml文件中
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = xmlDoc.CreateElement("ConfigInfo");
            xmlDoc.AppendChild(root);
            CreateNode(xmlDoc, root, "filename", objDataSet.fileName);
            CreateNode(xmlDoc, root, "data1", objDataSet.data1.ToString());
            CreateNode(xmlDoc, root, "data2", objDataSet.data2.ToString());
            CreateNode(xmlDoc, root, "data3", objDataSet.data3.ToString());
            CreateNode(xmlDoc, root, "data4", objDataSet.data4.ToString());
            CreateNode(xmlDoc, root, "selectIndex", objDataSet.selectIndex.ToString());

            try
            {
                string filePath = configPath + objDataSet.fileName;
                xmlDoc.Save(filePath);//如果文件存在会直接覆盖
                MessageBox.Show("保存成功");
            }
            catch (Exception error)
            {
                //显示错误信息  
                Console.WriteLine(error.Message);
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
                    repeatFreq = (uint)this.trackBarRepeatFreq.Value,
                    delayCount = (uint)this.trackBarSendCmdDelayCount.Value,
                    pulNumber = (uint)this.trackBarPulNumber.Value,
                    aveNumber = (uint)this.trackBarAveNumber.Value,
                    fixNumber = (uint)this.trackBarFixNumber.Value,
                    highVoltage = (uint)trackBarHighVoltage.Value,
                    digital = (uint)trackBarDigital.Value
                };
            #endregion
        }

        private void UpdateTrackBarValueFromParam(int iChan)
        {
            this.trackBarAnalogGain.Value = (int)currChannelParam[iChan].analogGain;
            this.trackBarDigitalGian.Value = (int)currChannelParam[iChan].digitalGian;
            this.trackBarSignFreqRatio.Value = (int)currChannelParam[iChan].freqRatio;
            this.trackBarRepeatFreq.Value = (int)currChannelParam[iChan].repeatFreq;
            this.trackBarSendCmdDelayCount.Value = (int)currChannelParam[iChan].delayCount;
            this.trackBarPulNumber.Value = (int)currChannelParam[iChan].pulNumber;
            this.trackBarAveNumber.Value = (int)currChannelParam[iChan].aveNumber;
            this.trackBarFixNumber.Value = (int)currChannelParam[iChan].fixNumber;
            this.trackBarHighVoltage.Value = (int)currChannelParam[iChan].highVoltage;
            this.trackBarDigital.Value = (int)currChannelParam[iChan].digital;
        }


    }
}
