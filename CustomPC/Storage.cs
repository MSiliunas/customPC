using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    abstract class Storage
    {
        public abstract string DATA_FILENAME {get;}
        //private List<object> list;

        public Storage()
        {
           // Load();
        }

        public abstract void Add(Object obj);
        public abstract void Load();

        public void Save(Object list)
        {
            try
            {
                using (Stream stream = File.Open(DATA_FILENAME, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, list);
                }
            }
            catch (IOException)
            {
            }
        }
    }
}
