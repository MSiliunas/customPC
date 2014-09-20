using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class RAMStorage :Storage
    {
        public override string DATA_FILENAME
        {
            get { throw new NotImplementedException(); }
        }

        public override void Add(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
