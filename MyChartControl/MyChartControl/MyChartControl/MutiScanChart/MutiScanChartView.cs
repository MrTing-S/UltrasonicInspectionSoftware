using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChartControl.MutiScanChart
{
    class MutiScanChartView
    {
        public  WaveChartTpye waveChartTpye = new WaveChartTpye();

        public string title1 { get; set; } = "内容1";
        public string title2 { get; set; } = "内容2";

        //X轴参数
        public int axisXScale;//x轴点数

        //Y轴参数
        public int axisYUpScale;//y轴上限
        public int axisYDownScale;//y轴下限
        public int axisYGridNum;//扫描窗体数
    }

    enum WaveChartTpye
    {
        Line,Point
    }
}
