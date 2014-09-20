﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    [Serializable]
    abstract class CheckedPart :Part, ISocket
    {
        abstract public bool isSocketCompatible(string socket);
    }
}
