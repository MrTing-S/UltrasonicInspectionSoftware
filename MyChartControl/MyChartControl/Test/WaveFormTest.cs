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
            waveChart.ChartYSizeZoomChange(256, 0);
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
            //isGageVisible = !isGageVisible;
            //this.waveChart.SetGageVisible(gageTpye, isGageVisible);
            double[] data = waveChart.GetGageData(gageTpye, waveChart.GetlineData());
            Console.WriteLine(data.Max());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopwatch.Restart();
            if (dataTpye == true)
            {
                if (waveChart.GetIsPointDataFulling())
                {
                    axielValueIndex++;
                    waveChart.SetAxisValue(CalcuAxielValue());
                }
                waveChart.DrawPoint(random.NextDouble() * 256);
            }
            else
            {
                axielValueIndex = 0;
                waveChart.SetAxisValue(CalcuAxielValue());
                for (int i = 0; i < drawData.Length; i++)
                {
                    drawData[i] = random.NextDouble() * 256;
                }
                waveChart.DrawLine(drawData);

            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
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
