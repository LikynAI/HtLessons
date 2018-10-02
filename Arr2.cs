using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HtLs4
{
	class Arr2
	{
		public int[,] arr;

		/// <summary>
		/// создает двумерный массив указонног размера
		/// </summary>
		/// <param name="size"></param>
		/// <param name="size2"></param>
		public Arr2(int size, int size2)
		{
			Random rnd = new Random();
			arr = new int[size, size2];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = rnd.Next(-10, 10);
				}
			}
		}

		/// <summary>
		/// создает массив и заполняет его данными из файла
		/// </summary>
		/// <param name="path"></param>
		public Arr2(string path)
		{
			bool flag = true;

			while (flag)
			{
				try
				{
					flag = false;

					string text = File.ReadAllText(path);
					string[] subints = text.Split(';');

					arr = new int[subints.Length - 1, subints[0].Split(',').Length - 1];

					for (int i = 0; i < subints.Length - 1; i++)
					{
						string[] a = subints[i].Split(',');

						for (int j = 0; j < a.Length - 1; j++)
						{
							arr[i, j] = Convert.ToInt32(a[j]);
						}
					}
				}
				catch
				{
					flag = true;
					Console.WriteLine("Неверно указан  путь к файлу!");
				}
			}
		}


		/// <summary>
		/// возвращает сумму всех элементов массива
		/// </summary>
		/// <returns></returns>
		public int Sum()
		{
			int sum = 0;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					sum += arr[i, j];
				}
			}
			return sum;
		}

		/// <summary>
		/// возвращает сумму всех элементов больше заданного
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public int SumMoreThan(int a)
		{
			int sum = 0;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] > a) { sum += arr[i, j]; }
				}
			}
			return sum;
		}

		/// <summary>
		/// Возвращает минимальный элемент массива
		/// </summary>
		/// <returns></returns>
		public int MinOf()
		{
			int min = arr[1, 1];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] < min) { min = arr[i, j]; }
				}
			}
			return min;
		}

		/// <summary>
		/// Возвращает максимальный элемент массива
		/// </summary>
		/// <returns></returns>
		public int MaxOf()
		{
			int max = arr[1, 1];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] > max) { max = arr[i, j]; }
				}
			}
			return max;
		}

		/// <summary>
		/// с помощью ссылок возвращает индекс первого попавшегося элемента. 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="rang"></param>
		/// <param name="count"></param>
		public void IndexOf(int a, out int column, out int line)
		{
			column = -1;
			line = -1;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] == a)
					{
						column = i;
						line = j;
						i = arr.GetLength(0);
						break;
					}
				}
			}

		}

		/// <summary>
		/// записывает массив и сохраняет его в виде текстового файла
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="path"></param>
		public static void CreatFile(int[,] arr, string path)
		{

			string text = "";

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					text += arr[i, j] + ",";
				}
				text += ";";
			}
			File.WriteAllText(path, text);

		}
	}
}
