using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace MyChartControl.WaveChart
{
    public partial class WaveChartControl: UserControl
    {
        //绘图数据
        private ChartData chartData;
        //图表视图
        private WaveChartView chartView;
        //闸门
        private Gage[] allGage;
        private Gage gageA;
        private Gage gageB;
        //坐标轴数据
        private VAxisValue axisValue;

        bool isChartReady=false;

        /// <summary>
        /// 新建一个绘图窗体，默认为单通道波形曲线
        /// </summary>
        public WaveChartControl()
        {
            InitializeComponent();
            InitGage();
            InitAxisValue();
            InitChartData();
            InitChartView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waveOrScan">扫描曲线（true）</param>
        public WaveChartControl(bool isScanChart)
        {
            InitializeComponent();
            if (!isScanChart)
            {
                InitGage();
                InitAxisValue();
                InitChartData();
                InitChartView();
                return;
            }
            InitGage();
            InitAxisValue();
            InitChartData();
            InitChartView();
            chartView.waveChartTpye = WaveChartTpye.Point;
            SetGageVisible(GageTpye.GageA, false);
            SetGageVisible(GageTpye.GageB, false);
        }

        #region 内置函数

        #region 窗体初始化
        private void InitChartView()
        {
            chartView = new WaveChartView
            {
                waveChartTpye = WaveChartTpye.Line,
                axisXScale = 1000,
                axisXGridNum = 5,
                axisYUpScale = 500,
                axisYDownScale = -500,
                axisYGridNum = 4
            };
            SetChartView();
            ResetSize();
            ResetPos();
            this.isChartReady = true;
        }

        private void InitGage()
        {
            gageA = new Gage
            {
                gageTpye = GageTpye.GageA,
                Gagelength = 10,
                initPositionX = 70,
                initPositionY = 70,
                gageName = "Series2",
                visiable = true
            };
            gageB = new Gage
            {
                gageTpye = GageTpye.GageB,
                Gagelength = 10,
                initPositionX = 20,
                initPositionY = 20,
                gageName = "Series3",
                visiable = true
            };
            allGage = new Gage[2];
            allGage[0] = gageA;
            allGage[1] = gageB;
        }

        private void InitAxisValue()
        {
            this.axisValue = new VAxisValue(5);
            this.axisValue.lableWidth = 40;
            this.axisValue.lableHeigh = 15;
            this.axisValue.labels[0] = this.labelVMark1;
            this.axisValue.labels[1] = this.labelVMark2;
            this.axisValue.labels[2] = this.labelVMark3;
            this.axisValue.labels[3] = this.labelVMark4;
            this.axisValue.labels[4] = this.labelVMark5;
        }

        private void InitChartData()
        {
            this.chartData = new ChartData
            {
                isPointDataFull = false,
                pointValue = new double[2],
                lineData = new double[300],
                pointDataIndex = 0,
                pointDataQueue = new System.Collections.Queue(),
            };
        }

        #endregion

        #region 图表绘制

        //设置窗体显示
        private void SetChartView()
        {
            #region 设置ChartArea1绘图属性
            //设置图表坐标轴
            this.chart1.ChartAreas["ChartArea1"].AxisY.Minimum = chartView.axisYDownScale;//设置Y轴最小尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisY.Maximum = chartView.axisYUpScale;//设置Y轴最大尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisY.Interval = CalAxisGridValue((chartView.axisYUpScale- chartView.axisYDownScale), chartView.axisYDownScale, chartView.axisYGridNum);//设置Y轴间隔
            this.chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;//设置X轴最小尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum = chartView.axisXScale;//设置X轴最大尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = CalAxisGridValue(chartView.axisXScale, 0, chartView.axisXGridNum);//设置X轴间隔
            this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;//设置X轴栅格线颜色
            this.chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;//设置Y轴栅格线颜色
            this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;//设置X轴栅格线线粗
            this.chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 1;//设置Y轴栅格线线粗
            this.chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Interval = 10;
            this.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;//关闭刻度值显示
            this.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;//关闭刻度值显示
            //设置标题
            this.chart1.Titles["title1"].Text = chartView.title1;//设置标题内容
            this.chart1.Titles["title1"].ForeColor = Color.Green;//设置标题颜色
            this.chart1.Titles["title1"].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);//设置标题字体和大小
            this.chart1.Titles["title2"].Text = chartView.title2;//设置标题内容
            this.chart1.Titles["title2"].ForeColor = Color.RoyalBlue;//设置标题颜色
            this.chart1.Titles["title2"].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);//设置标题字体和大小
            //绘图曲线设置
            this.chart1.Series["Series1.1"].Color = Color.Green;//设置线条颜色
            this.chart1.Series["Series1.1"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series1.1"].ChartType = SeriesChartType.FastLine;//设置绘图模式
            this.chart1.Series["Series1.2"].Color = Color.Green;//设置线条颜色
            this.chart1.Series["Series1.2"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series1.2"].ChartType = SeriesChartType.FastLine;//设置绘图模式

            #endregion

            #region 设置ChartArea2绘图属性
            this.chart1.ChartAreas["ChartArea2"].AxisX.Minimum = 0;
            this.chart1.ChartAreas["ChartArea2"].AxisX.Maximum = 100;
            this.chart1.ChartAreas["ChartArea2"].AxisY.Minimum = 0;
            this.chart1.ChartAreas["ChartArea2"].AxisY.Maximum = 100;

            this.chart1.ChartAreas["ChartArea2"].AxisX.LabelStyle.Enabled = false;//关闭刻度值显示
            this.chart1.ChartAreas["ChartArea2"].AxisY.LabelStyle.Enabled = false;//关闭刻度值显示
            this.chart1.ChartAreas["ChartArea2"].AxisX.MajorGrid.Enabled = false;
            this.chart1.ChartAreas["ChartArea2"].AxisX.MinorGrid.Enabled = false;
            this.chart1.ChartAreas["ChartArea2"].AxisY.MajorGrid.Enabled = false;
            this.chart1.ChartAreas["ChartArea2"].AxisY.MinorGrid.Enabled = false;

            this.chart1.Series["Series2"].ChartType = SeriesChartType.FastLine;
            this.chart1.Series["Series3"].ChartType = SeriesChartType.FastLine;
            this.chart1.Series["Series2"].BorderWidth = 2;
            this.chart1.Series["Series3"].BorderWidth = 2;
            #endregion

            if (gageA.visiable == true)
            {
                DrawGate(gageA);
            }
            if (gageB.visiable == true)
            {
                DrawGate(gageB);
            }
        }

        //计算图表间隔值
        private double CalAxisGridValue(double axisYMaxValue, double axisYMinValue, int axisYGridNum)
        {
            double GridValue = (axisYMaxValue - axisYMinValue) / axisYGridNum;
            return GridValue;
        }

        #endregion

        #region 闸门绘制
        private void DrawGate(Gage gageInfo)
        {
            this.chart1.Series[gageInfo.gageName].Points.Clear();
            if (!gageInfo.visiable)
            {
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[gageInfo.gageName].Points.AddXY(gageInfo.initPositionX,gageInfo.initPositionY-5/2+i);
            }
            for (int i = 0; i < gageInfo.Gagelength+1; i++)
            {
                chart1.Series[gageInfo.gageName].Points.AddXY(gageInfo.initPositionX+i, gageInfo.initPositionY);
            }
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[gageInfo.gageName].Points.AddXY(gageInfo.initPositionX + gageInfo.Gagelength, gageInfo.initPositionY - 5/2 + i);
            }
        }
        #endregion

        #region 大小与位置调整
        private void ResetSize()
        {
            this.panel1.Size = new Size(this.Width, this.Height - axisValue.lableHeigh);
            this.chart1.Size = new Size(this.Width, this.Height - axisValue.lableHeigh);
            this.axisValue.initPos = new Point(0,this.chart1.Height);
            this.axisValue.vPosGap = (this.chart1.Size.Width - this.axisValue.lableWidth) / (this.axisValue.ValueNum-1);
        }

        private void ResetPos()
        {
            int x = this.axisValue.initPos.X;
            int y = this.axisValue.initPos.Y;
            int gap = this.axisValue.vPosGap;
            for (int i = 0; i < this.axisValue.ValueNum; i++)
            {
                this.axisValue.labels[i].Location = new Point(x + gap * i, y);
            }
            this.Invalidate();
        }

        private void WaveChartControl_Resize(object sender, EventArgs e)
        {
            if (isChartReady)
            {
                ResetSize();
                ResetPos();
            }
        }

        private void WaveChartControl_SizeChanged(object sender, EventArgs e)
        {
            if (isChartReady)
            {
                ResetSize();
                ResetPos();
            }
        }
        #endregion

        #endregion

        #region 公开函数

        #region 图表显示设置

        /// <summary>
        /// 设置Y轴的数据范围
        /// </summary>
        /// <param name="axisUpYplotScale">Y轴最大值</param>
        /// <param name="axisDownYplotScale">Y轴最小值</param>
        public void ChartYSizeZoomChange(int axisUpYplotScale, int axisDownYplotScale)
        {
            if (axisUpYplotScale <= axisDownYplotScale)
            {
                return;
            }
            if (chartView.waveChartTpye == WaveChartTpye.Line)
            {
                this.chartView.axisYUpScale = axisUpYplotScale;
                this.chartView.axisYDownScale = axisDownYplotScale;
                SetChartView();
            }
            else if (chartView.waveChartTpye == WaveChartTpye.Point)
            {
                this.chartView.axisYUpScale = axisUpYplotScale + (axisUpYplotScale - axisDownYplotScale);
                this.chartView.axisYDownScale = axisDownYplotScale;
                SetChartView();
            }

            this.chart1.Invalidate();//图像刷新
        }

        /// <summary>
        /// 设置X轴的数据范围
        /// </summary>
        /// <param name="axisXplotScale">X轴最大值</param>
        public void ChartXSizeZoomChange(int axisXplotScale)
        {
            this.chartView.axisXScale = axisXplotScale;
            double XIntervalValueTemp;//X方向栅格间距
            this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum = axisXplotScale;
            XIntervalValueTemp = CalAxisGridValue(this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum, this.chart1.ChartAreas["ChartArea1"].AxisX.Minimum, chartView.axisXGridNum);

            this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = XIntervalValueTemp;
            this.chart1.Invalidate();//图像刷新
        }
        #endregion

        #region 曲线绘制
        /// <summary>
        /// 绘制chartData中的数据
        /// </summary>
        public void DrawLine(double [] data)
        {
            if (this.chartView.waveChartTpye == WaveChartTpye.Point)
            {
                this.chartView.waveChartTpye = WaveChartTpye.Line;
                this.chartData.isPointDataFull = false;
            }
            if (data.Length >= this.chartData.lineData.Length)
            {
                Array.Copy(data, chartData.lineData, chartData.lineData.Length);
            }
            else
            {
                Array.Copy(data, chartData.lineData, data.Length);
            }
            if (chartData.lineData != null || chartData.lineData.Length  > 0)
            {
                this.chart1.Series["Series1.1"].Points.Clear();
                for (int pointIndex = 0; pointIndex < chartData.lineData.Length; pointIndex++)
                {
                    chart1.Series["Series1.1"].Points.AddY(chartData.lineData[pointIndex]);
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data">扫描点数组，索引0代表下方曲线</param>
        public void DrawPoint(double[] data)
        {
            if (data == null)
            {
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                if (data[i] > chartView.axisYUpScale)
                {
                    data[i] = chartView.axisYUpScale;
                }
                if (data[i] < chartView.axisYDownScale)
                {
                    data[i] = chartView.axisYDownScale;
                }
            }
            data[1] = data[1] + (chartView.axisYUpScale - chartView.axisYDownScale)/2;
            if (this.chartData.pointDataIndex == this.chartView.axisXScale)
            {
                this.chartData.pointDataQueue.Dequeue();
                this.chartData.pointDataQueue.Enqueue(data);
                this.chartData.isPointDataFull = true;
                chart1.Series["Series1.1"].Points.Clear();
                chart1.Series["Series1.2"].Points.Clear();
                foreach (double[] item in this.chartData.pointDataQueue)
                {
                    chart1.Series["Series1.1"].Points.AddY(item[0]);
                    chart1.Series["Series1.2"].Points.AddY(item[1]);
                }
            }
            else
            {
                this.chartData.pointDataIndex++;
                this.chartData.pointDataQueue.Enqueue(data);
                chart1.Series["Series1.1"].Points.AddY(data[0]);
                chart1.Series["Series1.2"].Points.AddY(data[1]);
            }
        }
        #endregion

        #region 坐标轴设置
        /// <summary>
        /// 改变坐标轴的内容索引
        /// </summary>
        /// <param name="texts">坐标轴内容字符串</param>
        public void SetAxisValue(string[] texts)
        {
            if (texts == null)
            {
                return;
            }
            if (texts.Length >= this.axisValue.ValueNum)
            {
                for (int i = 0; i < axisValue.ValueNum; i++)
                {
                    this.axisValue.labels[i].Text = texts[i];
                }
            }
            else
            {
                for (int i = 0; i < texts.Length; i++)
                {
                    this.axisValue.labels[i].Text = texts[i];
                }
            }
        }

        public bool GetIsPointDataFulling()
        {
            return this.chartData.isPointDataFull;
        }
        #endregion

        #region 闸门绘制

        /// <summary>
        /// 绘制闸门位置
        /// </summary>
        /// <param name="gageTpye">闸门类型</param>
        /// <param name="centerPoint">闸门中心点</param>
        /// <param name="gageLength">闸门长度</param>
        public void SetGage(GageTpye gageTpye, Point initPos, int gageLength)
        {
            foreach (Gage item in allGage)
            {
                if (item.gageTpye == gageTpye)
                {
                    item.initPositionX = initPos.X;
                    item.initPositionY = initPos.Y;
                    item.Gagelength = gageLength;
                }
                DrawGate(item);
            }
        }

        public void SetGageVisible(GageTpye gageTpye,bool isVisible)
        {
            foreach (Gage item in allGage)
            {
                if (item.gageTpye == gageTpye)
                {
                    item.visiable = isVisible;
                }
                DrawGate(item);
            }
        }

        /// <summary>
        /// 返回闸门范围内的数据
        /// </summary>
        /// <param name="gageTpye"></param>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public double  [] GetGageData(GageTpye gageTpye,double [] sourceArray)
        {
            Gage gage=new Gage();
            foreach (Gage item in allGage)
            {
                if (item.gageTpye == gageTpye)
                {
                    gage = item;
                    break;
                }
            }
            int startIndex = Convert.ToInt32((gage.initPositionX) * chartView.axisXScale / 100);
            if (startIndex > sourceArray.Length)
            {
                return null;
            }
            int stopIndex= Convert.ToInt32((gage.initPositionX+gage.Gagelength) * chartView.axisXScale / 100);
            if (stopIndex>chartView.axisXScale|| stopIndex>sourceArray.Length)
            {
                if (chartView.axisXScale >= sourceArray.Length)
                {
                    stopIndex = sourceArray.Length;
                }
                else
                {
                    stopIndex = chartView.axisXScale;
                }
            }
            int indexLength = stopIndex - startIndex;
            double[] data = new double[indexLength];
            Array.Copy(sourceArray, startIndex, data, 0, indexLength);
            return data;
        }

        public double[] GetlineData()
        {
            return chartData.lineData;
        }

        #endregion

        #endregion
    }
}
