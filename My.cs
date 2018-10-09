using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs5
{
	public delegate int SortType();
	public delegate bool Boolean(object a, student i);

	class Db
	{
		public List<student> DBase = new List<student>();
		
		public Db(string Path)
		{
			StreamReader sr = new StreamReader(Path, Encoding.UTF8);
			while (!sr.EndOfStream)
			{
				try
				{
					string[] s = sr.ReadLine().Split(' ');

					DBase.Add(new student(s));
				}
				catch{	}			
			}
		}

		/// <summary>
		/// Выводит на экрвн бд
		/// </summary>
		public void Write()
		{
			foreach (student i in DBase)
			{
				i.Write();
				Console.WriteLine();
			}
		}

		/// <summary>
		/// Возвращает количество элесентов подходщих под
		/// </summary>
		/// <param name="bl"></param> признаку по которому будет выполнена сортировка
		/// <param name="a"></param> и его значение 
		/// <returns></returns>
		public int Count(Boolean bl, object a)
		{
			int n = 0;
			foreach (student i in DBase)
			{
				if (bl(a,i)) { n++; }
			}
			return n;
		}

		public bool Age(object a, student i)
		{
			return i.age == Convert.ToInt16(a);
		}

		public bool Course(object a, student i)
		{
			return i.course == Convert.ToInt16(a);
		}

		public bool University(object a, student i)
		{
			return i.university == Convert.ToString(a);
		}

		public bool City(object a, student i)
		{
			return i.city == Convert.ToString(a);
		}

		public bool Faculty(object a, student i)
		{
			return i.faculty == Convert.ToString(a);
		}

		/// <summary>
		/// Сортирует бд
		/// </summary>
		/// <param name="type"></param> по типу
		public void Sort(SortType type)
		{
			List<student> tempo = new List<student>();

			for (int n = type(); DBase.Count != 0; n++)
			{
				for (int i = 0; i < DBase.Count; i++)
				{
					if (n == DBase[i].age || n == DBase[i].course) //С этой строчкой нужно что-нибудь сделать
					{
						tempo.Add(DBase[i]);
						DBase.RemoveAt(i);
						i--;
					}
				}
			}
			DBase = tempo;
		}

		/// <summary>
		/// находит минимальный возраст
		/// </summary>
		/// <returns></returns>
		public int ByAge()
		{
			int min = DBase[0].age;

			foreach (student i in DBase)
			{
				if (i.age < min) { min = i.age; }
			}
			return min;
		}

		///Находит минимальный курс
		public int ByCourse()
		{
			int min = DBase[0].course;

			foreach (student i in DBase)
			{
				if (i.course < min) { min = i.course; }
			}
			return min;
		}
	}
}

