using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSD_EMAT_Chan4.Models
{
    public static class FormView
    {
        public static  FromViewType m_aveFromViewType;
        static public ChartViewType chartViewType;
        static public int paramSetFormWidth = 320;//参数调节窗口的宽度
        static public int gageSetFormWidth = 320;//闸门设置窗口的宽度
    }

    public enum FromViewType//波形图布局的方式
    {
        type1,
        type2,
        type3,
        type4,
        type5
    }

    public enum ChartViewType
    {
        waveChart,
        scanChart
    }
}
