using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class HDDStorage :Storage
    {
        private List<HDD> list = new List<HDD>();
        public override string DATA_FILENAME
        {
            get { return "hddstorage.dat"; }
        }

        public HDDStorage()
        {
            Load();
        }

        public override void Add(object obj)
        {
            if (obj.GetType() == typeof(HDD))
            {
                this.list.Add((HDD)obj);
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
                        this.list = (List<HDD>)bin.Deserialize(stream);
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        public List<HDD> GetAll()
        {
            return this.list;
        }
    }
}
