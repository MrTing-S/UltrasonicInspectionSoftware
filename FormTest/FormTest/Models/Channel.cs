namespace FormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Channel
    {
        public int channelNum;
        public ushort[] wavaData = new ushort[300];//波形数据指针
        public ushort[] troughWaveData = new ushort[300];//波谷数据数组
        public byte[] oriWaveData = new byte[2000];//原始波形数组
        public Channel(int ChanNum)
        {
            this.channelNum = ChanNum;
        }
    }
}
