using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class CPUStorage :Storage
    {
        private List<CPU> list = new List<CPU>();
        public override string DATA_FILENAME
        {
            get { return "cpustorage.dat"; }
        }

        public CPUStorage()
        {
            Load();
        }

        override public void Add(object obj)
        {
            if (obj.GetType() == typeof(CPU))
            {
                this.list.Add((CPU)obj);
                Save(this.list);
            }
        }

        override public void Load()
        {
            if ((File.Exists(DATA_FILENAME)) && (new FileInfo(DATA_FILENAME).Length != 0))
            {
                try
                {
                    using (Stream stream = File.Open(DATA_FILENAME, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        this.list = (List<CPU>)bin.Deserialize(stream);
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        public List<String> GetAvailableSockets()
        {
            List<String> socketList = new List<String>();

            foreach (CPU cpu in list) {
                if (!socketList.Contains(cpu.Socket))
                {
                    socketList.Add(cpu.Socket);
                }
            }
            return socketList;
        }

        public List<CPU> GetAll()
        {
            return list;
        }
    }
}
