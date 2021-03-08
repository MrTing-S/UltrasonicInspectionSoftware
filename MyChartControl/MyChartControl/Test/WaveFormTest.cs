using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class WaveFormTest : Form
    {
        Random random;
        Stopwatch stopwatch;
        bool dataTpye;
        double[] drawData;
        int axielValueIndex;
        MyChartControl.WaveChart.GageTpye gageTpye;
        GageInfo gageA;
        GageInfo gageB;
        bool isGageVisible;
        public WaveFormTest()
        {
            InitializeComponent();
            waveChart.ChartXSizeZoomChange(300);
            waveChart.ChartYSizeZoomChange(256, 100);
            waveChart.SetAxisValue(CalcuAxielValue());
            drawData = new double[300];
            random = new Random();
            stopwatch = new Stopwatch();
            axielValueIndex = 300;
            comboBoxGageType.SelectedIndex = 0;
            gageTpye = MyChartControl.WaveChart.GageTpye.GageA;
            gageA = new GageInfo { length = 5, point = new Point(20, 20) };
            gageB = new GageInfo { length = 5, point = new Point(50, 50) };
            isGageVisible = false;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ////闸门的显示与隐藏
            //isGageVisible = !isGageVisible;
            //this.waveChart.SetGageVisible(gageTpye, isGageVisible);

            ////返回闸门内的数据并提取最大值
            //double[] data = waveChart.GetGageData(gageTpye, waveChart.GetlineData());
            //Console.WriteLine(data.Max());

            ////测试窗体的大小控制功能
            //int windowBorderWidth = (this.Width - this.ClientRectangle.Width);//获取边框的宽度
            //int windowBorderHeight=(this .Height - this .ClientRectangle.Height);//获取边框的宽度
            //Console.WriteLine(windowBorderWidth.ToString() + " "+windowBorderHeight.ToString()) ;
            //this.waveChart.Location = new Point(0, 0);
            //this.waveChart.Size = new Size(this.Width- windowBorderWidth, this.Height - windowBorderHeight);

            this.waveChart.chart1.Series["Series1.2"].Points.AddY(510);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopwatch.Restart();
            if (waveChart.GetIsPointDataFulling())
            {
                axielValueIndex++;
                waveChart.SetAxisValue(CalcuAxielValue());
            }
            waveChart.DrawPoint(GetData());
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
        }

        private double[] GetData()
        {
            double[] data = new double[2];
            data[0] = random.NextDouble() * 255;
            data[1] = random.NextDouble() * 255;
            return data;
        }

        private void buttonChangeDataType_Click(object sender, EventArgs e)
        {
            if (dataTpye == true)
            {
                dataTpye = false;
            }
            else
            {
                dataTpye = true;
            }
        }

        private string[] CalcuAxielValue()
        {
            string[] texts = new string[5];
            for (int i = 0; i < texts.Length; i++)
            {
                texts[i] = (axielValueIndex + i * 300 / 4).ToString();
            }
            return texts;
        }

        private void comboBoxGageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxGageType.SelectedIndex == 0)
            {
                this.gageTpye = MyChartControl.WaveChart.GageTpye.GageA;
            }
            if (this.comboBoxGageType.SelectedIndex == 1)
            {
                this.gageTpye = MyChartControl.WaveChart.GageTpye.GageB;
            }
        }

        private void trackBarGageX_Scroll(object sender, EventArgs e)
        {
            if (comboBoxGageType.SelectedIndex == 0)
            {
                gageA.point.X = ((TrackBar)sender).Value;
                this.waveChart.SetGage(this.gageTpye, gageA.point, gageA.length);
            }
            if (comboBoxGageType.SelectedIndex == 1)
            {
                gageB.point.X = ((TrackBar)sender).Value;
                this.waveChart.SetGage(this.gageTpye, gageB.point, gageB.length);
            }
        }

        private void trackBarGageY_Scroll(object sender, EventArgs e)
        {
            if (comboBoxGageType.SelectedIndex == 0)
            {
                gageA.point.Y = ((TrackBar)sender).Value;
                this.waveChart.SetGage(this.gageTpye, gageA.point, gageA.length);
            }
            if (comboBoxGageType.SelectedIndex == 1)
            {
                gageB.point.Y = ((TrackBar)sender).Value;
                this.waveChart.SetGage(this.gageTpye, gageB.point, gageB.length);
            }

        }

        private void trackBarGageLength_Scroll(object sender, EventArgs e)
        {
            if (comboBoxGageType.SelectedIndex == 0)
            {
                gageA.length = ((TrackBar)sender).Value;
                this.waveChart.SetGage(this.gageTpye, gageA.point, gageA.length);
            }
            if (comboBoxGageType.SelectedIndex == 1)
            {
                gageB.length = ((TrackBar)sender).Value;
                this.waveChart.SetGage(this.gageTpye, gageB.point, gageB.length);
            }
        }

        class GageInfo
        {
            public int length;
            public Point point;
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
