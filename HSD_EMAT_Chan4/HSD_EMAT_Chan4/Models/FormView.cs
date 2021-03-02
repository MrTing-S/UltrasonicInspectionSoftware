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
        static public int paramSetFormWidth = 400;//参数调节窗口的宽度
        static public ChartViewType chartViewType;
    }

    public enum FromViewType//波形图布局的方式
    {
        type1,
        type2,
        type3
    }

    public enum ChartViewType
    {
        waveChart,
        scanChart
    }
}
