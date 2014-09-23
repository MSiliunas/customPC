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

        public RAMStorage()
        {
            Load();
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

        public List<string> GetAllTypes()
        {
            List<string> ramTypes = new List<string>();

            foreach (RAM ram in list)
            {
                if (!ramTypes.Contains(ram.Type))
                {
                    ramTypes.Add(ram.Type);
                }
            }

            return ramTypes;
        }

        public List<string> GetAllSpeeds()
        {
            List<string> speedsList = new List<string>();

            foreach (RAM ram in list)
            {
                if (!speedsList.Contains(Convert.ToString(ram.Speed)))
                {
                    speedsList.Add(Convert.ToString(ram.Speed));
                }
            }

            return speedsList;
        }

        public List<RAM> GetAll()
        {
            return this.list;
        }
    }
}
