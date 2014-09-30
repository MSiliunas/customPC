using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace CustomPC
{
	abstract class Storage
	{
		public abstract string DataFilename { get; }
		//private List<object> list;

		public abstract void Add(Object obj);
		
		public abstract void Load();

		public void Save(Object list)
		{
			try
			{
				using (Stream stream = File.Open(DataFilename, FileMode.Create))
				{
					BinaryFormatter bin = new BinaryFormatter();
					DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();

					crypt.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
					crypt.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

					CryptoStream crstream = new CryptoStream(stream, crypt.CreateEncryptor(), CryptoStreamMode.Write);

					bin.Serialize(crstream, list);

					crstream.Close();
				}
			}
			catch (IOException)
			{
			}
		}
	}
}
