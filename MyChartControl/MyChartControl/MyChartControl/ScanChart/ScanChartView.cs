using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyChartControl.ScanChart
{
    class ScanChartView
    {
        public  int xViewScale=1000;
        public  int yViewScale = 1000;
        public Orientation ScanOrientation = Orientation.Horizontal;

        public int[,] ValueToRGB(ColorIndex colorIndex, double[] data)
        {
            int[,] rgb = null;
            if (colorIndex.colorBarType == ColorBarType.gray)
            {
                rgb = this.ValueToColor_Gary(colorIndex, data);
            }
            else if (colorIndex.colorBarType == ColorBarType.jet)
            {
                rgb = this.ValueToColor_Jet(colorIndex, data);
            }
            else if (colorIndex.colorBarType == ColorBarType.Hot)
            {
                rgb = this.ValueToColor_Hot(colorIndex, data);
            }
            return rgb;
        }

        private  int[,] ValueToColor_Gary(ColorIndex colorIndex, double[] data)
        {
            int dataScale = colorIndex.MaxValue - colorIndex.MinValue;
            int dataLength = data.Length;
            int[,] rgb = new int[dataLength,3];
            for (int i = 0; i < dataLength; i++)
            {
                if (data[i] < colorIndex.MinValue)
                {
                    rgb[i, 0] = 0;
                    rgb[i, 1] = 0;
                    rgb[i, 2] = 0;
                }
                else if (data[i] > colorIndex.MaxValue)
                {
                    rgb[i, 0] = 255;
                    rgb[i, 1] = 255;
                    rgb[i, 2] = 255;
                }
                else
                {
                    rgb[i, 0] = Convert.ToInt32((data[i] - colorIndex.MinValue) / dataScale * 255);
                    rgb[i, 1] = rgb[i, 0];
                    rgb[i, 2] = rgb[i, 0];
                }
            }
            return rgb;
        }

        private int[,] ValueToColor_Hot(ColorIndex colorIndex, double[] data)
        {
            int dataScale = colorIndex.MaxValue - colorIndex.MinValue;
            double colorScale = dataScale / 2.5;
            int dataLength = data.Length;
            int[,] rgb = new int[dataLength, 3];
            double valueTemp;
            for (int i = 0; i < dataLength; i++)
            {
                valueTemp = data[i] - colorIndex.MinValue;
                if (valueTemp < 0)
                {
                    rgb[i, 0] = 0;
                    rgb[i, 1] = 0;
                    rgb[i, 2] = 0;
                }
                else if (valueTemp <= colorScale / 2)
                {
                    rgb[i, 0] = Convert.ToInt32((colorScale / 2 + valueTemp) / (colorScale) * 255);
                    rgb[i, 1] = 0;
                    rgb[i, 2] = 0;
                }
                else if (valueTemp <= colorScale / 2 + colorScale)
                {
                    rgb[i, 0] = 255;
                    rgb[i, 1] = Convert.ToInt32((valueTemp - colorScale / 2) / colorScale * 255);
                    rgb[i, 2] = 0;
                }
                else if (valueTemp <= dataScale)
                {
                    rgb[i, 0] = 255;
                    rgb[i, 1] = 255;
                    rgb[i, 2] = Convert.ToInt32((valueTemp - colorScale / 2 - colorScale) / (dataScale - colorScale / 2 - colorScale)*255);
                }
                else if (valueTemp > dataScale)
                {
                    rgb[i, 0] = 255;
                    rgb[i, 1] = 255;
                    rgb[i, 2] = 255;
                }
            }
            return rgb;
        }

        private int[,] ValueToColor_Jet(ColorIndex colorIndex, double[] data)
        {
            int dataScale = colorIndex.MaxValue - colorIndex.MinValue;
            double colorScale = dataScale / 4;
            int dataLength = data.Length;
            int[,] rgb = new int[dataLength, 3];
            double  valueTemp;
            for (int i = 0; i < dataLength; i++)
            {
                valueTemp = data[i] - colorIndex.MinValue;
                if (valueTemp < 0)
                {
                    rgb[i, 0] = 0;
                    rgb[i, 1] = 0;
                    rgb[i, 2] = 0;
                }
                else if (valueTemp <= colorScale / 2)
                {
                    rgb[i, 0] = 0;
                    rgb[i, 1] = 0;
                    rgb[i, 2] = Convert.ToInt32((valueTemp + colorScale / 2) / colorScale * 255);
                }
                else if (valueTemp <= colorScale / 2 + colorScale)
                {
                    rgb[i, 0] = 0;
                    rgb[i, 1] = Convert.ToInt32((valueTemp - colorScale / 2) / colorScale * 255);
                    rgb[i, 2] = 255;
                }
                else if (valueTemp <= colorScale / 2 + colorScale * 2)
                {
                    rgb[i, 0] = Convert.ToInt32((valueTemp - colorScale / 2 - colorScale) / colorScale * 255);
                    rgb[i, 1] = 255;
                    rgb[i, 2] = Convert.ToInt32((colorScale / 2 + colorScale * 2 - valueTemp) / colorScale * 255);
                }
                else if (valueTemp <= colorScale / 2 + colorScale * 3)
                {
                    rgb[i, 0] = 255;
                    rgb[i, 1] = Convert.ToInt32((colorScale / 2 + colorScale * 3 - valueTemp) / colorScale * 255);
                    rgb[i, 2] = 0;
                }
                else if (valueTemp <= dataScale)
                {
                    rgb[i, 0] = Convert.ToInt32((dataScale + colorScale / 2 - valueTemp) / colorScale * 255);
                    rgb[i, 1] = 0;
                    rgb[i, 2] = 0;
                }
                else if (valueTemp > dataScale)
                {
                    rgb[i, 0] = 255;
                    rgb[i, 1] = 0;
                    rgb[i, 2] = 0;
                }
            }
            return rgb;
        }
    }
}
