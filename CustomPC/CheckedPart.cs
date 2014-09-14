using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    abstract class CheckedPart :Part, ISocket
    {
        string socket;

        abstract public void isSocketCompatible();
    }
}
