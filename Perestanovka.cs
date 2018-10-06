using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Perestanovka
	{
		/// <summary>
		/// первый вариант проверки не я вляется ли 
		/// </summary>
		/// <param name="a"></param> а
		/// <param name="b"></param> перестановкой б
		/// <returns></returns>
		public static bool Comparing1(string a, string b)
		{
			if (a.Length != b.Length) { return false; }

			StringBuilder sba = new StringBuilder(a);
			StringBuilder sbb = new StringBuilder(b);

			for (int i = 0; i < a.Length; i++)
			{
				int tempo = sba.ToString().IndexOf(sbb[0]);
				if (tempo != -1)
				{
					sbb.Remove(0, 1);
					sba.Remove(tempo, 1);
				}
				else
				{
					return false;
				}
			}
			return true;
		}

		static char[] SortString(string str)
		{
			str.ToLower();
			char[] word = str.ToCharArray();
			Array.Sort(word);
			return word;
		}

		/// <summary>
		/// второй вариант проверки не я вляется ли 
		/// </summary>
		/// <param name="a"></param> а
		/// <param name="b"></param> перевстановкой б
		/// <returns></returns>
		public static bool Comparing2 (string a, string b)
		{
			if (a.Length != b.Length)
			{
				return false;
			}
			char[] chars1 = SortString(a);
		char[] chars2 = SortString(b);

			for (int i = 0; i<a.Length; i++)
			{
				if (chars1[i] != chars2[i])
				{
					return false;
				}
			}
			return true;
		}
		
	}
}
