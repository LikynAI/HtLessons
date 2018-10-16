using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeruNeVeru2
{
	public partial class Form1 : Form
	{
		int trues = 0;
		public int i = 0;
		public TrueFalse tf = new TrueFalse("db.xml");

		public Form1()
		{
			InitializeComponent();

			tf.Load();
		}

		private void True_Click(object sender, EventArgs e)
		{
			Answer(true);
		}

		private void False_Click(object sender, EventArgs e)
		{
			Answer(false);
		}

		private void Start_Click(object sender, EventArgs e)
		{
			label1.Text = tf.list[i].text;
		}

		public void Answer(bool a)
		{
			if (tf.list[i].trueFalse == a)
			{
				MessageBox.Show("Это верно"); trues++;
			}
			else
			{
				MessageBox.Show("Ты не прав");
			}
			if (i < tf.Count) { i++; }
			else
			{
				MessageBox.Show($"Ты правильно ответил на {trues} из {tf.Count}");
				Application.Exit();
			}
			label1.Text = tf.list[i].text;
		}

		
	}
}
