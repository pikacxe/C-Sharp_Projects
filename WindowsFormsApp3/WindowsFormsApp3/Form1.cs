using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CreateButton("B1", "Novo dugme", new Size(100, 50), new Point(0, 0));
			CreateButton("B2", "Novo dugme", new Size(100, 50), new Point(0, this.Height - 100));
			CreateButton("B3", "Novo dugme", new Size(100, 50), new Point(this.Width - 100, this.Height - 100));
			CreateButton("B4", "Novo dugme", new Size(100, 50), new Point(this.Width - 100, 0));
			
		}

		public void Event(object sender,EventArgs e)
		{
			MessageBox.Show("Lokacija:"+((Button)sender).Location.ToString());
		}


		public void CreateButton(string Naziv,string Text,Size Velicina,Point lokacija)
		{
			Button a = new Button();
			a.Name = Naziv;
			a.Text = Text;
			a.Size = Velicina;
			a.Location = lokacija;
			a.Click += Event;
			Controls.Add(a);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int p = 0;
			if (p == 0)
			{
				label1.Visible = true ;
				this.Refresh();
				p++;
			}
			else
			{
				label1.Visible = false ;
				this.Refresh();
				p--;
			}
		}
	}
}
