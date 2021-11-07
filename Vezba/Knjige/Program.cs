using System;
using System.Collections.Generic;
using System.Text;

namespace Knjige
{
	class Program
	{
		public class Knjiga
		{
			private string naziv;
			private string autor;
			private float cena;
			private bool pristup;
			private int brojStrana;

			public Knjiga(string naziv, string autor, float cena, bool pristup, int brojStrana)
			{
				this.naziv = naziv;
				this.autor = autor;
				this.cena = cena;
				this.pristup = pristup;
				this.brojStrana = brojStrana;
			}

			public string Naziv
			{
				get
				{
					return naziv;
				}
				set
				{
					if (pristup)
					{
						naziv = value;
					}
					else
					{
						Console.WriteLine("Nemate dozvolu za promenu imena knjige!");
					}

				}
			}
			public string Autor
			{
				get
				{
					return autor;
				}
				set
				{
					if (pristup)
					{
						autor = value;
					}
					else
					{
						Console.WriteLine("Nemate dozvolu da promenite autora knjige");
					}
				}
			}
			public float Cena
			{
				get
				{
					return cena;
				}
				set
				{
					if (pristup)
					{
						cena = value;
					}
					else
					{
						Console.WriteLine("Nemate dozvolu da menjate cenu knjige!");
					}
				}
			}
			public int BrojStrana
			{
				get
				{
					return brojStrana;
				}
			}
			

		}
		public static Knjiga[] Sortiraj(Knjiga[] knjige)
		{
			Knjiga pom;
			for (int i = 0; i < knjige.Length - 1; i++)
			{
				for (int j = i + 1; j < knjige.Length; j++)
				{
					for (int k = 0; k < (knjige[i].Naziv.Length < knjige[j].Naziv.Length ? knjige[i].Naziv.Length : knjige[j].Naziv.Length);k++)
					{
						if (knjige[i].Naziv[k] > knjige[j].Naziv[k])
						{
							pom = knjige[i];
							knjige[i] = knjige[j];
							knjige[j] = pom;
						}
					}
				}
			}
			for (int i = 0; i < knjige.Length - 1; i++)
			{
				for (int j = i + 1; j < knjige.Length; j++)
				{
					if (knjige[i].Cena > knjige[j].Cena)
					{
						pom = knjige[i];
						knjige[i] = knjige[j];
						knjige[j] = pom;
					}
				}
			}
			return knjige;
		}

		static void Main(string[] args)
		{
			Knjiga[] knjige = new Knjiga[]
			{
				new Knjiga("A","Zika",250,true,300),
				new Knjiga("B","Marko",150,true,100),
				new Knjiga("C","Pera",50,true,80),
				new Knjiga("D","Stojan",300,true,250),
				new Knjiga("E","Milos",1500,true,800),
				new Knjiga("F","Goran",350,true,400),
				new Knjiga("G","Zivojin",400,true,500)
			};

			knjige = Sortiraj(knjige);
			foreach(Knjiga a in knjige)
			{
				Console.WriteLine("Naziv:{0}\nCena{1}\n", a.Naziv, a.Cena);
			}




		}
	}
}
