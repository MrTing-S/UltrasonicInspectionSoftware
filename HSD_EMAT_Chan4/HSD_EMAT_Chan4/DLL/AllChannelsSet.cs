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
        public static void InitChannel()
        {
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                AllChannels.m_Channels[i] = new Channel
                {
                    channelGage = new Gage[HSD_EMAT.totalChannelNum],
                    channelParam = new ChannelParam(),
                    oriWaveData = new byte[2000],
                    wavaData = new ushort[300],
                    troughWaveData = new ushort[300]
                };
            }
        }

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

        public  static void SaveParamToXml(string filePath)
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
            }
            xmlDoc.Save(filePath);//如果文件存在会直接覆盖
        }

        private static  void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }
    }
}
