using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class CPUStorage
    {
        private int objCount = 0;
        private Dictionary<int, CPU> cpuDictionary;
        private const string DATA_FILENAME = "cpustorage.dat";
        private BinaryFormatter formatter;

        public void AddCPU(string name, string socket, double speed, int cores)
        {
            this.cpuDictionary.Add(objCount, new CPU(name, socket, speed, cores));
        }

        public void Save()
        {
            try
            {
                FileStream writerFileStream = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                this.formatter.Serialize(writerFileStream, this.cpuDictionary);
            }
            catch (Exception e)
            {
                //Show alert
            }
        }

        public void Load()
        {
            if(File.Exists(DATA_FILENAME))
            {
                try
                {
                    FileStream readerFileStream = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read);
                    this.cpuDictionary = (Dictionary<int, CPU>)this.formatter.Deserialize(readerFileStream);
                    readerFileStream.Close();
                }
                catch (Exception e)
                {
                    //Show alert
                }
            }
        }
    }
}
