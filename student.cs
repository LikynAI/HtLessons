using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs5
{
	public class student
	{
		public string lastName;
		public string firstName;
		public string university;
		public string faculty;
		public int course;
		public string department;
		public int group;
		public string city;
		public int age;

		public student(string firstName, string lastName, string university,
		string faculty, string department, int age, int course, int group, string city)
		{
			this.lastName = lastName;
			this.firstName = firstName;
			this.university = university;
			this.faculty = faculty;
			this.department = department;
			this.course = course;
			this.age = age;
			this.group = group;
			this.city = city;
		}

		/// <summary>
		/// Конструктор класса student принимающий в качастве аргумента массив
		/// </summary>
		/// <param name="s"></param> 
		public student(string[] s)
		{
			lastName = s[0];
			firstName = s[1];
			university = s[2];
			faculty = s[3];
			department = s[4];
			course = Convert.ToInt16(s[5]);
			age = Convert.ToInt16(s[6]);
			group = Convert.ToInt16(s[7]);
			city = s[8];
		}

		public void Write()
		{
			Console.WriteLine($"Имя - {firstName} Фамилия - {lastName} Университет - {university} Факультет - {faculty} " + "\n" +
				$"Департамент - {department} Возраст - {age} Курс - {course} Группа - {group} Город -{city}");
		}

}

}

