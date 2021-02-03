using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChartControl
{
     static class ChartView
    {
        static public string title1 = "内容1";
        static public string title2 = "内容2";

        static public double axisYUpScaleValue = 60;//Y轴偏移视野中心的尺寸范围
        static public double axisYDownScaleValue = 60;//Y轴偏移视野中心的尺寸范围
        static public double axisYViewCenterValue = 50;//窗体视野中心Y轴的值
        static public int axisYGridNum = 10;//窗体Y方向需要显示的栅格的数目
        static public int axisYIntervalValue;//Y轴间隔尺寸
        static public double axisYZoomValue = 1;//Y轴单次缩放大小

        //X轴参数
        static public double axisXScaleValue = 2000;//X轴偏移的尺寸范围
        static public int axisXGridNum = 10;//窗体X方向需要显示的栅格的数目
        static public int axisXIntervalValue;//X轴间隔尺寸
        static public double axisXZoomValue = 100;//X轴单次缩放大小
    }
}
