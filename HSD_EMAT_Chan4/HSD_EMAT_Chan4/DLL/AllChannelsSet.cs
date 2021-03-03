using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HSD_EMAT_Chan4.Models;

namespace HSD_EMAT_Chan4.DLL
{
    public static class AllChannelsSet
    {
        #region 初始化
        public static void InitChannel()
        {
            InitParam();
            InitGage();
        }

        private static void InitParam()
        {
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                AllChannels.m_Channels[i] = new Channel
                {
                    channelGage = new Gage[HSD_EMAT.totalGageNum],
                    channelParam = new ChannelParam
                    {
                        channelNum = i//绑定通道号
                    },
                    oriWaveData = new byte[2000],
                    wavaData = new ushort[300],
                    troughWaveData = new ushort[300]
                };

            }
        }

        private static void InitGage()
        {
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                for (int i1 = 0; i1 < HSD_EMAT.totalGageNum; i1++)
                {
                    AllChannels.m_Channels[i].channelGage[i1] = new Gage();
                }
                AllChannels.m_Channels[i].channelGage[0].gageTpye = MyChartControl.WaveChart.GageTpye.GageA;
                AllChannels.m_Channels[i].channelGage[1].gageTpye = MyChartControl.WaveChart.GageTpye.GageB;
            }
        }
        #endregion

        #region 加载参数
        //改变系统的参数设置
        public static  void UpDateSysParam(int iChan)
        {
            DLL.NetModulDll.SendCmdCurrentChan(iChan);
            DLL.NetModulDll.SendCmdDB1(AllChannels.m_Channels[iChan].channelParam.digitalGian);
            DLL.NetModulDll.SendCmdDB2(AllChannels.m_Channels[iChan].channelParam.analogGain);
            DLL.NetModulDll.SendCmdSignFreqRatio(AllChannels.m_Channels[iChan].channelParam.freqRatio * 100000);
            DLL.NetModulDll.SendCmdDelayCount(AllChannels.m_Channels[iChan].channelParam.delayCount * 100);
            DLL.NetModulDll.SendCmdPulNumber(AllChannels.m_Channels[iChan].channelParam.pulNumber + 1);
            DLL.NetModulDll.SendCmdAveNumber(AllChannels.m_Channels[iChan].channelParam.aveNumber);
            DLL.NetModulDll.SendCmdFixNumber(AllChannels.m_Channels[iChan].channelParam.fixNumber);
            DLL.NetModulDll.SendCmdHighVoltage(AllChannels.m_Channels[iChan].channelParam.highVoltage);
            DLL.NetModulDll.SendCmdDigital(AllChannels.m_Channels[iChan].channelParam.digital);
            DLL.NetModulDll.setRange(AllChannels.m_Channels[iChan].channelParam.range);
            DLL.NetModulDll.SendCmdRepeatFreq((uint)AllChannels.RepeatFreq);
        }

        //改变系统参数
        public static void UpdateParamFromXml(string xmlFilePath)
        {
            //初始化一个xml实例
            XmlDocument myXmlDoc = new XmlDocument();
            //加载xml文件（参数为xml文件的路径）
            myXmlDoc.Load(xmlFilePath);
            //获得第一个姓名匹配的节点（SelectSingleNode）：此xml文件的根节点
            XmlNode topRootNode = myXmlDoc.SelectSingleNode("configInfo");
            XmlNode rootNode;
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                #region
                rootNode = topRootNode.SelectSingleNode("channel" + i.ToString());
                AllChannels.m_Channels[i].channelParam.analogGain = Convert.ToUInt32(rootNode.SelectSingleNode("analogGain").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.digitalGian = Convert.ToUInt32(rootNode.SelectSingleNode("digitalGian").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.freqRatio = Convert.ToUInt32(rootNode.SelectSingleNode("freqRatio").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.delayCount = Convert.ToUInt32(rootNode.SelectSingleNode("delayCount").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.pulNumber = Convert.ToUInt32(rootNode.SelectSingleNode("pulNumber").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.aveNumber = Convert.ToUInt32(rootNode.SelectSingleNode("aveNumber").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.fixNumber = Convert.ToUInt32(rootNode.SelectSingleNode("fixNumber").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.highVoltage = Convert.ToUInt32(rootNode.SelectSingleNode("highVoltage").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.digital = Convert.ToUInt32(rootNode.SelectSingleNode("digital").FirstChild.InnerText);
                AllChannels.m_Channels[i].channelParam.range = Convert.ToInt32(rootNode.SelectSingleNode("range").FirstChild.InnerText);
                #endregion

                #region 通道闸门
                for (int i1 = 0; i1 < HSD_EMAT.totalGageNum; i1++)
                {
                    AllChannels.m_Channels[i].channelGage[i1].InitIndexX = Convert.ToInt32(rootNode.SelectSingleNode("InitIndexX" + i1.ToString()).FirstChild.InnerText);
                    AllChannels.m_Channels[i].channelGage[i1].InitIndexY = Convert.ToInt32(rootNode.SelectSingleNode("InitIndexY" + i1.ToString()).FirstChild.InnerText);
                    AllChannels.m_Channels[i].channelGage[i1].IndexLength = Convert.ToInt32(rootNode.SelectSingleNode("IndexLength" + i1.ToString()).FirstChild.InnerText);
                }
                #endregion
            }
        }
        #endregion

        #region 保存参数
        public static void SaveParamToXml(string filePath)
        {
            //保存窗口数据到xml文件中
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode rootFileName = xmlDoc.CreateElement("configInfo");
            xmlDoc.AppendChild(rootFileName);
            CreateNode(xmlDoc, rootFileName, "fileName", filePath .Substring(filePath.LastIndexOf("\\")+1));

            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                XmlNode root = xmlDoc.CreateElement("channel" + i.ToString());
                xmlDoc.DocumentElement.AppendChild(root);
                #region 通道参数
                CreateNode(xmlDoc, root, "analogGain", AllChannels.m_Channels[i].channelParam.analogGain.ToString());
                CreateNode(xmlDoc, root, "digitalGian", AllChannels.m_Channels[i].channelParam.digitalGian.ToString());
                CreateNode(xmlDoc, root, "freqRatio", AllChannels.m_Channels[i].channelParam.freqRatio.ToString());
                CreateNode(xmlDoc, root, "delayCount", AllChannels.m_Channels[i].channelParam.delayCount.ToString());
                CreateNode(xmlDoc, root, "pulNumber", AllChannels.m_Channels[i].channelParam.pulNumber.ToString());
                CreateNode(xmlDoc, root, "aveNumber", AllChannels.m_Channels[i].channelParam.aveNumber.ToString());
                CreateNode(xmlDoc, root, "fixNumber", AllChannels.m_Channels[i].channelParam.fixNumber.ToString());
                CreateNode(xmlDoc, root, "highVoltage", AllChannels.m_Channels[i].channelParam.highVoltage.ToString());
                CreateNode(xmlDoc, root, "digital", AllChannels.m_Channels[i].channelParam.digital.ToString());
                CreateNode(xmlDoc, root, "range", AllChannels.m_Channels[i].channelParam.range.ToString());

                CreateNode(xmlDoc, root, "RepeatFreq", AllChannels.RepeatFreq.ToString());
                #endregion

                #region 通道闸门
                for (int i1 = 0; i1 < HSD_EMAT.totalGageNum; i1++)
                {
                    CreateNode(xmlDoc, root, "InitIndexX" + i1.ToString(), AllChannels.m_Channels[i].channelGage[i1].InitIndexX.ToString());
                    CreateNode(xmlDoc, root, "InitIndexY" + i1.ToString(), AllChannels.m_Channels[i].channelGage[i1].InitIndexY.ToString());
                    CreateNode(xmlDoc, root, "IndexLength" + i1.ToString(), AllChannels.m_Channels[i].channelGage[i1].IndexLength.ToString());
                }
                #endregion
            }
            xmlDoc.Save(filePath);//如果文件存在会直接覆盖
        }

        private static  void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }
        #endregion
    }
}
