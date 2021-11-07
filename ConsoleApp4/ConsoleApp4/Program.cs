using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
	class Program
	{
		public static class B
		{
			public static int a;
			public static int[] Sort(int[] niz)
			{
				int pom;
				for(int i = 0; i < niz.Length - 1; i++)
				{
					for(int j = i + 1; j < niz.Length; j++)
					{
						if (niz[i] > niz[j])
						{
							pom = niz[i];
							niz[i] = niz[j];
							niz[j] = pom;
						}
					}
				}
				return niz;
			}
			public static int[] Unesi(int[] niz,int n)
			{
				for(int i = 0; i <n; i++)
				{
					niz[i] = int.Parse(Console.ReadLine());
				}
				return niz;
			}
			public static int Fakt(int n)
			{
				if (n == 1)
				{
					return n;
				}
				else
				{
					return n * Fakt(n - 1);
				}
			}
			public static int Max(int[] niz)
			{
				int max = 0;
				for(int i = 0; i < niz.Length; i++)
				{
					if (max < niz[i])
					{
						max = niz[i];
					}
				}
				return max;
			}


		}

		public class A
		{
			public int n;
			public int[] niz;
			public void Stampa()
			{
				foreach(int a in niz)
				{
					Console.WriteLine(a);
				}
			}
		}


		static void Main(string[] args)
		{
			A Klasa1 = new A();
			Klasa1.n = int.Parse(Console.ReadLine());
			Klasa1.niz = new int[Klasa1.n];
			Klasa1.niz = B.Unesi(Klasa1.niz,Klasa1.n);
			Klasa1.niz = B.Sort(Klasa1.niz);
			Console.WriteLine(B.Max(Klasa1.niz));
			Console.WriteLine(B.Fakt(Klasa1.n));
		
		}
	}
}
