using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class PasswordCheker
	{
		public static bool chek(string login)
		{
			StringBuilder p = new StringBuilder(login);
			if (2 <= p.Length && p.Length <= 10)
			{
				for (int i = 0; i < p.Length; i++)
				{
					if (char.IsLetter(p[i]) && char.IsDigit(p[i])) { return false; }
				}
				return true;
			}
			else { return false; }
		}
		static char[] SortString(string str)
		{
			str.ToLower();
			char[] word = str.ToCharArray();
			Array.Sort(word);
			return word;
		}
		static bool Equal(string word1, string word2)
		{
			if (word1.Length != word2.Length)
			{
				return false;
			}
			char[] w1 = SortString(word1);
			char[] w2 = SortString(word2);
			for (int i = 0; i < word1.Length; i++)
			{
				if (w1[i] != w2[i])
				{
					return false;
				}
			}
			return true;
		}

		public static bool chek2(string login)
		{
			Regex regex = new Regex("^[a-zA-Zа-яА-Я0-9][a-zA-Zа-яА-Я0-9]{1,10}$");
			return regex.IsMatch(login);
		}
	}
}
