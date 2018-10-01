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

		public Arr2(int size, int size2)
		{
			Random rnd = new Random();
			arr = new int[size,size2];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i,j] = rnd.Next(-10,10);
				}
			}
		}

		public Arr2(string path)
		{
			string text = File.ReadAllText(path);
			string[] subints = text.Split(';');
			arr = new int[subints.Length-1, subints[0].Split(',').Length-1];

			for (int i = 0; i < subints.Length-1; i++)
			{
				string[] a = subints[i].Split(',');

				for (int j = 0; j < a.Length - 1; j++)
				{
					arr[i,j] = Convert.ToInt32(a[j]);
				}
			}
		}

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

		public int MinOf()
		{
			int min = arr[1,1];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] < min) { min = arr[i, j]; }
				}
			}
			return min;
		}

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

		public void IndexOf(int a, out int rang, out int count)
		{
			rang = -1;
			count = -1;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] == a)
					{
						rang = i;
						count = j;
						i = arr.GetLength(0);
						break;
					}
				}
			}
			
		}

		public static void CreatFile(int[,] arr, string path)
		{
			string text = "";
			
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					text += arr[i,j] + ",";
				}
				text += ";";
			}
			File.WriteAllText(path, text);
		}
	}
}
