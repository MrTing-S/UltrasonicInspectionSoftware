using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChartControl.WaveChart
{
    class WaveChartView
    {
        public  WaveChartTpye waveChartTpye = new WaveChartTpye();

        public string title1 { get; set; } = "内容1";
        public string title2 { get; set; } = "内容2";

        //X轴参数
        public int axisXScale;//x轴点数
        public int axisXGridNum;//窗体X方向需要显示的栅格的数目

        //Y轴参数
        public int axisYUpScale;//y轴上限
        public int axisYDownScale;//y轴下限
        public int axisYGridNum;//窗体Y方向需要显示的栅格的数目
    }

    enum WaveChartTpye
    {
        Line,Point
    }
}
