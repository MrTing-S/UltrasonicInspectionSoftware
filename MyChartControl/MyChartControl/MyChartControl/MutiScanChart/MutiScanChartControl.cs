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

namespace MyChartControl.MutiScanChart
{
    public partial class MutiScanChartControl : UserControl
    {
        //绘图数据
        private ChartData chartData;
        //图表视图
        private MutiScanChartView MutiScanChartView;
        //闸门
        private Gage[] allGage;
        private Gage gageA;
        private Gage gageB;
        //坐标轴数据
        private VAxisValue vAxisValue;
        private HAxisValue hAxisValue;

        bool isChartReady = false;

        public MutiScanChartControl()
        {
            InitializeComponent();
            InitGage();
            InitAxisValue();
            InitChartData();
            InitChartView();
        }

        #region 内置函数

        #region 窗体初始化
        private void InitChartView()
        {
            MutiScanChartView = new MutiScanChartView
            {
                waveChartTpye = WaveChartTpye.Line,
                axisXScale = 1000,
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
            this.vAxisValue = new VAxisValue(5);
            this.vAxisValue.lableWidth = 40;
            this.vAxisValue.lableHeigh = 15;
            this.vAxisValue.labels[0] = this.labelHMark1;
            this.vAxisValue.labels[1] = this.labelHMark2;
            this.vAxisValue.labels[2] = this.labelHMark3;
            this.vAxisValue.labels[3] = this.labelHMark4;
            this.vAxisValue.labels[4] = this.labelHMark5;
            this.hAxisValue = new HAxisValue(4);
            this.hAxisValue.lableWidth = 45;
            this.hAxisValue.lableHeigh = 15;
            this.hAxisValue.labels[0] = this.labelVMark1;
            this.hAxisValue.labels[1] = this.labelVMark2;
            this.hAxisValue.labels[2] = this.labelVMark3;
            this.hAxisValue.labels[3] = this.labelVMark4;
        }

        private void InitChartData()
        {
            this.chartData = new ChartData
            {
                isPointDataFull = false,
                pointValue = 0,
                lineData = new double[300],
                pointDataIndex = new int[4],
                pointDataQueue = new System.Collections.Queue[4]
            };
            for (int i = 0; i < chartData.pointDataQueue.Length; i++)
            {
                chartData.pointDataQueue[i] = new System.Collections.Queue();
            }
        }

        #endregion

        #region 图表绘制

        //设置窗体显示
        private void SetChartView()
        {
            #region 设置ChartArea1绘图属性
            //设置图表坐标轴
            this.chart1.ChartAreas["ChartArea1"].AxisY.Minimum = MutiScanChartView.axisYDownScale;//设置Y轴最小尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisY.Maximum = MutiScanChartView.axisYUpScale;//设置Y轴最大尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisY.Interval = CalAxisGridValue((MutiScanChartView.axisYUpScale- MutiScanChartView.axisYDownScale), 0, MutiScanChartView.axisYGridNum);//设置Y轴间隔
            this.chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;//设置X轴最小尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum = MutiScanChartView.axisXScale;//设置X轴最大尺寸
            //this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = CalAxisGridValue(MutiScanChartView.axisXScale, 0, MutiScanChartView.axisXGridNum);//设置X轴间隔
            //this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;//设置X轴栅格线颜色
            this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            this.chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = System.Drawing.Color.Black;//设置Y轴栅格线颜色
            this.chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            //this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;//设置X轴栅格线线粗
            this.chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 2;//设置Y轴栅格线线粗
            this.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;//关闭刻度值显示
            this.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;//关闭刻度值显示
            //绘图曲线设置
            this.chart1.Series["Series1.1"].Color = Color.Green;//设置线条颜色
            this.chart1.Series["Series1.1"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series1.1"].ChartType = SeriesChartType.FastLine;//设置绘图模式
            this.chart1.Series["Series1.2"].Color = Color.Green;//设置线条颜色
            this.chart1.Series["Series1.2"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series1.2"].ChartType = SeriesChartType.FastLine;//设置绘图模式

            this.chart1.Series["Series2.1"].Color = Color.Red;//设置线条颜色
            this.chart1.Series["Series2.1"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series2.1"].ChartType = SeriesChartType.FastLine;//设置绘图模式
            this.chart1.Series["Series2.2"].Color = Color.Red;//设置线条颜色
            this.chart1.Series["Series2.2"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series2.2"].ChartType = SeriesChartType.FastLine;//设置绘图模式

            this.chart1.Series["Series3.1"].Color = Color.Blue;//设置线条颜色
            this.chart1.Series["Series3.1"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series3.1"].ChartType = SeriesChartType.FastLine;//设置绘图模式
            this.chart1.Series["Series3.2"].Color = Color.Blue;//设置线条颜色
            this.chart1.Series["Series3.2"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series3.2"].ChartType = SeriesChartType.FastLine;//设置绘图模式

            this.chart1.Series["Series4.1"].Color = Color.Brown;//设置线条颜色
            this.chart1.Series["Series4.1"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series4.1"].ChartType = SeriesChartType.FastLine;//设置绘图模式
            this.chart1.Series["Series4.2"].Color = Color.Brown;//设置线条颜色
            this.chart1.Series["Series4.2"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series4.2"].ChartType = SeriesChartType.FastLine;//设置绘图模式
            #endregion

            #region 设置ChartArea2绘图属性(注释)
            //this.chart1.ChartAreas["ChartArea2"].AxisX.Minimum = 0;
            //this.chart1.ChartAreas["ChartArea2"].AxisX.Maximum = 100;
            //this.chart1.ChartAreas["ChartArea2"].AxisY.Minimum = 0;
            //this.chart1.ChartAreas["ChartArea2"].AxisY.Maximum = 100;

            //this.chart1.ChartAreas["ChartArea2"].AxisX.LabelStyle.Enabled = false;//关闭刻度值显示
            //this.chart1.ChartAreas["ChartArea2"].AxisY.LabelStyle.Enabled = false;//关闭刻度值显示
            //this.chart1.ChartAreas["ChartArea2"].AxisX.MajorGrid.Enabled = false;
            //this.chart1.ChartAreas["ChartArea2"].AxisX.MinorGrid.Enabled = false;
            //this.chart1.ChartAreas["ChartArea2"].AxisY.MajorGrid.Enabled = false;
            //this.chart1.ChartAreas["ChartArea2"].AxisY.MinorGrid.Enabled = false;

            //this.chart1.Series["Series2"].ChartType = SeriesChartType.FastLine;
            //this.chart1.Series["Series3"].ChartType = SeriesChartType.FastLine;
            //this.chart1.Series["Series2"].BorderWidth = 2;
            //this.chart1.Series["Series3"].BorderWidth = 2;
            #endregion

            //if (gageA.visiable == true)
            //{
            //    DrawGate(gageA);
            //}
            //if (gageB.visiable == true)
            //{
            //    DrawGate(gageB);
            //}
        }

        //计算图表间隔值
        private double CalAxisGridValue(double axisYMaxValue, double axisYMinValue, int axisYGridNum)
        {
            double GridValue = (axisYMaxValue - axisYMinValue) / axisYGridNum;
            return GridValue;
        }

        #endregion

        #region 大小与位置调整
        private void ResetSize()
        {
            this.panel1.Size = new Size(this.Width - hAxisValue.lableWidth, this.Height - vAxisValue.lableHeigh);
            this.chart1.Size = new Size(this.Width - hAxisValue.lableWidth, this.Height - vAxisValue.lableHeigh);
            this.vAxisValue.initPos = new Point(this.hAxisValue.lableWidth, this.chart1.Height);
            this.vAxisValue.vPosGap = (this.chart1.Size.Width - this.vAxisValue.lableWidth) / (this.vAxisValue.ValueNum - 1);
            this.hAxisValue.initPos = new Point(0, this.chart1.Height -this.chart1.Height/(hAxisValue.ValueNum*2));
            this.hAxisValue.hPosGap = this.chart1.Size.Height / this.hAxisValue.ValueNum;
        }

        private void ResetPos()
        {
            this.panel1.Location = new Point(hAxisValue.lableWidth, 0);
            this.chart1.Location = new Point(hAxisValue.lableWidth, 0);
            int x = this.vAxisValue.initPos.X;
            int y = this.vAxisValue.initPos.Y;
            int gap = this.vAxisValue.vPosGap;
            for (int i = 0; i < this.vAxisValue.ValueNum; i++)
            {
                this.vAxisValue.labels[i].Location = new Point(x + gap * i, y);
            }
            x = this.hAxisValue.initPos.X;
            y = this.hAxisValue.initPos.Y;
            gap = this.hAxisValue.hPosGap;
            for (int i = 0; i < this.hAxisValue.ValueNum; i++)
            {
                this.hAxisValue.labels[i].Location = new Point(x , y - gap * i);
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
            this.MutiScanChartView.axisYUpScale = axisDownYplotScale+(axisUpYplotScale- axisDownYplotScale)*8;
            this.MutiScanChartView.axisYDownScale = axisDownYplotScale;
            SetChartView();
            this.chart1.Invalidate();//图像刷新
        }

        /// <summary>
        /// 设置X轴的数据范围
        /// </summary>
        /// <param name="axisXplotScale">X轴最大值</param>
        public void ChartXSizeZoomChange(int axisXplotScale)
        {
            this.MutiScanChartView.axisXScale = axisXplotScale;
            this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum = axisXplotScale;
            this.chart1.Invalidate();//图像刷新
        }
        #endregion

        #region 曲线绘制
        ///// <summary>
        ///// 绘制chartData中的数据
        ///// </summary>
        //public void DrawLine(double[] data)
        //{
        //    if (this.MutiScanChartView.waveChartTpye == WaveChartTpye.Point)
        //    {
        //        this.MutiScanChartView.waveChartTpye = WaveChartTpye.Line;
        //        this.chartData.isPointDataFull = false;
        //    }
        //    if (data.Length >= this.chartData.lineData.Length)
        //    {
        //        Array.Copy(data, chartData.lineData, chartData.lineData.Length);
        //    }
        //    else
        //    {
        //        Array.Copy(data, chartData.lineData, data.Length);
        //    }
        //    if (chartData.lineData != null || chartData.lineData.Length > 0)
        //    {
        //        this.chart1.Series["Series1"].Points.Clear();
        //        for (int pointIndex = 0; pointIndex < chartData.lineData.Length; pointIndex++)
        //        {
        //            chart1.Series["Series1"].Points.AddY(chartData.lineData[pointIndex]);
        //        }
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}

        /// <summary>
        /// 向扫描通道中添加点
        /// </summary>
        /// <param name="data">内伤与外伤点的数组(索引0为内伤)</param>
        /// <param name="channel">通道数</param>
        public void DrawPointOfSingleChannel(double[] data,int channel)
        {
            if (channel >= MutiScanChartView.axisYGridNum || channel < 0||data==null)
            {
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                if (data[i] > MutiScanChartView.axisYUpScale)
                {
                    data[i] = MutiScanChartView.axisYUpScale;
                }
                if (data[i] < MutiScanChartView.axisYDownScale)
                {
                    data[i] = MutiScanChartView.axisYDownScale;
                }
            }
            string seriseslNameOne = "Series" + (channel+1).ToString()+"."+"1";
            string seriseslNameTwo = "Series" + (channel + 1).ToString() + "." + "2";
            data[0] = data[0] + (MutiScanChartView.axisYUpScale - MutiScanChartView.axisYDownScale) / 4 * channel;
            data[1] = data[1] + (MutiScanChartView.axisYUpScale - MutiScanChartView.axisYDownScale) / 4 * (channel+0.5);
            if (this.chartData.pointDataIndex[channel] == this.MutiScanChartView.axisXScale)
            {
                this.chartData.pointDataQueue[channel].Dequeue();
                this.chartData.pointDataQueue[channel].Enqueue(data);
                this.chartData.isPointDataFull = true;
                chart1.Series[seriseslNameOne].Points.Clear();
                chart1.Series[seriseslNameTwo].Points.Clear();
                foreach (double[] item in this.chartData.pointDataQueue[channel])
                {
                    chart1.Series[seriseslNameOne].Points.AddY(item[0]);
                    chart1.Series[seriseslNameTwo].Points.AddY(item[1]);
                }
            }
            else
            {
                this.chartData.pointDataIndex[channel]++;
                this.chartData.pointDataQueue[channel].Enqueue(data);
                chart1.Series[seriseslNameOne].Points.AddY(data[0]);
                chart1.Series[seriseslNameTwo].Points.AddY(data[1]);
            }
        }
        #endregion

        #region 坐标轴设置
        /// <summary>
        /// 改变坐标轴的内容索引
        /// </summary>
        /// <param name="texts">坐标轴内容字符串</param>
        public void SetAxisXValue(string[] texts)
        {
            if (texts == null)
            {
                return;
            }
            if (texts.Length >= this.vAxisValue.ValueNum)
            {
                for (int i = 0; i < vAxisValue.ValueNum; i++)
                {
                    this.vAxisValue.labels[i].Text = texts[i];
                }
            }
            else
            {
                for (int i = 0; i < texts.Length; i++)
                {
                    this.vAxisValue.labels[i].Text = texts[i];
                }
            }
        }

        public void SetAxisYValue(string[] texts)
        {
            if (texts == null)
            {
                return;
            }
            if (texts.Length >= this.hAxisValue.ValueNum)
            {
                for (int i = 0; i < hAxisValue.ValueNum; i++)
                {
                    this.hAxisValue.labels[i].Text = texts[i];
                }
            }
            else
            {
                for (int i = 0; i < texts.Length; i++)
                {
                    this.hAxisValue.labels[i].Text = texts[i];
                }
            }
        }

        public bool GetIsPointDataFulling()
        {
            return this.chartData.isPointDataFull;
        }
        #endregion

        #endregion

        #region 闸门绘制(注释)
        //private void DrawGate(Gage gageInfo)
        //{
        //    this.chart1.Series[gageInfo.gageName].Points.Clear();
        //    if (!gageInfo.visiable)
        //    {
        //        return;
        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        chart1.Series[gageInfo.gageName].Points.AddXY(gageInfo.initPositionX, gageInfo.initPositionY - 5 / 2 + i);
        //    }
        //    for (int i = 0; i < gageInfo.Gagelength + 1; i++)
        //    {
        //        chart1.Series[gageInfo.gageName].Points.AddXY(gageInfo.initPositionX + i, gageInfo.initPositionY);
        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        chart1.Series[gageInfo.gageName].Points.AddXY(gageInfo.initPositionX + gageInfo.Gagelength, gageInfo.initPositionY - 5 / 2 + i);
        //    }
        //}
        #endregion

        #region 闸门绘制(注释)

        ///// <summary>
        ///// 绘制闸门位置
        ///// </summary>
        ///// <param name="gageTpye">闸门类型</param>
        ///// <param name="centerPoint">闸门中心点</param>
        ///// <param name="gageLength">闸门长度</param>
        //public void SetGage(GageTpye gageTpye, Point initPos, int gageLength)
        //{
        //    foreach (Gage item in allGage)
        //    {
        //        if (item.gageTpye == gageTpye)
        //        {
        //            item.initPositionX = initPos.X;
        //            item.initPositionY = initPos.Y;
        //            item.Gagelength = gageLength;
        //        }
        //        DrawGate(item);
        //    }
        //}

        //public void SetGageVisible(GageTpye gageTpye, bool isVisible)
        //{
        //    foreach (Gage item in allGage)
        //    {
        //        if (item.gageTpye == gageTpye)
        //        {
        //            item.visiable = isVisible;
        //        }
        //        DrawGate(item);
        //    }
        //}

        ///// <summary>
        ///// 返回闸门范围内的数据
        ///// </summary>
        ///// <param name="gageTpye"></param>
        ///// <param name="sourceArray"></param>
        ///// <returns></returns>
        //public double[] GetGageData(GageTpye gageTpye, double[] sourceArray)
        //{
        //    Gage gage = new Gage();
        //    foreach (Gage item in allGage)
        //    {
        //        if (item.gageTpye == gageTpye)
        //        {
        //            gage = item;
        //            break;
        //        }
        //    }
        //    int startIndex = Convert.ToInt32((gage.initPositionX) * MutiScanChartView.axisXScale / 100);
        //    if (startIndex > sourceArray.Length)
        //    {
        //        return null;
        //    }
        //    int stopIndex = Convert.ToInt32((gage.initPositionX + gage.Gagelength) * MutiScanChartView.axisXScale / 100);
        //    if (stopIndex > MutiScanChartView.axisXScale || stopIndex > sourceArray.Length)
        //    {
        //        if (MutiScanChartView.axisXScale >= sourceArray.Length)
        //        {
        //            stopIndex = sourceArray.Length;
        //        }
        //        else
        //        {
        //            stopIndex = MutiScanChartView.axisXScale;
        //        }
        //    }
        //    int indexLength = stopIndex - startIndex;
        //    double[] data = new double[indexLength];
        //    Array.Copy(sourceArray, startIndex, data, 0, indexLength);
        //    return data;
        //}

        //public double[] GetlineData()
        //{
        //    return chartData.lineData;
        //}

        #endregion
    }
}
