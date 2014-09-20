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
        public MBStorage() :base()
        {

        }

        private List<MB> list = new List<MB>();
        public override string DATA_FILENAME
        {
            get { return "mbstorage.dat"; }
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
    }
}
