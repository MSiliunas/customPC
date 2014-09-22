using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexNumber
{
    struct Complex
    {
        public double number;
        public double index;

        public Complex(double number, double index)
        {
            this.number = number;
            this.index = index;
        }

        public static Complex operator +(Complex num1, Complex num2)
        {
            return new Complex(num1.number + num2.number, num1.index + num2.index);
        }

        public static Complex operator -(Complex num1, Complex num2)
        {
            return new Complex(num1.number - num2.number, num1.index - num2.index);
        }

        public static Complex operator *(Complex num1, Complex num2)
        {
            return new Complex(num1.number * num2.number - num1.index * num2.index, num1.number * num2.index + num2.number * num1.index);
        }

        public static Complex operator /(Complex num1, Complex num2)
        {
            return new Complex((num1.number * num2.number + num1.index * num2.index) / (num2.number * num2.number + num2.index * num2.index), (num1.index * num2.number - num1.number * num2.index) / (num2.number * num2.number + num2.index * num2.index));
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", number, index));
        }

        static void Main(string[] args)
        {
            Complex num1 = new Complex(1, 2);
            Complex num2 = new Complex(3, 4);
            Complex sum = num1 + num2;
            Console.WriteLine("suma {0}", sum);
            Complex atim = num1 - num2;
            Console.WriteLine("atimtis {0}", atim);
            Complex daug = num1 * num2;
            Console.WriteLine("daugyba {0}", daug);
            Complex dal = num1 / num2;
            Console.WriteLine("dalyba {0}", dal);
        }
    }
}
