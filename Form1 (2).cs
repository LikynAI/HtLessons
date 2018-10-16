using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XmlApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Student.StList.Add(new Student("Иван", "Иванов", 20));
			Student.StList.Add(new Student("Андрей", "Иванов", 19));
			Student.StList.Add(new Student("Никита", "Никитин", 21));
	
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			
		}

		private void Obn_Click(object sender, EventArgs e)
		{
			string sinfo = string.Empty;
			foreach (var item in Student.StList)
			{
				sinfo += $"{item.Name} {item.SecondName} {item.age}" + "\n";
			}
			infoBox.Text = sinfo;
		}

		private void buttonCreate_Click_1(object sender, EventArgs e)
		{
			Student.StList.Add(new Student(NameBox.Text, sNameBox.Text, Convert.ToInt16(AgeBox.Text)));
		}

		private void Save_Click(object sender, EventArgs e)
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
			Stream fStream = new FileStream("db.xml", FileMode.Create, FileAccess.Write);
			xmlFormat.Serialize(fStream, Student.StList);
			fStream.Close();
		}

		private void Load_Click(object sender, EventArgs e)
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
			Stream fStream = new FileStream("db.xml", FileMode.Open, FileAccess.Read);
			Student.StList = (List<Student>)xmlFormat.Deserialize(fStream);
			fStream.Close();
		}
	}
}
