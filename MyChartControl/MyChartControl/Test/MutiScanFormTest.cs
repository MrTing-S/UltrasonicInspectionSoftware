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
    public partial class MutiScanFormTest : Form
    {
        Random random;
        Stopwatch stopwatch;
        public MutiScanFormTest()
        {
            InitializeComponent();
            mutiWaveChart.ChartXSizeZoomChange(300);
            mutiWaveChart.ChartYSizeZoomChange(256,0);
            string[] lablex = {"通道一","通道二","通道三","通道四" };
            mutiWaveChart.SetAxisYValue(lablex);
            random = new Random();
            stopwatch = new Stopwatch();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            mutiWaveChart.Size = new Size( this.Width, mutiWaveChart.Size.Height);
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopwatch.Restart();
            for (int i = 0; i < 4; i++)
            {
                mutiWaveChart.DrawPointOfSingleChannel(GetData(), i);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private double[] GetData()
        {
            double[] data = new double[2];
            data[0] = random.NextDouble() * 255;
            data[1] = random.NextDouble() * 255;
            return data;
        }
    }
}
