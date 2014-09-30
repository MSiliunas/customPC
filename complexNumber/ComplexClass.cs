using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexNumber
{
	class ComplexClass : IComparable
	{
		private Complex num { get; set; }

		public ComplexClass(Complex c)
		{
			num = c;
		}

		public int CompareTo(object obj)
		{
			Complex comp = ((ComplexClass)obj).num;

			if ((num._index > comp._index && num._number > comp._number) || (num._index < comp._index && num._number < comp._number) || (num._index == comp._index && num._number == comp._number))
			{
				if (num._index > comp._index && num._number > comp._number)
				{
					return 1;
				}
				else if (num._index < comp._index && num._number < comp._number)
				{
					return -1;
				}
				else if (num._index == comp._index && num._number == comp._number)
				{
					return 0;
				}
				else
				{
					throw new ArgumentException("Duomenys nepalyginami.");
				}
			}
			else
			{
				throw new ArgumentException("Duomenys nepalyginami.");
			}
		}

		static void Main(string[] args)
		{
			Complex num1 = new Complex(3, 4);
			Complex num2 = new Complex(3, 4);

			Complex sum = num1 + num2;
			Console.WriteLine("suma {0}", sum);
			Complex atim = num1 - num2;
			Console.WriteLine("atimtis {0}", atim);
			Complex daug = num1 * num2;
			Console.WriteLine("daugyba {0}", daug);
			

			ComplexClass a = new ComplexClass(num1);
			ComplexClass b = new ComplexClass(num2);

			try
			{
				Complex dal = num1 / num2;
				Console.WriteLine("dalyba {0}", dal);

				switch (a.CompareTo(b))
				{
					case 1:
						Console.WriteLine("A > B");
						break;
					case -1:
						Console.WriteLine("A < B");
						break;
					case 0:
						Console.WriteLine("A == B");
						break;
				}
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
