using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChartControl.WaveChart
{
    class Gage
    {
        public GageTpye gageTpye;

        public int initPositionX;//范围都在0-100之间变动
        public int initPositionY;
        public int CenterLength;

        public string gageName;
        public bool visiable;
    }

    public  enum GageTpye
    {
        GageA,
        GageB
    }
}
