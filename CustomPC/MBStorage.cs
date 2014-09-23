using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class MBStorage :Storage
    {
        private List<MB> list = new List<MB>();
        public override string DATA_FILENAME
        {
            get { return "mbstorage.dat"; }
        }

        public MBStorage()
        {
            Load();
        }

        override public void Add(Object obj)
        {
            if(obj.GetType() == typeof(MB)) {
                this.list.Add((MB)obj);
                Save(this.list);
            }
        }

        public override void Load()
        {
            if ((File.Exists(DATA_FILENAME)) && (new FileInfo(DATA_FILENAME).Length != 0))
            {
                try
                {
                    using (Stream stream = File.Open(DATA_FILENAME, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        this.list = (List<MB>)bin.Deserialize(stream);
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        public List<string> GetAllSockets()
        {
            List<string> socketList = new List<string>();

            foreach (MB mb in list)
            {
                if (!socketList.Contains(mb.CpuSocket))
                {
                    socketList.Add(mb.CpuSocket);
                }
            }

            return socketList;
        }

        public List<string> GetAllRamTypes()
        {
            List<string> ramTypeList = new List<string>();

            foreach (MB mb in list)
            {
                if (!ramTypeList.Contains(mb.RamType))
                {
                    ramTypeList.Add(mb.RamType);
                }
            }

            return ramTypeList;
        }

        public List<string> GetAllGpuTypes()
        {
            List<string> gpuTypeList = new List<string>();

            foreach (MB mb in list)
            {
                if (!gpuTypeList.Contains(mb.GpuType))
                {
                    gpuTypeList.Add(mb.GpuType);
                }
            }

            return gpuTypeList;
        }

        public List<MB> GetAll()
        {
            return this.list;
        }
    }
}
