using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		Random r = new Random();
		List<string> RevertList = new List<string>();
 		public int score = 0;
		public int Wn = 0;
		public int Nn = 0;

		public Form1()
		{
			InitializeComponent();
			Wn = r.Next(20, 100);
			Nn = r.Next(0, 10);
			WınNumber.Text = Convert.ToString(Wn);
			NowNumber.Text = Convert.ToString(Nn);
			Scorebox.Text = Convert.ToString(score);
		}

		private void win()
		{
			if (Nn == Wn)
			{
				MessageBox.Show("You Won!");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			{

				if (RevertList.Last() == "minus" && RevertList.Count() != 0)
				{
					Nn++;
					score--;
					RevertList.RemoveAt(RevertList.Count() - 1);
				}
				else if (RevertList.Last() == "dob" && RevertList.Count() != 0)
				{
					Nn /= 2;
					score--;
					RevertList.RemoveAt(RevertList.Count() - 1);
				}
				WınNumber.Text = Convert.ToString(Wn);
				NowNumber.Text = Convert.ToString(Nn);
				Scorebox.Text = Convert.ToString(score);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Nn--;
			NowNumber.Text = Convert.ToString(Nn);
			Scorebox.Text = Convert.ToString(++score);
			RevertList.Add("minus");
			win();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Nn *= 2;
			NowNumber.Text = Convert.ToString(Nn);
			Scorebox.Text = Convert.ToString(++score);
			RevertList.Add("dob");
			win();
		}

		private void WınNumber_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
