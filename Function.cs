using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs5
{


	class Function
	{
		public delegate void WhatToDo(Fun F, double x, double b);

		public delegate double Fun(double x);

		public static Fun ChoseFun()
		{
			Console.WriteLine("Выберите функцию x3, x2, x, xminus1(означает 1/x) или sinx");
			while (true)
			{
				string name = Console.ReadLine();
				switch (name)
				{
					case "x2": return x2;
					case "x3": return x3;
					case "xminus1": return xminus1;
					case "sinx": return sinx;
					case "x": return x;
				}
			}
		}


		public static void Do()
		{
			Console.WriteLine("Выберите метод. Table - выводит таблицу, minf выводит минимальное значение на отрезке, zeros - выводит нули функции на промежутке.");

			string name = string.Empty;
			while (name != "Table" && name != "zeros" && name != "minf")
			{
				name = Console.ReadLine();
			}

			Console.WriteLine("Введите два числа разделенных пробелом которые будут определять промежуток функции.");
			string[] Prom = Console.ReadLine().Split();

			switch (name)
			{
				case "Table": Table(ChoseFun(), Convert.ToDouble(Prom[0]), Convert.ToDouble(Prom[1])); break;
				case "minf": minf(ChoseFun(), Convert.ToDouble(Prom[0]), Convert.ToDouble(Prom[1])); break;
				case "zeros": zeros(ChoseFun(), Convert.ToDouble(Prom[0]), Convert.ToDouble(Prom[1])); break;
			}
			Console.ReadLine();
		}

		public static void zeros(Fun F, double x, double b)
		{
			Console.WriteLine("----- X ----- Y -----");
			while (x <= b)
			{
				if (Math.Round(F(x),3) == 0)
				{
					Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, 0);
				}
				x += 0.01;
			}
			Console.WriteLine("---------------------");
		}

		public static void minf(Fun F, double x, double b)
		{
			double min = F(x);
			while (x <= b)
			{
				if (min < F(x)) { min = F(x); }
				x += 1;
			}
			Console.WriteLine($"Минимальное значение на данном отрезке равно {min}");
		}

		public static void Table(Fun F, double x, double b)
		{
			Console.WriteLine("----- X ----- Y -----");
			while (x <= b)
			{
				Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
				x += 1;
			}
			Console.WriteLine("---------------------");
		}

		public static double x3(double x)
		{
			return x * x * x;
		}

		public static double x2(double x)
		{
			return x * x;
		}

		public static double x(double x)
		{
			return x ;
		}

		public static double xminus1(double x)
		{
			if (x == 0)
			{
				return 1 / x;
			}
			else return Double.NaN;
		}

		public static double sinx(double x)
		{
			return Math.Sin(x);
		}
	}
}
