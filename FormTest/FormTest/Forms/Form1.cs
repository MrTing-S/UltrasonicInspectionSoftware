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
        ushort pConnectNo = 4;//客户端连接数目
        ushort[] m_pChannelOneBuf = new ushort[300];//波形数据指针
        ushort[] m_pChannelOneValueBuf = new ushort[300];//波谷指针
        int[] m_pChannelOneOriBuf = new int[2000];
        ushort[] dataBuf = new ushort[300];//储存数组 
        double [] dataDraw = new double[300];//绘图数组 


        public Form1()
        {
            InitializeComponent();
            this.chartControl1.ChartInit();
            this.chartControl1.ChartXSizeZoomIn(300);
            this.chartControl1.ChartYSizeZoomIn(201,50);

            this.comboBoxWaveType.SelectedIndex = 3;

            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)(this));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";//读取皮肤文件路径
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            this.timer1.Start();

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                DLL.NetModulDll.MyReadData(dataBuf, 0,1);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }

        }

        internal static IntPtr ArrayToIntptr(byte[] source)
        {
            if (source == null)
                return IntPtr.Zero;
            unsafe
            {
                fixed (byte* point = source)
                {
                    IntPtr ptr = new IntPtr(point);
                    return ptr;
                }
            }
        }


        private void btnInit_Click(object sender, EventArgs e)
        {
            //开启一个线程等待初始化过程
            Thread threadInit = new Thread(() =>
              {
                  Console.WriteLine("InitModule运行：" + DLL.NetModulDll.InitModule(1,1).ToString());
                  Console.WriteLine("CreateHostSocket运行:" + DLL.NetModulDll.CreateHostSocket().ToString());
                  Console.WriteLine("获取连接状态中...");
                  Console.WriteLine("GetConnectStatus运行:" + DLL.NetModulDll.GetConnectStatus(ref pConnectNo).ToString());
                  DLL.NetModulDll.MyInitParam();
                  Console.WriteLine("参数下发完成");
                  DLL.NetModulDll.MyBindingData(0);
                  Console.WriteLine("通道1数据绑定完成");
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
            DLL.NetModulDll.SendCmdSampleStart();
        }
        private void butStopCollect_Click(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdSampleClose();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DLL.NetModulDll.MyReadData(dataBuf, 0, 1);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }

            for (int i = 0; i < 300; i++)
            {
                dataDraw[i] = Convert.ToDouble(dataBuf[i]);
            }
            this.chartControl1.ChartData =dataDraw;
            this.chartControl1.DrawLine();
        }

        private void btnSeverStop_Click(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdServerClose();
            Console.WriteLine("服务器已关闭");
        }

        private void trackBarDigitalGian_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            this.textBoxDigitalGainValue.Text = (this.trackBarDigitalGian.Value/10).ToString();
            DLL.NetModulDll.SendCmdDB1((uint)this.trackBarDigitalGian.Value);
        }

        private void trackBarAnalogGain_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            this.textBoxAnalogGainValue.Text = (this.trackBarAnalogGain.Value/10).ToString();
            DLL.NetModulDll.SendCmdDB2((uint)this.trackBarAnalogGain.Value);
        }

        private void trackBarSignFreqRatio_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            this.textBoxSignFreqRatio.Text = (Convert.ToDouble(this.trackBarSignFreqRatio.Value) / 10).ToString();
            DLL.NetModulDll.SendCmdSignFreqRatio((uint)this.trackBarSignFreqRatio.Value * 100000);
        }

        private void trackBarRepeatFreq_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdRepeatFreq((uint)this.trackBarRepeatFreq.Value);
            switch (this.trackBarRepeatFreq.Value.ToString())
            {
                case "0":
                    this.textBoxRepeatFreq.Text = "15Hz";
                    break;
                case "1":
                    this.textBoxRepeatFreq.Text = "50Hz";
                    break;
                case "2":
                    this.textBoxRepeatFreq.Text = "100Hz";
                    break;
                case "3":
                    this.textBoxRepeatFreq.Text = "200Hz";
                    break;
                case "4":
                    this.textBoxRepeatFreq.Text = "500Hz";
                    break;

            }

        }

        private void trackBarSendCmdDelayCount_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            DLL.NetModulDll.SendCmdDelayCount((uint)this.trackBarSendCmdDelayCount.Value*100);
            this.textBoxDelayCount.Text = this.trackBarSendCmdDelayCount.Value.ToString();
        }

        private void trackBarPulNumber_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            DLL.NetModulDll.SendCmdPulNumber((uint)(this.trackBarPulNumber.Value+1));
            this.textBoxPulNumber.Text = (this.trackBarPulNumber.Value+1).ToString();

        }

        private void trackBarAveNumber_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            DLL.NetModulDll.SendCmdAveNumber((uint)this.trackBarAveNumber.Value);
            this.textBoxAveNumber.Text = Math.Pow(2, (double)(this.trackBarAveNumber.Value)).ToString();
        }

        private void trackBarFixNumber_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            DLL.NetModulDll.SendCmdFixNumber((uint)this.trackBarFixNumber.Value);
            this.textBoxFixNumber.Text =(this.trackBarFixNumber.Value+1).ToString();
        }

        private void trackBarHighVoltage_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            DLL.NetModulDll.SendCmdHighVoltage((uint)this.trackBarHighVoltage.Value);
            this.textBoxHighVoltage.Text = (300+50*this.trackBarHighVoltage.Value ).ToString();
        }

        private void trackBarDigital_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            DLL.NetModulDll.SendCmdDigital((uint)(this.trackBarDigital.Value));
            this.textBoxDigital.Text = this.trackBarDigital.Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DLL.NetModulDll.SendCmdCurrentChan(0);
            DLL.NetModulDll.SendCmdWaveType((uint)this.comboBoxWaveType.SelectedIndex);
        }

        private void trackBarRange_Scroll(object sender, EventArgs e)
        {
            DLL.NetModulDll.setRange(this.trackBarRange.Value);
            this.textBoxRange.Text = this.trackBarRange.Value.ToString();
        }
    }
}
