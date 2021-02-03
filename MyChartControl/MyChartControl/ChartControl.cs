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

namespace MyChartControl
{
    public partial class ChartControl: UserControl
    {

        public  double[] ChartData;//绘图用的数据序列

        //闸门参数
        public static GageInfo gageA = new GageInfo { CenterLength = 10, CenterPositionX = 70, CenterPositionY = 70, lineName = "Series2" };
        public static GageInfo gageB = new GageInfo { CenterLength = 10, CenterPositionX = 20, CenterPositionY = 20, lineName = "Series3" };

        public ChartControl()
        {
            InitializeComponent();
            ChartInit();
        }

        /// <summary>
        /// 初始化窗体控件
        /// </summary>
        public  void ChartInit()
        {
            #region 设置ChartArea1绘图属性
            //设置图表坐标轴
            this.chart1.ChartAreas["ChartArea1"].AxisY.Minimum = ChartView.axisYViewCenterValue - ChartView.axisYUpScaleValue;//设置Y轴最小尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisY.Maximum = ChartView.axisYViewCenterValue + ChartView.axisYDownScaleValue;//设置Y轴最大尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisY.Interval = CalAxisGridValue(ChartView.axisYViewCenterValue + ChartView.axisYUpScaleValue, ChartView.axisYViewCenterValue - ChartView.axisYDownScaleValue, ChartView.axisYGridNum);//设置Y轴间隔
            this.chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;//设置X轴最小尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum = ChartView.axisXScaleValue;//设置X轴最大尺寸
            this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = CalAxisGridValue(ChartView.axisXScaleValue, 0, ChartView.axisXGridNum);//设置X轴间隔
            this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;//设置X轴栅格线颜色
            this.chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;//设置Y轴栅格线颜色
            this.chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;//设置X轴栅格线线粗
            this.chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 1;//设置Y轴栅格线线粗
            this.chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Interval = 10;
            this.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;//关闭刻度值显示
            this.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;//关闭刻度值显示
            //设置标题
            this.chart1.Titles["title1"].Text = ChartView.title1;//设置标题内容
            this.chart1.Titles["title1"].ForeColor = Color.Green;//设置标题颜色
            this.chart1.Titles["title1"].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);//设置标题字体和大小
            this.chart1.Titles["title2"].Text = ChartView.title2;//设置标题内容
            this.chart1.Titles["title2"].ForeColor = Color.RoyalBlue;//设置标题颜色
            this.chart1.Titles["title2"].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);//设置标题字体和大小
            //绘图曲线设置
            this.chart1.Series["Series1"].Color = Color.Green;//设置线条颜色
            this.chart1.Series["Series1"].BorderWidth = 1;//设置线粗
            this.chart1.Series["Series1"].ChartType = SeriesChartType.FastLine;//设置绘图模式

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

            DrawGate(gageA);
            DrawGate(gageB);
        }

        /// <summary>
        /// 计算坐标轴栅格间隔的距离
        /// </summary>
        /// <param name="axisYMaxValue"></param>
        /// <param name="axisYMinValue"></param>
        /// <param name="axisYGridNum"></param>
        /// <returns></returns>
        private double CalAxisGridValue(double axisYMaxValue, double axisYMinValue, int axisYGridNum)
        {
            double GridValue = (axisYMaxValue - axisYMinValue) / axisYGridNum;
            return GridValue;
        }

        /// <summary>
        /// 绘制闸门
        /// </summary>
        /// <param name="gageInfo"></param>
        /// <param name="series"></param>
        private void DrawGate(GageInfo gageInfo)
        {
            this.chart1.Series[gageInfo.lineName].Points.Clear();
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[gageInfo.lineName].Points.AddXY(gageInfo.CenterPositionX-gageInfo.CenterLength/2,gageInfo.CenterPositionY-5/2+i);
            }
            for (int i = 0; i < gageInfo.CenterLength+1; i++)
            {
                chart1.Series[gageInfo.lineName].Points.AddXY(gageInfo.CenterPositionX- gageInfo.CenterLength/2+i, gageInfo.CenterPositionY);
            }
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[gageInfo.lineName].Points.AddXY(gageInfo.CenterPositionX + gageInfo.CenterLength / 2, gageInfo.CenterPositionY - 5/2 + i);
            }
        }

        /// <summary>
        /// 缩放Y方向绘图区域
        /// </summary>
        /// <param name="axisUpYplotScale">指示绘图中心上方的绘图区域大小</param>
        /// <param name="axisDownYplotScale">指示绘图中心下方的绘图区域大小</param>
        public void ChartYSizeZoomIn(double axisUpYplotScale, double axisDownYplotScale)
        {
            double YIntervalValueTemp;//Y方向栅格间距
            double AxisYMaxTemp=  axisUpYplotScale;
            double AxisYMinTemp= axisDownYplotScale;
            if (AxisYMaxTemp > AxisYMinTemp)
            {
                ChartView.axisYViewCenterValue = AxisYMaxTemp;
                ChartView.axisYDownScaleValue = AxisYMinTemp;
                this.chart1.ChartAreas["ChartArea1"].AxisY.Maximum = AxisYMaxTemp;
                this.chart1.ChartAreas["ChartArea1"].AxisY.Minimum = AxisYMinTemp;
            }
            else
            {
                return;
            }
            YIntervalValueTemp = CalAxisGridValue(this.chart1.ChartAreas["ChartArea1"].AxisY.Maximum, this.chart1.ChartAreas["ChartArea1"].AxisY.Minimum, ChartView.axisYGridNum);

            this.chart1.ChartAreas["ChartArea1"].AxisY.Interval = YIntervalValueTemp;
            this.chart1.Invalidate();//图像刷新
        }

        /// <summary>
        /// 缩放X方向绘图区域
        /// </summary>
        /// <param name="axisXplotScale">X绘图方向数值大小</param>
        public void ChartXSizeZoomIn(double axisXplotScale)
        {
            double XIntervalValueTemp;//X方向栅格间距
            ChartView.axisXScaleValue = axisXplotScale;
            this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum = axisXplotScale;
            XIntervalValueTemp = CalAxisGridValue(this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum, this.chart1.ChartAreas["ChartArea1"].AxisX.Minimum, ChartView.axisXGridNum);

            this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = XIntervalValueTemp;
            this.chart1.Invalidate();//图像刷新
        }

        /// <summary>
        /// 绘制chartData中的数据
        /// </summary>
        public void DrawLine()
        {
            if(ChartData!=null||ChartData.Length > 0)
            {
                this.chart1.Series["Series1"].Points.Clear();
                for (int pointIndex = 0; pointIndex < ChartData.Length; pointIndex++)
                {
                    chart1.Series["Series1"].Points.AddY(ChartData[pointIndex]);
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 改变绘图区域大小
        /// </summary>
        /// <param name="width"></param>
        /// <param name="high"></param>
        public void ChartSizeChange(int width, int high )
        {
            this.Size= new Size(width, high);
            this.chart1.Size = new Size(width, high);
            this.chart1.Invalidate();
        }

    }
}
