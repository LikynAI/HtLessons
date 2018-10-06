using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Messadge
	{
		StreamReader sr { get; set; }
		public string[] words { get; set; }

		/// <summary>
		/// Конструктор класса Messadge 
		/// принимающий в качестве аргумента путь к текстовому файлу
		/// </summary>
		/// <param name="path"></param>
		public Messadge(string path)
		{
			sr = new StreamReader(path);
			string text = sr.ReadToEnd();
			words = text.Split();
		}

		/// <summary>
		/// Удаляет слова
		/// </summary>
		/// <param name="m"></param> из класса меседж
		/// <param name="letter"></param>  заканчивающиеся на букву
		public static void deletchar(Messadge m, char letter)
		{
			for (int i = 0; i < m.words.Length; i++)
			{
				if (m.words[i][m.words[i].Length - 1] == letter)
				{
					m.words[i] = string.Empty; 
				}
			}
		}

		/// <summary>
		/// Выводит на консоль слова 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="n"></param> чья длина меньше n
		public static void WriteLessThan(Messadge m, int n)
		{
			for (int i = 0; i < m.words.Length; i++)
			{
				if (m.words[i].Length < n)
				{
					Console.Write(m.words[i] + " ");
				}
			}
		}

		/// <summary>
		/// Находит самое длиное слово, возвращает его размер и выводит на консоль 
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		public static int LongestWord(Messadge m)
		{
			string tempo = string.Empty;

			for (int i = 0; i < m.words.Length; i++)
			{
				if (m.words[i].Length > tempo.Length) { tempo = m.words[i]; }
			}
			return tempo.Length;
		}

		/// <summary>
		/// Составляет предложение из самых длиных слов
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		public static StringBuilder LongWordsSentence(Messadge m)
		{
			StringBuilder lws = new StringBuilder();

			int lenght = LongestWord(m);
			for (int i = 0; i < m.words.Length; i++)
			{
				if (m.words[i].Length == lenght) { lws.Append(m.words[i] + " "); }
			}
			Console.WriteLine(lws.ToString());
			return lws;
		}

		/// <summary>
		/// выводит на консоль данные из класса Messadge
		/// </summary>
		public void print()
		{
			for (int i = 0; i < words.Length; i++)
			{
				Console.Write(words[i] + " "); 
			}
		}
	}
}
