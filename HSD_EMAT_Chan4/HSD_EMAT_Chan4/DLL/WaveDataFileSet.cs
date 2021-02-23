using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HSD_EMAT_Chan4.Models;

namespace HSD_EMAT_Chan4.DLL
{
    public static  class WaveDataFileSet
    {
        public delegate void DelGetSaveFileInfo(WaveDataFile waveDataFile);


        private static FileStream m_fileStream;
        
        public static void SetFileStreamWrite(string path)
        {
            if (!File.Exists(path))
            {
                m_fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);//如果不存在则创建文件
            }
            else
            {
                m_fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            GetAllStatus.SetIsWaveDataWrite(true);
            GetAllStatus.SetIsWaveDataRead(false);
        }

        public static void SetFileStreamRead(string path)
        {
            if (!File.Exists(path))
            {
                m_fileStream =null;//如果不存在则清空文件流
            }
            else
            {
                m_fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                GetAllStatus.SetIsWaveDataWrite(false);
                GetAllStatus.SetIsWaveDataRead(true);
            }
        }

        public static bool WriteByteArray(byte[] data)
        {
            if (m_fileStream == null||GetAllStatus.GetIsWaveDataRead()||!GetAllStatus.GetIsWaveDataWrite())
            {
                return false;
            }
            try
            {
                m_fileStream.Write(data, 0, data.Length);
                GetAllStatus.SetIsWaveDataWrite(true); ;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int ReadByteArray(byte[] data)
        {
            int receieveNum=0;
            if (m_fileStream == null|| GetAllStatus.GetIsWaveDataWrite()||!GetAllStatus.GetIsWaveDataRead())
            {
                return 0;
            }
            try
            {
                receieveNum=m_fileStream.Read(data, 0, data.Length);
                return receieveNum;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static byte[] ReadAllByteArray()
        {
            if (m_fileStream == null || GetAllStatus.GetIsWaveDataWrite() || !GetAllStatus.GetIsWaveDataRead())
            {
                return null;
            }
            try
            {
                byte[] dataRead = new byte[m_fileStream.Length];
                m_fileStream.Read(dataRead, 0, dataRead.Length);
                return dataRead;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void CloseFileStream()
        {
            if (m_fileStream != null)
            {
                m_fileStream.Close();
                GetAllStatus.SetIsWaveDataWrite(false);
                GetAllStatus.SetIsWaveDataRead(false);
            }
        }

    }
}
