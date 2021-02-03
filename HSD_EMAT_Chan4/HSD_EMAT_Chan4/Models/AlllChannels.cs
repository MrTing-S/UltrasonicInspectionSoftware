using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSD_EMAT_Chan4.Models
{
    public static  class AlllChannels
    {
        public static Channel[] m_Channels=new Channel[HSD_EMAT.totalChannelNum];
        public static ChannelParam[] m_ChannelParams=new ChannelParam[HSD_EMAT.totalChannelNum];
    }
}
