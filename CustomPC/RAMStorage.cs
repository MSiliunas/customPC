using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class RAMStorage :Storage
    {
        private List<RAM> list = new List<RAM>();
        public override string DATA_FILENAME
        {
            get { return "ramstorage.dat"; }
        }

        public override void Add(object obj)
        {
            if (obj.GetType() == typeof(RAM))
            {
                this.list.Add((RAM)obj);
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
                        this.list = (List<RAM>)bin.Deserialize(stream);
                    }
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
