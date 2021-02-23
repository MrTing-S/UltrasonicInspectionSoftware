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
            if (arry == null)
            {
                return null;
            }
            double[] doubleArray = new double[arry.Length];
            for (int i = 0; i < arry.Length ; i++)
            {
                doubleArray[i] = Convert.ToDouble(arry[i]);
            }
            return doubleArray;
        }

        public static double[] ArrayByteToDouble(byte[] arry)
        {
            if (arry == null)
            {
                return null;
            }
            double[] doubleArray = new double[arry.Length];
            for (int i = 0; i < arry.Length; i++)
            {
                doubleArray[i] = Convert.ToDouble(arry[i]);
            }
            return doubleArray;
        }

        public static  string GetCurTimeSequence()
        {
            System.DateTime currDateTime = System.DateTime.Now;
            return currDateTime.Year.ToString() + "_" + currDateTime.Month.ToString() + "_" + currDateTime.Day.ToString() + "_" + currDateTime.Hour.ToString() + "_" + currDateTime.Minute.ToString() + "_" + currDateTime.Second.ToString();
        }

        public static byte [] ArrayUshortToByte(ushort [] arry)
        {
            if (arry == null)
            {
                return null;
            }
            byte[] byteArray = new byte[arry.Length];
            for (int i = 0; i < arry.Length; i++)
            {
                byteArray[i] = Convert.ToByte(arry[i]);
            }
            return byteArray;
        }

        public static ushort[] ArrayByteToUshort(byte [] arry)
        {
            if (arry == null)
            {
                return null;
            }
            ushort [] ushortArray = new ushort[arry.Length];
            for (int i = 0; i < arry.Length; i++)
            {
                ushortArray[i] = Convert.ToUInt16(arry[i]);
            }
            return ushortArray;
        }

    }
}
