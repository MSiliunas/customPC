using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace CustomPC
{
	class MBStorage : Storage
	{
		private List<MB> _list = new List<MB>();
		public override string DataFilename
		{
			get { return "mbstorage.dat"; }
		}

		public MBStorage()
		{
			Load();
		}

		override public void Add(Object obj)
		{
			if (obj.GetType() == typeof(MB))
			{
				_list.Add((MB)obj);
				Save(_list);
			}
		}

		public override void Load()
		{
			if ((File.Exists(DataFilename)) && (new FileInfo(DataFilename).Length != 0))
			{
				try
				{
					using (Stream stream = File.Open(DataFilename, FileMode.Open))
					using (DESCryptoServiceProvider crypt = new DESCryptoServiceProvider())
					{
						BinaryFormatter bin = new BinaryFormatter();


						crypt.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
						crypt.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

						CryptoStream crStream = new CryptoStream(stream,
	crypt.CreateDecryptor(), CryptoStreamMode.Read);

						_list = (List<MB>)bin.Deserialize(crStream);

						crStream.Close();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		public List<string> GetAllSockets()
		{
			List<string> socketList = new List<string>();

			foreach (MB mb in _list)
			{
				if (!socketList.Contains(mb.CpuSocket))
				{
					socketList.Add(mb.CpuSocket);
				}
			}

			return socketList;
		}

		public List<string> GetAllRamTypes()
		{
			List<string> ramTypeList = new List<string>();

			foreach (MB mb in _list)
			{
				if (!ramTypeList.Contains(mb.RamType))
				{
					ramTypeList.Add(mb.RamType);
				}
			}

			return ramTypeList;
		}

		public List<string> GetAllGpuTypes()
		{
			List<string> gpuTypeList = new List<string>();

			foreach (MB mb in _list)
			{
				if (!gpuTypeList.Contains(mb.GpuType))
				{
					gpuTypeList.Add(mb.GpuType);
				}
			}

			return gpuTypeList;
		}

		public List<MB> GetAll()
		{
			return this._list;
		}
	}
}
