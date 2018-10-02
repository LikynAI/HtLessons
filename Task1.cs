using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs4
{
	class Task1
	{
		public static void Task()
		{
			Random random = new Random();
			int[] vs = new int[20];

			for (int i = 0; i < vs.Length; i++)
			{
				vs[i] = random.Next(-10000, 10000);
			}

			int Result = 0;

			for (int i = 0; i < vs.Length - 1; i++)
			{
				if (vs[i] % 3 == 0 || vs[i + 1] % 3 == 0)
				{
					Result++;
				}
			}
			Console.WriteLine(Result + "\n");

			for (int i = 0; i < vs.Length; i++)
			{
				Console.WriteLine(vs[i]);
			}

			Console.ReadLine();
		}
		public static void couples(int[] vs)
		{
			int Result = 0;

			for (int i = 0; i < vs.Length - 1; i++)
			{
				if (vs[i] % 3 == 0 || vs[i + 1] % 3 == 0)
				{
					Result++;
				}
			}
		}
	}
}
