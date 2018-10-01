using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HtLs4
{
	class Arr
	{
		public int[] arr;
		private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\arr.txt";

		public Arr(int size, int start, int step)
		{
			arr = new int[size];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = start + i * step;
			}
		}

		public Arr(string path)
		{
			string text = File.ReadAllText(path);
			string[] subints = text.Split();
			arr = new int[subints.Length-1];

			for (int i = 0; i < subints.Length-1; i++)
			{
				arr[i] = Convert.ToInt32(subints[i]);				
			}
		}


		public string toString()
		{
			string text = "";
			for (int i = 0; i < arr.Length; i++)
			{
				text += arr[i] + " ";
			}
			return text;
		}

		public static void CreatFile(int []arr, string path)
		{
			string text = "";
			for (int i = 0; i < arr.Length; i++)
			{
				text += arr[i] + " ";
			}
			File.WriteAllText(path, text);
		}

		public Arr(){ }

		public int Sum()
		{
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum =+ arr[i];
			}
			return sum;
		}

		public void Invers()
		{
			for (int i = 0; i < this.arr.Length; i++)
			{
				this.arr[i] = -this.arr[i];
			}
		}

		public void Multi(int x)
		{
			for (int i = 0; i < this.arr.Length; i++)
			{
				this.arr[i] =x * this.arr[i];
			}
		}

		public int MaxCount()
		{
			int sum = 0;
			for (int i = 0; i < this.arr.Length; i++)
			{
				sum = +this.arr[i];
			}
			return sum;
		}
	}
}
