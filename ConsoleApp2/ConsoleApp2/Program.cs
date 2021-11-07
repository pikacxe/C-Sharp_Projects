using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	class Program
	{

		class Prva {
			public int a;
			public int b;
			public int A { get; set; }
			private int Jedan { get; set; }
			public int Nesto
			{
				get
				{
					return Nesto;
				}
				set
				{
					Nesto = value;
				}
			}
			public static int c;
		
			public Prva(int a, int b)
			{
				this.a = a;
				this.b = b;
				c = 2;
			}

			public class Unutrasnja
			{
				public string Ime;
				public string Prezime;

				public Unutrasnja(string ime, string prezime)
				{
					Ime = ime;
					Prezime = prezime;
				}
			}

		}
		public static class A
		{
			public static int a;
			public static int b;
			public static int saberi(int c ,int d)
			{
				return c + d;
			}
			static A()
			{
				a = 5;
				b = 6;
			}
		}
		public interface IMikica
		{
			 int a { get; set; }
			 int c { get; set; }
			 void Ime();


		}
		class Interfejs : IMikica
		{
			public Interfejs(int a, int c)
			{
				this.a = a;
				this.c = c;
			}
			public int b;
			public int a { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
			public int c { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

			public void Ime()
			{
				throw new NotImplementedException();
			}
		}
		abstract class Mikica
		{
			public int a;
			public abstract void Stampa();
			

		}
		class Darko : Mikica
		{
			public override void Stampa()
			{
				return;
			}
		}
		class Ilija : Mikica
		{
			public override void Stampa()
			{
				Console.WriteLine("a");
			}
		}
		class MikicaPita
		{
			public virtual void Nesto()
			{

			}
		}

		static void Main(string[] args)
		{
			Prva p = new Prva(5, 6);
			Prva p1 = new Prva(1, 2);
			p = null;
			p1 = null;
			Console.WriteLine(A.a);
			A.a = 0;
			Console.WriteLine(A.a);

			IMikica a = new Interfejs(2,4);
			Interfejs i = new Interfejs(2, 4);
			i.b = 4;

			Darko d;
			Ilija ilija;
			

		}
	}
}
