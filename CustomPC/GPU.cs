using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    [Serializable]
    class GPU :CheckedPart
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Speed { get; set; }
        public int Memory { get; set; }

        public GPU(string name, string type, int speed, int memory)
        {
            this.Name = name;
            this.Type = type;
            this.Speed = speed;
            this.Memory = memory;
        }

        public override bool isSocketCompatible(string socket)
        {
            return (this.Type == socket ? true : false);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
