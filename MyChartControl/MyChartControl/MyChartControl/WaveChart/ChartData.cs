using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChartControl.WaveChart
{
    class ChartData
    {
        public  double[] lineData;
        public  Queue pointDataQueue;
        public  int pointDataIndex;
        public int pointValue;
        public bool isPointDataFull; 
    }
}
