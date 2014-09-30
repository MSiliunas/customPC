using System;

namespace CustomPC
{
	[Serializable]
	class MB : CheckedPart
	{
		public string Name { get; set; }
		public string CpuSocket { get; set; }
		public string RamType { get; set; }
		public string GpuType { get; set; }
		public bool IntegratedGpu { get; set; }

		public MB(string name, string socket, string ram, string gpu)
		{
			Name = name;
			CpuSocket = socket;
			RamType = ram;
			GpuType = gpu;
		}

		public override bool isSocketCompatible(string socket)
		{
			return (socket == CpuSocket);
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
