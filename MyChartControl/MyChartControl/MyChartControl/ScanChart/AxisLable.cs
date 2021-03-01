﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChartControl.ScanChart
{
    class AxisValue
    {
        public AxisValue(int valueNum)
        {
            this.values = new double[valueNum];
            this.labels = new Label[valueNum];
            this.valueNum = valueNum;
        }
        private int valueNum;
        public int ValueNum
        {
            get
            {
                return valueNum;
            }
        }
        public Label[] labels;
        public double[] values;
        public Point initPos;
        public int hPosGap;
        public int vPosGap;
        public double dataGap;
        public int lableWidth;
        public int lableHeigh;
    }
}
