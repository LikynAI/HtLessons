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
		/// <summary>
		/// проверяет логин
		/// </summary>
		/// <param name="login"></param>
		/// <returns></returns>
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


		/// <summary>
		/// проверяет логин с помощью регулярных выражений
		/// </summary>
		/// <param name="login"></param>
		/// <returns></returns>
		public static bool chek2(string login)
		{
			Regex regex = new Regex("^[a-zA-Zа-яА-Я0-9][a-zA-Zа-яА-Я0-9]{1,10}$");
			return regex.IsMatch(login);
		}
	}
}
