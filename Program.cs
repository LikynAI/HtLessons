using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeruNeveru
{
	class Program
	{
		static void Main(string[] args)
		{
			Question q = new Question("Q.txt","A.txt");

			for (int i = 0; i < q.Q.Length;i++)
			{
				q.AskQ(i);
			}
			Console.WriteLine($"Ты набрал {q.score} очка/ов!");
		}
	}
}
