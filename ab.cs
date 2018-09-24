using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs2
{
	class Program
	{
		

		static void Main(string[] args)
		{
			Task1();
			Task2();
			Task3();
			Task4();
			Task5();
			Task6();
			Task7(1,7);

			Console.ReadLine();
		}

		private static void Task1()
		{
			Console.WriteLine("Введите три числа.");
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			int c = Convert.ToInt32(Console.ReadLine());

			if (a > b && a > c)
			{
				Console.WriteLine(a + " - наибольшее число");
			}
			else if (b > c)
			{
				Console.WriteLine(b + " - наибольшее число");
			}
			else
			{
				Console.WriteLine(c + " - наибольшее число");
			}
		}

		private static void Task2()
		{
			Console.WriteLine("Введите число.");
			string a = Console.ReadLine();

			if ( a.Length % 10 == 1 && a.Length % 100 != 11 )
			{
				Console.WriteLine("Это число состоит из " + a.Length + (" знака."));
			}
			else
			{
				Console.WriteLine("Это число состоит из " + a.Length + (" знаков."));
			}

		}
		private static void Task3()
		{
			string i = "";
			while (i != "0")
			{
				Console.Clear();
				Console.WriteLine("Введите 0");
				i = Console.ReadLine();
			}
		}

		private static void Task4()
		{
			int i = 0;
			do
			{
				Console.Clear();

				Console.Write("Логин: ");
				string login = Console.ReadLine();

				Console.Write("Пароль: ");
				string password = Console.ReadLine();

				if (login == "root" && password == "GeekBrains")
				{
					break;
				}
				i++;
				Console.WriteLine("Invalid Password or Login.");
				Console.ReadLine();
			} while (i < 3);

			if (i == 3)
			{
				Console.WriteLine("Доступ заблокирован!");
			}
			else
			{
				Console.WriteLine("Добро пожаловать");
			}
		}
		private static void Task5()
		{
			Console.WriteLine("Введите свой рост в метрах. ");
			double h = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите свой вес. ");
			double m = Convert.ToDouble(Console.ReadLine());

			double Indx = m / (h * h);

			if (Indx < 18.5)
			{
				Console.WriteLine("Вам нужно набрать " + (18.5 * (h * h) - m) + " кг ");
			}
			else if (Indx > 25)
			{
				Console.WriteLine("Вам нужно сбросить " + (m - 25 * (h * h)) + " кг");
			}
			else
			{
				Console.WriteLine("Ваш вес в пределах нормы");
			}
			Console.WriteLine("При вашем росте, с должен быть в педелах от " + 18.5 * (h * h) + " до " + 25 * (h * h));
		}

		private static void Task6()
		{
			DateTime start = DateTime.Now;
			int GoodNumbers = 0;

			for (int i = 1; i <= 1000000000; i++)
			{
				int sumi = 0;
				string stri = i.ToString();
				foreach (char cnumber in stri)
				{
					int number = Convert.ToInt32(Convert.ToString(cnumber));
					sumi = sumi + number; 
				}
				if (i % sumi == 0)
				{
					Console.WriteLine(i);
					GoodNumbers++;
				}
			}
			Console.WriteLine("Таких чисел " + GoodNumbers);

			DateTime end = DateTime.Now;
			Console.WriteLine(end - start);
		}

		public static int sum = 0;

		private static void Task7(int a, int b )
		{
			if (a <= b)
			{
				Console.WriteLine(sum);
				sum = sum+ a;
				Task7(a+1,b);
			}
		}
		
	}
}

