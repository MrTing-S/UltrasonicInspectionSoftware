using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace MyChartControl
{
    public partial class ScanChartControl : UserControl
    {
        Bitmap scanChartBitMap;
        double [] ScanViewData;

        public ScanChartControl()
        {
            InitializeComponent();
            InitScanChart();
            this.pictureBox.Image = scanChartBitMap;


        }

        public void InitScanChart()
        {
            scanChartBitMap = new Bitmap(ScanChartView.xViewScale, ScanChartView.yViewScale, PixelFormat.Format32bppRgb);
        }

        /// <summary>
        /// 绘制图像中一列的伪彩色图
        /// </summary>
        /// <param name="data">绘制的数据</param>
        /// <param name="columnIndex">列索引</param>
        /// <param name="ColunmRange">绘制的列宽</param>
        public void DrawSingleColumn(double[] data, int columnIndex,int ColunmRange)
        {

            if (data.Length != ScanChartView.yViewScale)
            {
                return;
            }
            int[,] rgb = ValueToRGBIndex(data);
            for (int i1 = 0; i1 < ColunmRange; i1++)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    this.scanChartBitMap.SetPixel(columnIndex+i1, i, Color.FromArgb(rgb[i, 0], rgb[i, 1], rgb[i, 2]));
                }
            }
            //scanChartBitMap.Save("C:/Users/CYT/Desktop/1.JPG");
            this.pictureBox.Image = scanChartBitMap;
        }

        /// <summary>
        /// 将数值转换为颜色的映射
        /// </summary>
        /// <param name="value">被转化的数组</param>
        /// <returns></returns>
        public int[,] ValueToRGBIndex(double[] value)
        {
            double floatBetweenZeroAndOne;
            int[,]rgb =new int[value.Length,3];
            double valueMax= value.Max();
            if (value!=null||value.Length>0)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    floatBetweenZeroAndOne = value[i]/ valueMax;

                    if (floatBetweenZeroAndOne <= 0.5f)
                    {
                        floatBetweenZeroAndOne *= 2.0f;
                        rgb[i, 0] = (int)(255 * (1.0f - floatBetweenZeroAndOne) + 0.5f);
                        rgb[i, 1] = (int)(255 * (floatBetweenZeroAndOne) + 0.5f);
                    }
                    else
                    {
                        floatBetweenZeroAndOne = floatBetweenZeroAndOne * 2.0f - 1.0f;
                        rgb[i, 1] = (int)(255 * (1.0f - floatBetweenZeroAndOne) + 0.5f);
                        rgb[i, 2] = (int)(255 * (floatBetweenZeroAndOne) + 0.5f);
                    }
                }
                return rgb;
            }
            return null;
        }

        private void btnnTest_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ScanViewData = new double[1000];
            for (int i = 0; i < ScanViewData.Length; i++)
            {
                ScanViewData[i] = i;
            }
            DrawSingleColumn(ScanViewData,100,50);
            stopwatch.Stop();
            MessageBox.Show(stopwatch.ElapsedMilliseconds.ToString());
        }
    }
}
