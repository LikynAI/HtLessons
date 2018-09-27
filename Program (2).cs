using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs3_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int n;
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Вводите числа");

				string i = Console.ReadLine();
				if (Int32.TryParse(i, out n))
				{
					if (n % 2 == 1)
					{
						sum += n;
					}
					else if (n == 0)
					{
						break;
					}
				}
				else
				{
					Console.WriteLine(i + " нея вляется числом.");
					Console.ReadLine();
				}
			}
			Console.WriteLine(sum);
			Console.ReadLine();
		}
	}
}
