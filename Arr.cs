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

		/// <summary>
		/// Создает массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
		/// </summary>
		/// <param name="size"></param>
		/// <param name="start"></param>
		/// <param name="step"></param>
		public Arr(int size, int start, int step)
		{
			arr = new int[size];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = start + i * step;
			}
		}

		/// <summary>
		/// Создает массив и заполняет его данными из файла.
		/// </summary>
		/// <param name="path"></param>
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

		/// <summary>
		/// Переводит массив в строку.
		/// </summary>
		/// <returns></returns>
		public string toString()
		{
			string text = "";
			for (int i = 0; i < arr.Length; i++)
			{
				text += arr[i] + " ";
			}
			return text;
		}

		/// <summary>
		/// Записывает массив в файл.
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="path"></param>
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

		/// <summary>
		/// возвпащает сумму всех элементов массива.
		/// </summary>
		/// <returns></returns>
		public int Sum()
		{
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum =+ arr[i];
			}
			return sum;
		}

		/// <summary>
		/// меняет знак у каждого элемента
		/// </summary>
		public void Invers()
		{
			for (int i = 0; i < this.arr.Length; i++)
			{
				this.arr[i] = -this.arr[i];
			}
		}

		/// <summary>
		/// умножает каждый элемент массива на указанное число. 
		/// </summary>
		/// <param name="x"></param>
		public void Multi(int x)
		{
			for (int i = 0; i < this.arr.Length; i++)
			{
				this.arr[i] =x * this.arr[i];
			}
		}

		/// <summary>
		/// не понятно что он вообще должен делать
		/// </summary>
		/// <returns></returns>
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
