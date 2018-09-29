using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtLs3
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime start = DateTime.Now;
			// представлено решение примера ((-37/60 + 12/8)*4/5 + -1/-25) : 1/-3
			Fraction fr1 = new Fraction(-37, 60);
			Fraction fr2 = new Fraction(12, 8);
			Fraction fr3 = new Fraction(4, 5);
			Fraction fr4 = new Fraction(-1, -25);
			Fraction fr5 = new Fraction(1,-3);
		
			Fraction frsol = new Fraction(Fraction.Devide(Fraction.Minus(Fraction.Multiplication(Fraction.Plus(fr1, fr2), fr3), fr4),fr5));
			Fraction.Print(Fraction.vidcel(frsol));
			DateTime end = DateTime.Now;
			Console.WriteLine(end - start);

			Console.ReadLine();
		}
	}
	/// <summary>
	/// класс для работы с дробями
	/// </summary>
	public class Fraction
	{
		public static Fraction fraction = new Fraction(0, 0, 0);
		public int chis, znam, cel;

		/// <summary>
		/// складывает две дроби
		/// </summary>
		/// <param name="fraction1"></param>
		/// <param name="fraction2"></param>
		/// <returns></returns>
		public static Fraction Plus(Fraction fraction1, Fraction fraction2)
		{
			ubratcel(fraction1);
			ubratcel(fraction2);

			fraction1.chis *= fraction2.znam;
			fraction2.chis *= fraction1.znam;

			int chis = fraction1.chis + fraction2.chis;
			int znam = fraction1.znam * fraction2.znam;

			Fraction solution = new Fraction(chis, znam);
			return Reduce(solution);
		}

		/// <summary>
		/// вычитает из вервой дроби вторую
		/// </summary>
		/// <param name="fraction1"></param>
		/// <param name="fraction2"></param>
		/// <returns></returns>
		public static Fraction Minus(Fraction fraction1, Fraction fraction2)
		{
			if (fraction1.cel != 0)
			{
				vidcel(fraction1);
			}
			if (fraction2.cel != 0)
			{
				ubratcel(fraction2);
			}

			fraction1.chis *= fraction2.znam;
			fraction2.chis *= fraction1.znam;

			int chis = fraction1.chis - fraction2.chis;
			int znam = fraction1.znam * fraction2.znam;

			Fraction solution = new Fraction(chis, znam);
			return Reduce(solution);
		}

		/// <summary>
		/// перемножает две дроби
		/// </summary>
		/// <param name="fraction1"></param>
		/// <param name="fraction2"></param>
		/// <returns></returns>
		public static Fraction Multiplication(Fraction fraction1, Fraction fraction2)
		{
			if (fraction1.cel != 0)
			{
				vidcel(fraction1);
			}
			if (fraction2.cel != 0)
			{
				ubratcel(fraction2);
			}

			int chis = fraction1.chis * fraction2.chis;
			int znam = fraction1.znam * fraction2.znam;

			Fraction solution = new Fraction(chis, znam);
			return Reduce(solution);
		}

		/// <summary>
		/// делит первую дробь на вторую
		/// </summary>
		/// <param name="fraction1"></param>
		/// <param name="fraction2"></param>
		/// <returns></returns>
		public static Fraction Devide(Fraction fraction1, Fraction fraction2)
		{
			if (fraction1.cel != 0)
			{
				vidcel(fraction1);
			}
			if (fraction2.cel != 0)
			{
				ubratcel(fraction2);
			}

			int chis = fraction1.chis * fraction2.znam;
			int znam = fraction1.znam * fraction2.chis;

			Fraction solution = new Fraction(chis, znam);
			Reduce(solution);
			return Reduce(solution);
		}

		/// <summary>
		/// Находит НОД для дроби. 
		/// </summary>
		/// <param name="znam"></param>
		/// <param name="chis"></param>
		/// <returns></returns>
		public static int CommonDenominator(int _chis, int _znam)
		{
			int chis = _chis;
			int znam = _znam;
			while (znam != 0 && chis != 0)
			{
				if (znam * znam > chis * chis)
				{
					znam %= chis;
				}
				else
				{
					chis %= znam;
				}
			}
			return znam + chis;
		}

		/// <summary>
		/// Превращает обычную дробь в сешанную
		/// </summary>
		/// <param name="chis"></param>
		/// <param name="znam"></param>
		/// <returns></returns>
		public static Fraction vidcel(Fraction fraction1)
		{
			fraction1.cel = (fraction1.chis - (fraction1.chis % fraction1.znam)) / fraction1.znam;
			if (fraction1.cel < 0)
			{
				fraction1.chis = -fraction1.chis % fraction1.znam;
			}
			else if (fraction1.cel > 0)
			{
				fraction1.chis = fraction1.chis % fraction1.znam;
			}
			return fraction1;
		}

		/// <summary>
		/// Превращает смешанную дробь в обычную
		/// </summary>
		/// <param name="fraction1"></param>
		/// <returns></returns>
		public static Fraction ubratcel(Fraction fraction1)
		{
			if (fraction1.cel > 0)
			{
				fraction1.chis += fraction1.znam * fraction1.cel;
			}
			else if (fraction1.cel < 0)
			{
				fraction1.chis = -fraction1.chis + fraction1.znam * fraction1.cel;
			}
			return fraction1;
		}

		/// <summary>
		/// Сокращает дробь.
		/// </summary>
		/// <param name="chis"></param>
		/// <param name="znam"></param>
		/// <returns></returns>
		public static Fraction Reduce(Fraction fraction1)
		{
			if (fraction1.znam < 0)
			{
				fraction1.znam = -fraction1.znam;
				int znam = fraction1.znam;
				fraction1.chis = -fraction1.chis;
			}
			else
			{
				int znam = fraction1.znam;
			}
			int chis = fraction1.chis;

			if (fraction1.chis % fraction1.znam == 0)
			{
				fraction1.chis = fraction1.chis / fraction1.znam;
				fraction1.znam = 1;
			}
			else if (fraction1.chis == 0)
			{
				fraction1.chis = 0;
				fraction1.znam = 1;
			}
			else
			{
				int Denominator = CommonDenominator(fraction1.chis, fraction1.znam);
				if (Denominator > 0)
				{
					fraction1.znam /= Denominator;
					fraction1.chis /= Denominator;
				}
				else
				{
					fraction1.znam /= -Denominator;
					fraction1.chis /= -Denominator;
				}
			}
			return fraction1;
		}

		/// <summary>
		/// выводит значение дроби 
		/// </summary>
		public static void Print(Fraction fraction1)
		{
			Console.WriteLine($" {fraction1.cel} {fraction1.chis}/{fraction1.znam} ");
		}

		/// <summary>
		/// конструктор для целых чисел
		/// </summary>
		/// <param name="_cel"></param>
		public Fraction(int _cel)
		{
			chis = _cel;
			cel = 0;
			znam = 1;
		}


		/// <summary>
		/// конструктор принимающий в качестве аргумента дробь
		/// </summary>
		/// <param name="_cel"></param>
		public Fraction(Fraction fraction1)
		{
			int _cel = fraction1.cel;
			int _chis = fraction1.chis;
			int _znam = fraction1.znam;
			if (_cel < 0)
			{
				_chis = -_chis;

			}

			cel = 0;
			chis = _chis + _znam * _cel;
			znam = _znam;
		}

		/// <summary>
		/// для смешанных дробей
		/// </summary>
		/// <param name="_cel"></param>
		/// <param name="_chis"></param>
		/// <param name="_znam"></param>
		public Fraction(int _cel, int _chis, int _znam)
		{
			if (_cel < 0)
			{
				_chis = -_chis;

			}

			cel = 0;
			chis = _chis + _znam * _cel;
			znam = _znam;
		}

		/// <summary>
		/// для обычных дробей
		/// </summary>
		/// <param name="_chis"></param>
		/// <param name="_znam"></param>
		public Fraction(int _chis, int _znam)
		{
			chis = _chis;
			znam = _znam;
		}

		/// <summary>
		/// метод конвертирует дробь в decimal
		/// </summary>
		/// <param name="fraction1"></param>
		/// <returns></returns>
		public static decimal ToDecimal (Fraction fraction1)
		{
			return fraction1.chis / fraction1.znam + fraction1.chis;
		}
		/// <summary>
		/// Проверяет число на четность.
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		private static string Chetnechet(int a)
			{
				if (a % 2 == 0)
				{
					return "chet";
				}
				else if (a % 2 == 1)
				{
					return "nechet";
				}
				else if (a == 1)
				{
					return "1";
				}
				else
				{
					return "0";
				}
			}

	}
}