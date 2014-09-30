using System;

namespace CustomPC
{
	[Serializable]
	class GPU : CheckedPart
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public int Speed { get; set; }
		public int Memory { get; set; }

		public GPU(string name, string type, int speed, int memory)
		{
			Name = name;
			Type = type;
			Speed = speed;
			Memory = memory;
		}

		public override bool isSocketCompatible(string socket)
		{
			return (Type == socket);
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
