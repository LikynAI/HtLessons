using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeruNeveru
{
	class Question
	{
		/// <summary>
		/// Массив содержащий вопросы
		/// </summary>
		public string[] Q { get; private set; }

		/// <summary>
		/// Массив содержащий ответы
		/// </summary>
		private static string[] A { get; set; }

		/// <summary>
		/// Переменная для подсчета колличества очков
		/// </summary>
		public int score { get; private set; }

		/// <summary>
		/// Загружает Вопросы и ответы из файлов
		/// </summary>
		/// <param name="path"></param> путь к файлу содержащему вопросы
		/// <param name="path2"></param> путь к файлу содержащему ответы
		public Question(string path1, string path2)
		{
			Q = File.ReadAllLines(path1, Encoding.UTF8);
			A = File.ReadAllLines(path2, Encoding.UTF8);
			score = 0;
		}

		/// <summary>
		/// Задает вопрос
		/// </summary>
		/// <param name="qn"></param> номер строки в которой содержится вопрос
		public void AskQ(int qn)
		{
			Console.WriteLine(Q[qn]);
			AnswerQ(GetUsersAnswer(), qn);
		}

		public string GetUsersAnswer()
		{
			Console.WriteLine("Введите + или -");

			string UsersA = string.Empty;
			while (UsersA != "-" && UsersA != "+")
			{
				UsersA = Console.ReadLine();
			}
			return UsersA;
		}

		public void AnswerQ(string UsersA, int qn)
		{
			if (UsersA == A[qn])
			{
				Console.WriteLine("И... Это правильный ответ!\n");
				score++;
			}
			else
			{
				Console.WriteLine("Неа...\n");
			}
		}
	}
}
