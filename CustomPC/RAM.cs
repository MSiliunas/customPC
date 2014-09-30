using System;

namespace CustomPC
{
	[Serializable]
	class RAM : CheckedPart
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public int Size { get; set; }
		public int Speed { get; set; }

		public RAM(string name, string type, int size, int speed)
		{
			Name = name;
			Type = type;
			Size = size;
			Speed = speed;
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
