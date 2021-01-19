namespace FormTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Threading;
    public partial class Form1 : Form
    {
        ushort pConnectNo = 2;//客户端连接数目
        int[,] dataInfoWaveCrest = new int[4,300];//动态波形数组
        int[,] dataInfoWaveTrough = new int[4, 300];//波谷数组


        double[] data;
        public Form1()
        {
            InitializeComponent();
            this.chartControl1.ChartInit();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)(this));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";//读取皮肤文件路径
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            data = new double[1000];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.NextDouble() * 50 + 50;
            }
            this.chartControl1.ChartData = data;
            this.chartControl1.DrawLine();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int outPutnum=0;
            int[,] a = new int[3,4];
            a[2, 3] = 2;
            a[0, 0] = 3;
            try
            {
                unsafe
                {
                    fixed (int* ap = a)
                    {
                        int*[] arr = new int*[3];
                        for (int i = 0; i < 3; i++)
                        {
                            arr[i] = ap + i * 4;
                        }
                        outPutnum = DLL.NetModulDll.dllname(arr, 3, 4);
                        Console.WriteLine(*(arr[2]+3));
                    }
                }
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);;
            }

            //ushort m_value = 7;
            //Console.WriteLine(DLL.NetModulDll.dllNamePointer(ref m_value));
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            //开启一个线程等待初始化过程
            Thread threadInit = new Thread(() =>
              {
                  Console.WriteLine("InitModule运行：" + DLL.NetModulDll.InitModule(4, 1).ToString());
                  Console.WriteLine("CreateHostSocket运行:" + DLL.NetModulDll.CreateHostSocket().ToString());
                  Console.WriteLine("获取连接状态中...");
                  Console.WriteLine("GetConnectStatus运行:" + DLL.NetModulDll.GetConnectStatus(ref pConnectNo).ToString());
              }
              );
            threadInit.IsBackground = true;
            threadInit.Start();
        }

        private void btnChnnelConfig_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                DLL.NetModulDll.SendCmdCurrentChan(i+1); //设置当前通道数
                DLL.NetModulDll.SendCmdSignFreqRatio(5);//设置信号频率
                DLL.NetModulDll.SendCmdDelayCount(0);//设置延时计数
                DLL.NetModulDll.SendCmdHighVoltage(5);//设置电压调节
                DLL.NetModulDll.SendCmdDigital(1);//设置数字抑制
                DLL.NetModulDll.SendCmdWaveType(0);//设置检波方式
                DLL.NetModulDll.SendCmdDB1(40);//设置当前通道1增益
                DLL.NetModulDll.SendCmdDB2(40);//设置当前通道2增益
                DLL.NetModulDll.SendCmdPulNumber(1);//设置脉冲个数
                DLL.NetModulDll.SendCmdAveNumber(2);//设置通道平均次数
                DLL.NetModulDll.SendCmdFixNumber(1);//设置相关次数
            }
        }

        private void btnGlobalConfig_Click(object sender, EventArgs e)
        {
            Thread threadGlobalConfig = new Thread(()=> {
                DLL.NetModulDll.SendCmdRepeatFreq(2);//设置重复频率
                DLL.NetModulDll.SendCmdPhaseCompose(0);//设置相控合成开关
                DLL.NetModulDll.SendCmdSampleDepth(30); 
            });
            threadGlobalConfig.IsBackground = true;
            threadGlobalConfig.Start();
        }

        private void btnStartCollect_Click(object sender, EventArgs e)
        {
            Thread threadReadBuffer = new Thread(() =>
            {
                //DLL.NetModulDll.SendCmdCurrentChan(1);//设置当前通道
                DLL.NetModulDll.SendCmdMainIP();
                #region 收发消息
                try
                {
                    unsafe
                    {
                        fixed (int* dataInfoWaveCrestPoint = dataInfoWaveCrest)
                        {
                            fixed (int* dataInfoWaveTroughPoint = dataInfoWaveTrough)
                            {
                                int*[] dataInfoPointWaveCrestDimTwo = new int*[4];
                                for (int i = 0; i < 4; i++)
                                {
                                    dataInfoPointWaveCrestDimTwo[i] = dataInfoWaveCrestPoint + i * 300;
                                }

                                int*[] dataInfoPointWaveTroughDimTwo = new int*[4];
                                for (int i = 0; i < 4; i++)
                                {
                                    dataInfoPointWaveTroughDimTwo[i] = dataInfoWaveTroughPoint + i * 300;
                                }
                                DLL.NetModulDll.RealWave(1, dataInfoPointWaveCrestDimTwo, dataInfoPointWaveTroughDimTwo);//读取波形
                                Console.WriteLine(*(dataInfoPointWaveTroughDimTwo[0] + 150));
                            }
                        }
                    }
                }
                catch (Exception message)
                {
                    MessageBox.Show(message.Message); ;
                }
                #endregion
                DLL.NetModulDll.SendCmdSampleStart();
            });
            threadReadBuffer.IsBackground = true;
            threadReadBuffer.Start();
        }

        private void btnCheckAdmRight_Click(object sender, EventArgs e)
        {
            if (DLL.FireWallHandle.IsAdministrator())
            {
                Console.WriteLine("已授权管理员权限");
            }
            else
            {
                Console.WriteLine("未授权管理员权限");
            }
        }

        private void btnFireWallClose_Click(object sender, EventArgs e)
        {
            if (DLL.FireWallHandle.FirewallOperateByObject(false, false, false))
            {
                Console.WriteLine("防火墙已关闭");
            }
            else
            {
                Console.WriteLine("防火墙关闭失败");
            }
        }

        private void btnOpenFireWall_Click(object sender, EventArgs e)
        {
            if (DLL.FireWallHandle.FirewallOperateByObject())
            {
                Console.WriteLine("防火墙已开启");
            }
            else
            {
                Console.WriteLine("防火墙开启失败");
            }
        }

    }
}
