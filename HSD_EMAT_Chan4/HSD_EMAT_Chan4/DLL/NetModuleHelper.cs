using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HSD_EMAT_Chan4.Models;

namespace HSD_EMAT_Chan4.DLL
{
    public static class NetModuleHelper
    {
        static public  int connectStatus; 

        /// <summary>
        /// 创建连接
        /// </summary>
        public static  void  NetModuleConnect()
        {
            if (!NetModulDll.InitModule((uint)HSD_EMAT.totalChannelNum, (uint)HSD_EMAT.boardNum) || !NetModulDll.CreateHostSocket())
            {
                connectStatus = -1;
                return;
            };
            Thread thread = new Thread(() =>
              {
                  if (NetModulDll.GetConnectStatus(ref HSD_EMAT.pConnectNo))
                  {
                      connectStatus = 1;
                  }
              });
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// 初始化系统
        /// </summary>
        /// <returns></returns>
        public static bool SystemInit()
        {
            if (AllForms.m_WaveForms == null || AlllChannels.m_ChannelParams == null || AlllChannels.m_Channels == null)
            {
                return false;
            }
            NetModulDll.MyInitParam();
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                DLL.NetModulDll.MyBindingData(i);
            }
            return true;
        }

        public static void StartSampling()
        {
            DLL.NetModulDll.SendCmdSampleStart();
        }

        public static void ReadData(Channel channel)
        {
            if (channel == null)
            {
                return;
            }
            NetModulDll.SendCmdCurrentChan(channel.channeParam.channelNum);
            NetModulDll.MyReadData(channel.wavaData, channel.channeParam.channelNum, 1);
            NetModulDll.MyReadOridata(channel.oriWaveData, channel.channeParam.channelNum);
        }

        public static void SeverStop()
        {
            NetModulDll.SendCmdServerClose();
        }
    }
}
