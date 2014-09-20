using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class GPUStorage :Storage
    {
        public override void Add(object obj)
        {
            throw new NotImplementedException();
        }

        public override string DATA_FILENAME
        {
            get { throw new NotImplementedException(); }
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
