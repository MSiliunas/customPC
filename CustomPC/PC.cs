using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class PC
    {
        public PcPrerequisites prerequisites;
        CPU cpu;
        MB mb;
        RAM ram;
        GPU gpu;
        HDD hdd;

        public CPU Cpu
        {
            get
            {
                return cpu;
            }
            set
            {
                cpu = value;
            }
        }

        public MB Mb
        {
            get
            {
                return mb;
            }
            set
            {
                mb = value;
            }
        }
    }
}
