using System;
using System.Collections;
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
    public partial class ScanFormTest : Form
    {
        double[] scanData;
        Stopwatch stopwatch;
        public ScanFormTest()
        {
            InitializeComponent();
            scanData = new double[300];
            this.scanChartControl.ChangeScanFormPiexlNum(300,150);
            this.scanChartControl.ChangeColorIndexScale(60,0);
            this.scanData = new double[300];
            this.scanChartControl.ChangeScanFormSize(600, 192);
            this.scanChartControl.UpdateAxielXValue(0,50);
            this.scanChartControl.UpdateAxielYValue(0, 10);
            stopwatch = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < scanData.Length; i++)
            {
                this.scanData[i] = random.NextDouble() * 50;
            }
            this.scanChartControl.AddData(this.scanData);
            stopwatch.Restart(); 
            this.scanChartControl.DrawScanView();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
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

        private void buttonTest_Click(object sender, EventArgs e)
        {
        }
    }
}
