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
        private static uint repeatFreq;
        public static uint RepeatFreq
        {
            get
            {
                return repeatFreq;
            }
            set
            {
                if (value < 5 && value > 0)
                {
                    repeatFreq = value;
                }
            }
        }

        private static int soundSpeed;
        public static int SoundSpeed
        {
            get 
            {
                return soundSpeed;
            }
            set
            {
                if (value > 1999 && value < 8001)
                {
                    soundSpeed = value;
                }
            }
        }
    }
}
