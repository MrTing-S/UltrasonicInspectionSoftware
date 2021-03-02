namespace HSD_EMAT_Chan4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Channel
    {
        public ChannelParam channelParam;
        public Gage[] channelGage;
        public ushort[] wavaData ;//波形数据指针
        public ushort[] troughWaveData ;//波谷数据数组
        public byte[] oriWaveData ;//原始波形数组
    }
}
