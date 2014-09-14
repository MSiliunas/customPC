using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class CPU :CheckedPart
    {
        string socket;
        public string Socket
        {
            get { return socket; }
            set { socket = value; }
        }

        public CPU(string socket)
        {
            this.socket = socket;
        }

        override public void isSocketCompatible()
        {

        }
    }
}
