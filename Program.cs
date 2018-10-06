using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{

			Messadge m = new Messadge((Environment.GetFolderPath
			(Environment.SpecialFolder.MyDocuments) + "\\log.txt"));

			m.print();
			Console.WriteLine();

			Messadge.LongWordsSentence(m);
			Console.WriteLine();

			Messadge.WriteLessThan(m, 5);
			Console.WriteLine("\n");

			Messadge.deletchar(m, 'e');
			m.print();

			Console.ReadLine();


		}
	}
}
