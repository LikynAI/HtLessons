using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Perestanovka
	{
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

		public static bool Comparing2 (string word1, string word2)
		{
			if (word1.Length != word2.Length)
			{
				return false;
			}
			char[] chars1 = SortString(word1);
		char[] chars2 = SortString(word2);

			for (int i = 0; i<word1.Length; i++)
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
