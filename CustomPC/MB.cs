using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    [Serializable]
    class MB :CheckedPart
    {
        public string Name { get; set; }
        public string CpuSocket { get; set; }
        public string RamType { get; set; }
        public string GpuType { get; set; }
        public bool IntegratedGpu { get; set; }

        public MB(string name, string socket, string ram, string gpu)
        {
            this.Name = name;
            this.CpuSocket = socket;
            this.RamType = ram;
            this.GpuType = gpu;
        }

        public override bool isSocketCompatible(string socket)
        {
            return (socket == CpuSocket ? true : false);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
