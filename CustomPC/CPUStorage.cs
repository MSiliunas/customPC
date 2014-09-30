using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace CustomPC
{
	class CPUStorage : Storage
	{
		private List<CPU> _list = new List<CPU>();
		public override string DataFilename
		{
			get { return "cpustorage.dat"; }
		}

		public CPUStorage()
		{
			Load();
		}

		override public void Add(object obj)
		{
			if (obj.GetType() == typeof(CPU))
			{
				_list.Add((CPU)obj);
				Save(_list);
			}
		}

		override public void Load()
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

						this._list = (List<CPU>)bin.Deserialize(crStream);

						crStream.Close();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		public List<String> GetAvailableSockets()
		{
			List<String> socketList = new List<String>();

			foreach (CPU cpu in _list)
			{
				if (!socketList.Contains(cpu.Socket))
				{
					socketList.Add(cpu.Socket);
				}
			}
			return socketList;
		}

		public List<CPU> GetAll()
		{
			return _list;
		}
	}
}
