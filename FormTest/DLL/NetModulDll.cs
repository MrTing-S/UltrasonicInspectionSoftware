using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace FormTest.DLL
{
    public class NetModulDll
    {
        #region 针对单通道函数

        /// <summary>
        /// 初始化模块①判断ChannelSum和BoardSum是否超过最大通道数和最大客户端数，超过则使用最大值;②初始化每个模块连接状态和客户端套接字;③初始化线程句柄，创建接收数据的线程;
        /// </summary>
        /// <param name="ChannelSun">通道数</param>
        /// <param name="BoardSum">客户端数</param>
        /// <returns>如何超过最大通道数与最大客户端数目则返回false</returns>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern bool InitModule(System.UInt32 ChannelSun, System.UInt32 BoardSum);

        /// <summary>
        /// 创建网络连接，本机IP:192.168.1.240 ①创建连接套接字，设置服务器地址信息，端口号为8080，绑定服务器地址和端口，对服务器的socket进行监听
        /// </summary>
        /// <returns>全部成功则返回true</returns>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern bool CreateHostSocket();

        /// <summary>
        ///  监听线程中调用，判断客户端与连接数目关系
        /// </summary>
        /// <param name="pConnectNo">最大模块数+1</param>
        /// <returns>pConnectNo大于0且小于最大客户端数，则进入主界面</returns>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern bool GetConnectStatus(ref ushort pConnectNo);

        /// <summary>
        /// 设置当前通道
        /// </summary>
        /// <param name="iChan">当前通道数</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdCurrentChan(int iChan);

        /// <summary>
        /// 设置信号频率
        /// </summary>
        /// <param name="uData">uData: 信号频率， range(4000000, 5500000)  界面显示单位MHz，值=uData/1000000;</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdSignFreqRatio(uint uData);

        /// <summary>
        /// 选频控制
        /// </summary>
        /// <param name="uData">选频控制range(0，4095)</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdFreqSelect(uint uData);

        /// <summary>
        /// 设置分频比
        /// </summary>
        /// <param name="uData">分频比 range（0，3）</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdFreqRatio(uint uData);

        /// <summary>
        /// 设置延迟计数
        /// </summary>
        /// <param name="uData">设置当前延时计数 range(0,10000)  界面显示单位us =uData/100</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdDelayCount(uint uData);

        /// <summary>
        /// 设置电压调节
        /// </summary>
        /// <param name="uData">电压 range(0，4) 分布代表300，350，400，450，500V</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdHighVoltage(uint uData);

        /// <summary>
        /// 设置继电器控制
        /// </summary>
        /// <param name="uData">uData=3 电压：300V,350V;uData=2 电压：400V,450V;uData=1 电压：500V,550V 600V,650V;uData=0 电压：700V,750V 800V;</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdRelay(uint uData);

        /// <summary>
        /// 设置数字抑制
        /// </summary>
        /// <param name="uData">当前通道数字抑制 range(0，100)</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdDigital(uint uData);

        /// <summary>
        /// 设置检波方式
        /// </summary>
        /// <param name="uData">当前通道检波方式 range(0,3) 分别表示正检波 负检波 全检波 射频波</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdWaveType(uint uData);

        /// <summary>
        /// 设置增益1控制
        /// </summary>
        /// <param name="uData">设置当前通道增益1，range(0,400) 界面单位dB ,值=uData/10;</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdDB1(uint uData);

        /// <summary>
        /// 设置增益2控制
        /// </summary>
        /// <param name="uData">设置当前通道增益2 UData: range(0,400) 界面单位dB ,值=uData/10;</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdDB2(uint uData);

        /// <summary>
        /// 设置脉冲个数
        /// </summary>
        /// <param name="uData">设置当前通道脉冲个数, range(0,3)  界面显示值=uData+1;</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdPulNumber(uint uData);

        /// <summary>
        /// 设置当前通道平均次数
        /// </summary>
        /// <param name="uData">当前通道平均次数 range(0,4); 界面显示值0-4分别表示1 , 2 , 4 , 8 , 16;</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdAveNumber(uint uData);

        /// <summary>
        /// 设置相关次数
        /// </summary>
        /// <param name="uData">设置当前通道相关次数 range(0,15); 界面显示值=uData+1;</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdFixNumber(uint uData);

        #endregion

        #region 针对多通道函数
        /// <summary>
        /// 设置重复频率
        /// </summary>
        /// <param name="u32Data">设置全局重复频率range(0,4)  0-4分别代表15Hz，50Hz，100Hz，200Hz，500Hz</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdRepeatFreq(uint u32Data);

        /// <summary>
        /// 设置相控合成开关
        /// </summary>
        /// <param name="uData">设置全局相控合成 0 关 1开;</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdPhaseCompose(uint uData);

        /// <summary>
        /// 设置采样深度
        /// </summary>
        /// <param name="iData">宏定义的固定值 设置全局采样深度 默认关闭</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdSampleDepth(int iData);

        /// <summary>
        /// 设置主卡板号
        /// </summary>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdMainIP();

        /// <summary>
        /// 开启采样
        /// </summary>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdSampleStart();

        /// <summary>
        /// 关闭采样
        /// </summary>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdSampleClose();

        /// <summary>
        /// 关闭服务器
        /// </summary>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void SendCmdServerClose();

        /// <summary>
        /// 当前通道压缩后波形图
        /// </summary>
        /// <param name="clientChan"></param>
        /// <param name="pWaveDataBuf">动态波形指针,unsigned short m_pChannelBuf[通道数][采样点数]</param>
        /// <param name="pWaveValueBuf">波谷指针  unsigned short m_pDestBuf[通道数][采样点数]</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static unsafe extern void RealWave(int clientChan, int*[] pWaveDataBuf, int*[] pWaveValueBuf);

        /// <summary>
        /// 获取原始波形
        /// </summary>
        /// <param name="clientChan"></param>
        /// <param name="pWaveDataBuf">动态波形指针  UCHAR	 piOriWave[通道数][采样点数];</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static unsafe extern void getOriWaveData(int clientChan, int*[] pWaveDataBuf);

        /// <summary>
        /// 设置速度
        /// </summary>
        /// <param name="value">range(3000,3500)</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void setSpeed(double value);

        /// <summary>
        /// 设置范围
        /// </summary>
        /// <param name="value">range(10,80)</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void setRange(int value);

        /// <summary>
        /// 设置测厚模式
        /// </summary>
        /// <param name="value">range(0,3)  0-常规测厚，1-一次波测厚，2-二次波测厚，3-自动</param>
        [DllImport("NetModulDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void setThickMode(int value);

        #endregion

        [DllImport("testDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern unsafe int dllname(int*[] a,int row,int column);

        [DllImport("testDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern unsafe int dllNamePointer(ref ushort a);
    }
}
