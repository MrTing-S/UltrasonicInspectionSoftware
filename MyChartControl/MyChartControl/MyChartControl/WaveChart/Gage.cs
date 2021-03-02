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
        private int gageLength=1;
        public int Gagelength
        {
            get 
            {
                return gageLength;
            }
            set
            {
                if (value <= 0)
                {
                    gageLength = 1;
                }
                else
                {
                    gageLength = value;
                }
            }
        }//保证最小长度为1

        public string gageName;
        public bool visiable;
    }

    public  enum GageTpye
    {
        GageA,
        GageB
    }
}
