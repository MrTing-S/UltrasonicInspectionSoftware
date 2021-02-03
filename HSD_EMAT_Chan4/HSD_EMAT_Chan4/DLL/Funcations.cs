using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSD_EMAT_Chan4.DLL
{
    public static  class Funcations
    {
        public static  double[] ArrayUshortToDouble(ushort[] arry)
        {
            double[] doubleArray = new double[arry.Length];
            for (int i = 0; i < arry.Length ; i++)
            {
                doubleArray[i] = Convert.ToDouble(arry[i]);
            }
            return doubleArray;
        }

        public static double[] ArrayByteToDouble(byte[] arry)
        {
            double[] doubleArray = new double[arry.Length];
            for (int i = 0; i < arry.Length; i++)
            {
                doubleArray[i] = Convert.ToDouble(arry[i]);
            }
            return doubleArray;
        }

    }
}
