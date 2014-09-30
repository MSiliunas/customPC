namespace CustomPC
{
	class PC
	{
		public PcPrerequisites prerequisites;
		CPU _cpu;
		MB _mb;
		RAM _ram;
		GPU _gpu;
		HDD _hdd;

		public CPU Cpu
		{
			get { return _cpu; }
			set { _cpu = value; }
		}

		public MB Mb
		{
			get { return _mb; }
			set { _mb = value; }
		}

		public RAM Ram
		{
			get { return _ram; }
			set { _ram = value; }
		}

		public GPU Gpu
		{
			get { return _gpu; }
			set { _gpu = value; }
		}

		public HDD Hdd
		{
			get { return _hdd; }
			set { _hdd = value; }
		}
	}
}
