using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace CustomPC
{
	class GPUStorage : Storage
	{
		private List<GPU> _list = new List<GPU>();
		public override string DataFilename
		{
			get { return "gpustorage.dat"; }
		}

		public GPUStorage()
		{
			Load();
		}

		public override void Add(object obj)
		{
			if (obj.GetType() == typeof(GPU))
			{
				_list.Add((GPU)obj);
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

						_list = (List<GPU>)bin.Deserialize(crStream);

						crStream.Close();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		public List<GPU> GetAll()
		{
			return _list;
		}
	}
}
