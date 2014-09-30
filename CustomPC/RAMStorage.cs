using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace CustomPC
{
	class RAMStorage : Storage
	{
		private List<RAM> _list = new List<RAM>();
		public override string DataFilename
		{
			get { return "ramstorage.dat"; }
		}

		public RAMStorage()
		{
			Load();
		}

		public override void Add(object obj)
		{
			if (obj.GetType() == typeof(RAM))
			{
				_list.Add((RAM)obj);
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

						_list = (List<RAM>)bin.Deserialize(crStream);

						crStream.Close();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		public List<string> GetAllTypes()
		{
			List<string> ramTypes = new List<string>();

			foreach (RAM ram in _list)
			{
				if (!ramTypes.Contains(ram.Type))
				{
					ramTypes.Add(ram.Type);
				}
			}

			return ramTypes;
		}

		public List<string> GetAllSpeeds()
		{
			List<string> speedsList = new List<string>();

			foreach (RAM ram in _list)
			{
				if (!speedsList.Contains(Convert.ToString(ram.Speed)))
				{
					speedsList.Add(Convert.ToString(ram.Speed));
				}
			}

			return speedsList;
		}

		public List<RAM> GetAll()
		{
			return this._list;
		}
	}
}
