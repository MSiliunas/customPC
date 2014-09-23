using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    [Serializable]
    class RAM :CheckedPart
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public int Speed { get; set; }

        public RAM(string name, string type, int size, int speed)
        {
            this.Name = name;
            this.Type = type;
            this.Size = size;
            this.Speed = speed;
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
