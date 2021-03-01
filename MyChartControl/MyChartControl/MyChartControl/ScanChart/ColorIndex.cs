using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChartControl
{
    public class ColorIndex
    {
        public ColorBarType colorBarType= ColorBarType.jet;
        private int maxValue=256;
        public int MaxValue
        {
            get
            {
                return maxValue;
            }
            set 
            {
                if(value> minValue)
                {
                    maxValue = value;
                }
            }
        }
        private int minValue=0;
        public int MinValue
        {
            get
            {
                return minValue;
            }
            set
            {
                if (value < maxValue)
                {
                    minValue = value;
                }
            }
        }

    }
    public enum ColorBarType
    {
        gray, jet,  Hot
    }
}
