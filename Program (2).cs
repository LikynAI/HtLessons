using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs5
{
	class Program
	{
		static void Main(string[] args)
		{
			Db students= new Db("db.txt");
			Console.WriteLine(students.Count(students.Age, 20));
			Console.WriteLine(students.Count(students.City, "Москва"));

			students.Sort(students.ByAge);
			students.Sort(students.ByCourse);

			students.Write();

			Console.ReadLine();
		}
	}
}
