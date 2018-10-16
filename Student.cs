using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlApp
{
	public class Student
	{
		public static List<Student> StList = new List<Student>();

		public string Name;
		public string SecondName;
		public int age;

		public Student(string Name, string SecondName, int age)
		{
			this.Name = Name;
			this.SecondName = SecondName;
			this.age = age;
		}
		public Student() { }
	}
}
