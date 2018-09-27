using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs3._3
{
	class Program
	{
		static void Main(string[] args)
		{
			Complex cmp1 = new Complex(1, 2);
			Complex cmp2 = new Complex(7, 3);

			Complex.Print(Complex.Multiplication(cmp2, cmp1));
			Console.ReadLine();
		}
	}
	public class Complex
	{
		int re;
		int im;

		public Complex(int _re, int _im) 
		{
			re = _re;
			im = _im;
		}

		public static void Print(Complex complex)
		{
			Console.WriteLine($"{complex.re}+{complex.im}i");
		}

		public static Complex Plus(Complex complex1, Complex complex2)
		{
			int re = complex1.re + complex2.re;
			int im = complex1.im + complex2.im;
			Complex sum = new Complex(re, im);
			return sum;
		}

		public static Complex Minus(Complex complex1, Complex complex2)
		{
			int re = complex1.re - complex2.re;
			int im = complex1.im - complex2.im;
			Complex difference = new Complex(re, im);
			return difference;
		}

		public static Complex Multiplication(Complex complex1, Complex complex2)
		{
			int re = complex1.re * complex2.re - complex1.im * complex2.im;
			int im = complex1.im * complex2.re + complex1.re * complex2.im;
			Complex solution = new Complex(re, im);
			return solution;
		}

		public static Complex Devide(Complex complex1, Complex complex2)
		{
			int tempo = complex2.re * complex2.re + complex2.im * complex2.im;
			int re = (complex1.re * complex2.re + complex1.im * complex2.im) / tempo;
			int im = (complex1.im * complex2.re - complex1.re * complex2.im) / tempo;
			Complex solution = new Complex(re, im);
			return solution;
		}

	}
}
