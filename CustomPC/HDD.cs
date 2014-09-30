using System;

namespace CustomPC
{
	[Serializable]
	class HDD : CheckedPart
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Connector { get; set; }
		public int Size { get; set; }

		public HDD(string name, string type, string connector, int size)
		{
			Name = name;
			Type = type;
			Connector = connector;
			Size = size;
		}

		public override bool isSocketCompatible(string socket)
		{
			return (Connector == socket);
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
