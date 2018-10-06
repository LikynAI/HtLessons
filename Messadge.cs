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

		public Messadge(string path)
		{
			sr = new StreamReader(path);
			string text = sr.ReadToEnd();
			words = text.Split();
		}

		public static void deletchar(string[] words, char letter)
		{
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i][words[i].Length - 1] == letter)
				{
					words[i] = string.Empty; 
				}
			}
		}

		public static void WriteLessThan(string[] words, int n)
		{
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].Length < n)
				{
					Console.Write(words[i] + " ");
				}
			}
		}

		public static int LongestWord(string[] words)
		{
			string tempo = string.Empty;

			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].Length > tempo.Length) { tempo = words[i]; }
			}
			return tempo.Length;
		}


		public static StringBuilder LongWordsSentence(string[] words)
		{
			StringBuilder lws = new StringBuilder();

			int lenght = LongestWord(words);
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].Length == lenght) { lws.Append(words[i] + " "); }
			}
			Console.WriteLine(lws.ToString());
			return lws;
		}

		public void print()
		{
			for (int i = 0; i < words.Length; i++)
			{
				Console.Write(words[i] + " "); 
			}
		}
	}
}
