using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSD_EMAT_Chan4.Models
{
    public static class AllChannels
    {
        public static Channel[] m_Channels = new Channel[HSD_EMAT.totalChannelNum];
        private static int repeatFreq=4;
        public static int RepeatFreq
        {
            get
            {
                return repeatFreq;
            }
            set
            {
                if (value <5&&value>0)
                {
                    repeatFreq = value;
                }
            }
        }
    }
}
