namespace HSD_EMAT_Chan4.Models
{
    public class ChannelParam
    {
        public int channelNum;//通道数
        public uint digitalGian;
        public uint analogGain;
        public uint freqRatio;//发射频率
        public uint repeatFreq;//重复频率
        public uint delayCount;
        public uint pulNumber;
        public uint aveNumber;
        public uint fixNumber;//相关次数
        public uint highVoltage;//高压调节
        public uint digital;//数字抑制
        public int range;
        public WaveType waveType;
        public DataType dataType;

        /// <summary>
        /// 检波方式1_4:正检波，负检波，全检波，射频波
        /// </summary>
        public enum WaveType
        {
            type1, type2, type3, type4
        }

        /// <summary>
        /// 数据类型，对应采样后的数据或者原始数据
        /// </summary>
        public  enum DataType
        { 
            data, oriData
        }
    }
}
