using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Label L1 = new Label() {Text = "Labela" ,BackColor=Color.Red,Location = new Point(50,50) };
			Controls.Add(L1);
			DialogResult d = MessageBox.Show("Nesto","Jos nesto", MessageBoxButtons.OKCancel, 
				MessageBoxIcon.Error);
			if (d == DialogResult.Cancel)
			{
				this.Close();
			}
			L1.Click += MojEvent;

		}

		private void MojEvent(object sender, EventArgs e)
		{
			MessageBox.Show("Radi");
			
		}




		static bool a=true;
		static int b = 0;
		#region Events
		private void button1_Click(object sender, EventArgs e)
		{
			string[] s = textBox1.Text.Split(' ');
			string min=s[0];
			for(int i = 1;i<s.Length;i++)
			{
				if (s[i].Length < min.Length)
				{
					min = s[i];
				}
			}
			MessageBox.Show(textBox1.Text.Replace(min, "Najmanja rec"));

		


		}
		private void button2_Click(object sender, EventArgs e)
		{

			if (a)
			{
				this.BackColor = Color.Red;
				a = false;
			}
			
			else
			{
				this.BackColor = Form1.DefaultBackColor;
				a = true;
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (b < 4)
			{
				b++;
			}
			else if (b == 4)
			{
				b = 0;
			}
			Bitmap a = new Bitmap(Application.StartupPath + "\\Slike\\" + b + ".jpg");
			pictureBox1.Image = a as Image;
		}
		#endregion
	}
}
