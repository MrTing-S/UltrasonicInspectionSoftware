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
using System.Collections;

namespace MyChartControl.ScanChart
{
    public partial class ScanChartControl : UserControl
    {
        private Bitmap scanChartBitMap;
        private double[] scanViewData;
        private  ColorIndex colorIndex;
        private ScanChartView scanChartView;
        private Queue dataQueue;
        private int dataIndex;//扫描数据的索引
        private AxisValue axisXValue;//X轴刻度
        private AxisValue axisYValue;

        public ScanChartControl()
        {
            InitializeComponent();
            InitScanChart();
        }

        #region 初始化窗体函数
        private void InitScanChart()
        {
            this.dataIndex = 0;
            this.dataQueue = new Queue();
            this.scanChartView = new ScanChartView();
            scanChartBitMap = new Bitmap(scanChartView.xViewScale, scanChartView.yViewScale, PixelFormat.Format32bppRgb);
            this.colorIndex = new ColorIndex();
            if (scanChartView.ScanOrientation == Orientation.Horizontal)
            {
                scanViewData = new double[scanChartView.yViewScale];
            }
            if (scanChartView.ScanOrientation == Orientation.Vertical)
            {
                scanViewData = new double[scanChartView.xViewScale];
            }
            this.pictureBox.Image = scanChartBitMap;
            this.axisXValue = new AxisValue(5);
            this.axisXValue.lableWidth = 40;
            this.axisXValue.lableHeigh = 15;
            this.axisXValue.labels[0] = this.labelHMark1;
            this.axisXValue.labels[1] = this.labelHMark2;
            this.axisXValue.labels[2] = this.labelHMark3;
            this.axisXValue.labels[3] = this.labelHMark4;
            this.axisXValue.labels[4] = this.labelHMark5;

            this.axisYValue = new AxisValue(5);   
            this.axisYValue.lableWidth = 40;
            this.axisYValue.lableHeigh = 15;
            this.axisYValue.labels[0] = this.labelVMark1;
            this.axisYValue.labels[1] = this.labelVMark2;
            this.axisYValue.labels[2] = this.labelVMark3;
            this.axisYValue.labels[3] = this.labelVMark4;
            this.axisYValue.labels[4] = this.labelVMark5;

            ResetLocation();
        }

        private void ResetLocation()
        {
            this.pictureBox.Location = new Point(this.axisYValue.lableWidth, 0);
            axisXValue.hPosGap = this.pictureBox.Width / 4;
            axisXValue.vPosGap = 0;
            axisXValue.initPos = new Point(this.pictureBox.Location.X,this.pictureBox.Height);
            axisYValue.vPosGap = this.pictureBox.Height / 4;
            axisYValue.hPosGap = 0;
            axisYValue.initPos = new Point(0, this.pictureBox.Height);
            SetAxielValuePos(axisXValue);
            SetAxielValuePos(axisYValue);
        }
        //设置刻度的位置
        private void SetAxielValuePos(AxisValue axisValue)
        {
            for (int i = 0; i < axisValue.ValueNum; i++)
            {
                axisValue.labels[i].Location = new Point(axisValue.initPos.X+axisValue.hPosGap*i, axisValue.initPos.Y - axisValue.vPosGap*i);
            }
        }
        //设置刻度的数值
        private void SetAxielValue(AxisValue axisValue)
        {
            for (int i = 0; i < axisValue.ValueNum; i++)
            {
                axisValue.values[i] = axisValue.values[0] + axisValue.dataGap * i;
                axisValue.labels[i].Text = axisValue.values[i].ToString();
            }
        }
        private void ResetScanChart()
        {
            this.dataIndex = 0;
            this.dataQueue.Clear();
            scanChartBitMap = new Bitmap(scanChartView.xViewScale, scanChartView.yViewScale, PixelFormat.Format32bppRgb);
            if (scanChartView.ScanOrientation == Orientation.Horizontal)
            {
                scanViewData = new double[scanChartView.yViewScale];
            }
            if (scanChartView.ScanOrientation == Orientation.Vertical)
            {
                scanViewData = new double[scanChartView.xViewScale];
            }
            this.pictureBox.Image = scanChartBitMap;
        }
        #endregion

        #region 窗体绘制函数
        private void hDrawWholeFrame()
        {
            int index = 0;
            int[,] rgb = null;
            foreach (double[] item in dataQueue)
            {
                rgb = scanChartView.ValueToRGB(this.colorIndex, item);
                for (int i = 0; i < scanChartView.yViewScale; i++)
                {
                    this.scanChartBitMap.SetPixel(index, i, Color.FromArgb(rgb[i, 0], rgb[i, 1], rgb[i, 2]));
                }
                index++;
            }
            this.pictureBox.Image = this.scanChartBitMap;
        }

        private  void vDrawWholeFrame()
        {
            int index = 0;
            int[,] rgb = null;
            foreach (double[] item in dataQueue)
            {
                rgb = scanChartView.ValueToRGB(this.colorIndex, item);
                for (int i = 0; i < scanChartView.xViewScale; i++)
                {
                    this.scanChartBitMap.SetPixel(i, index, Color.FromArgb(rgb[i, 0], rgb[i, 1], rgb[i, 2]));
                }
                index++;
            }
            this.pictureBox.Image = this.scanChartBitMap;
        }

        private void DrawSingleColumn()
        {
            int[,] rgb = null;
            rgb = scanChartView.ValueToRGB(this.colorIndex,this.scanViewData);
            for (int i = 0; i < scanChartView.yViewScale; i++)
            {
                this.scanChartBitMap.SetPixel(this.dataIndex-1, i, Color.FromArgb(rgb[i, 0], rgb[i, 1], rgb[i, 2]));
            }
            this.pictureBox.Image = this.scanChartBitMap;
        }

        private void DrawSingleRow()
        {
            int[,] rgb = null;
            rgb = scanChartView.ValueToRGB(this.colorIndex, this.scanViewData);
            for (int i = 0; i < scanChartView.xViewScale; i++)
            {
                this.scanChartBitMap.SetPixel(this.dataIndex-1, i, Color.FromArgb(rgb[i, 0], rgb[i, 1], rgb[i, 2]));
            }
            this.pictureBox.Image = this.scanChartBitMap;
        }
        #endregion

        #region 公开函数
        public void ChangeScanFormSize(int width,int heigh)
        {
            this.Size = new Size(width ,heigh);
            this.pictureBox.Size = new Size(width-this.axisXValue.lableWidth*2,this.Height- this.axisYValue.lableHeigh);
            ResetLocation();
            this.Invalidate();
        }

        public void UpdateAxielXValue(double initValue,double gap)
        {
            this.axisXValue.values[0] = initValue;
            this.axisXValue.dataGap = gap;
            SetAxielValue(axisXValue);
        }

        public void UpdateAxielYValue(double initValue, double gap)
        {
            this.axisYValue.values[0] = initValue;
            this.axisYValue.dataGap = gap;
            SetAxielValue(axisYValue);
        }

        //绘制窗体
        public void DrawScanView()
        {
            if (this.scanChartView.ScanOrientation == Orientation.Horizontal)
            {
                if (this.dataIndex < this.scanChartView.xViewScale)
                {
                    this.DrawSingleColumn();
                }
                else
                {
                    this.hDrawWholeFrame();
                }
            }
            if (this.scanChartView.ScanOrientation == Orientation.Vertical)
            {
                if (this.dataIndex < this.scanChartView.xViewScale)
                {
                    this.DrawSingleRow();
                }
                else
                {
                    this.vDrawWholeFrame();
                }
            }
        }

        //改变颜色条索引
        public void ChangeColorIndexScale(int max, int min)
        {
            if (max <= min)
            {
                return;
            }
            this.colorIndex.MaxValue = max;
            this.colorIndex.MinValue = min;
        }

        //改变窗体像素点数目
        public void ChangeScanFormPiexlNum(int xPixel,int yPixel)
        {
            this.scanChartView.xViewScale = xPixel;
            this.scanChartView.yViewScale = yPixel;
            this.ResetScanChart();
        }

        //新增绘制数据
        public void AddData(double[] addData)
        {
            if (addData.Length >= this.scanViewData.Length)
            {
                Array.Copy(addData, this.scanViewData, this.scanViewData.Length);
            }
            else
            {
                Array.Copy(addData, this.scanViewData, addData.Length);
            }
            double[] dataTemp = new double[this.scanViewData.Length];
            Array.Copy(this.scanViewData, dataTemp, dataTemp.Length);
            if (this.scanChartView.ScanOrientation == Orientation.Horizontal)
            {
                if (this.dataIndex < this.scanChartView.xViewScale)
                {
                    this.dataIndex++;
                    this.dataQueue.Enqueue(dataTemp);
                }
                else
                {
                    this.dataQueue.Dequeue();
                    this.dataQueue.Enqueue(dataTemp);
                }
            }
            else if (this.scanChartView.ScanOrientation == Orientation.Vertical)
            {
                if (this.dataIndex < this.scanChartView.yViewScale)
                {
                    this.dataIndex++;
                    this.dataQueue.Enqueue(dataTemp);
                }
                else
                {
                    this.dataQueue.Dequeue();
                    this.dataQueue.Enqueue(dataTemp);
                }
            }
        }
        #endregion

        private void ScanChartControl_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
