using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		Random random = new Random();
		public int num;
		public int win;
		public DateTime Start;

		public Form1()
		{
			InitializeComponent();
			win = random.Next(100);
			bs.Text = "Отгадай число от 1 до 100";
			Start = DateTime.Now;
		}

		private void EntNum_TextChanged(object sender, EventArgs e)
		{
			string snum =  EntNum.Text;

			

			int.TryParse(snum, out num);

			if (win > num) { bs.Text = "Больше"; }
			else if (win < num) { bs.Text = "Меньше"; }
			else
			{
				DateTime End = DateTime.Now;
				Time.Text = Convert.ToString(End - Start);
				MessageBox.Show("You won!");
			}
		}
	}
}
