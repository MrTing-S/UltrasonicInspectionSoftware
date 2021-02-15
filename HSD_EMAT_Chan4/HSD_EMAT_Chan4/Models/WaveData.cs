using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HSD_EMAT_Chan4.Models
{
    public class WaveData
    {
        public bool isWaveSampling;
        FileStream fileStreamWrite;

        public bool WriteByteArray(string path,byte[] data)
        {
            if (!File.Exists(path))
            {
                fileStreamWrite = new FileStream(path, FileMode.Create, FileAccess.Write);//如果不存在则创建文件
            }
            else
            {
                fileStreamWrite = new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            try
            {
                fileStreamWrite.Write(data, 0, data.Length);
                fileStreamWrite.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
