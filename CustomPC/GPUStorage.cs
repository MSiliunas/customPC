using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class GPUStorage :Storage
    {
        private List<GPU> list = new List<GPU>();
        public override string DATA_FILENAME
        {
            get { return "gpustorage.dat"; }
        }

        public GPUStorage()
        {
            Load();
        }

        public override void Add(object obj)
        {
            if (obj.GetType() == typeof(GPU))
            {
                this.list.Add((GPU)obj);
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
                        this.list = (List<GPU>)bin.Deserialize(stream);
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        public List<GPU> GetAll()
        {
            return list;
        }
    }
}
