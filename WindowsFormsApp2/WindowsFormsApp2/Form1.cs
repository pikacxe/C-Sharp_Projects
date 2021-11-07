using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			M1 = new Macka[] {
				new Macka("a","v",1,new Bitmap("slika1.jpg")),
				new Macka("b","m",2,new Bitmap("slika2.jpg"))};
			prikaz(label1, label2, label3, pictureBox1, 0);
		}
		
		public Macka[] M1;

		public class Macka
		{
			public string Ime { get; set; }
			public string Rasa { get; set; }
			public int godine { get; set; }
			public Image Slika;
			public Macka(string ime, string rasa, int godine,Bitmap b)
			{
				Ime = ime;
				Rasa = rasa;
				this.godine = godine;
				Slika = b as Image;
			}
		}
		public void prikaz(Label l1,Label l2,Label l3,PictureBox p1,int index)
		{
			l1.Text = M1[index].Ime;
			l2.Text = M1[index].Rasa;
			l3.Text = M1[index].godine.ToString();
			p1.Image = M1[index].Slika;
		}
		public static int index = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			if (index+1 < M1.Length)
			{
				prikaz(label1, label2, label3, pictureBox1, ++index);
			}
			else
			{
				index = 0;
				prikaz(label1, label2, label3, pictureBox1, index);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (index - 1 > 0)
			{
				prikaz(label1, label2, label3, pictureBox1, --index);
			}
			else
			{
				index = M1.Length;
				prikaz(label1, label2, label3, pictureBox1, index);
			}
		}

	}
}
