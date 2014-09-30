using System;

namespace CustomPC
{
	[Serializable]
	class CPU : CheckedPart
	{
		public double Clockspeed { get; set; }
		public int Cores { get; set; }
		public string Socket { get; set; }
		public string Name { get; set; }

		public CPU(string name, string socket, double speed, int cores)
		{
			Socket = socket;
			Clockspeed = speed;
			Name = name;
			Cores = cores;
		}

		override public bool isSocketCompatible(string socket)
		{
			return (Socket == socket);
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
