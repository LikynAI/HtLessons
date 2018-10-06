using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs4
{
	class Program
	{
		static void Main(string[] args)
		{
			Arr2 a = new Arr2(Environment.GetFolderPath
(Environment.SpecialFolder.MyDocuments) + "\\arr.txt");
			int b = a.MaxOf();
			int column;
			int line;
			a.IndexOf(b, out column, out line);
			Console.WriteLine(b);
			Console.WriteLine(a.arr[column,line]);
			Console.ReadLine();
		}
	}
}
