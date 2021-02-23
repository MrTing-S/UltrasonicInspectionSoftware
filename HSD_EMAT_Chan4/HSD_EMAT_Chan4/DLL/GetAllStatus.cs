using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSD_EMAT_Chan4.Models;

namespace HSD_EMAT_Chan4.DLL
{
    public static  class GetAllStatus
    {
        private static bool IsSeverConnecting;
        private static bool IsdataSampling;
        private static bool IsWaveDataWrite;
        private static bool IsWaveDataRead;
        private static bool isWaveDataRecording;

        //判断服务器是否连接
        public static bool GetIsSeverConnecting()
        {
            return IsSeverConnecting;
        }

        public static void SetIsSeverConnecting(bool status)
        {
            IsSeverConnecting = status; 
        }

        //判断数据是否在采集
        public static bool GetIsDataSampling()
        {
            return IsdataSampling;
        }

        public static void SetIsDataSampling(bool status)
        {
            IsdataSampling = status; ;
        }

        //判断波形数据是否在写
        public static bool GetIsWaveDataWrite()
        {
            return IsWaveDataWrite;
        }

        public static void SetIsWaveDataWrite(bool status)
        {
            IsWaveDataWrite = status; 
        }

        //判断波形数据是否在读
        public static bool GetIsWaveDataRead()
        {
            return IsWaveDataRead;
        }

        public static void SetIsWaveDataRead(bool status)
        {
            IsWaveDataRead = status;
        }

        //判断数据是否在记录中
        public static bool GetIsWaveDataRecording()
        {
            return isWaveDataRecording;
        }

        public static void SetIsWaveDataRecording(bool status)
        {
            isWaveDataRecording=status;
        }
    }
}
