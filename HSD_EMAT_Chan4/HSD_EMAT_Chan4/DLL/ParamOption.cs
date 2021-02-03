using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSD_EMAT_Chan4.Models;

namespace HSD_EMAT_Chan4.DLL
{
    public static  class ParamOption
    {
        static public  void BadingParams()
        {
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                AlllChannels.m_ChannelParams[i] = new ChannelParam();
                AlllChannels.m_Channels[i] = new Channel(AlllChannels.m_ChannelParams[i]);
            }
        }


    }
}
