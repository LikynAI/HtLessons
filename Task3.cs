using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HtLs4
{
	class Task3
	{
		

		public static void Task()
		{
			
			int i = 0;
			while (i < 3)
			{
				string[] Base = LoadBase(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\log.txt");
				Console.Clear();

				Console.Write("Логин: ");
				string login = " " + Console.ReadLine();

				Console.Write("Пароль: ");
				string password = " " + Console.ReadLine();

				if ( Array.IndexOf(Base,login + password) != -1 )
				{
					break;
				}
				i++;
				Console.WriteLine("Invalid Password or Login.");
				Console.ReadLine();
			}

			if (i == 3)
			{
				Console.WriteLine("Доступ заблокирован!");
			}
			else
			{
				Console.WriteLine("Добро пожаловать!");
			}
		}

		private static string[] LoadBase(string path)
		{
			string text = File.ReadAllText(path);
			string[] Base = text.Split(';'); //допустим в файле храняться паралоли в формате " ккщщ щщкщ; root GeekBrains; qwrrq qrqw; "
			return Base;
		}
	}
}
