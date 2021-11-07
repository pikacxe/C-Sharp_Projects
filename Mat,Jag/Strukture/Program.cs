using System;
using System.Collections.Generic;
using System.Text;

namespace Strukture
{
	class Program
	{
		public static void stampa(int[,] mat)
		{
			string s = "";
			for (int i = 0; i < mat.GetLength(0); i++)
			{
				for (int j = 0; j < mat.GetLength(1); j++)
				{
					s+=mat[i, j].ToString() + "\t";
				}
				Console.WriteLine(s+"\n");
				s = "";
			}
		}
		public static void popuni(int[,] mat)
		{
			for (int i = 0; i < mat.GetLength(0); i++)
			{
				for (int j = 0; j < mat.GetLength(1); j++)
				{
					mat[i, j] = j + 1 + mat.GetLength(0) * i;
				}
			}
		}
		public static void zameni(int[,] mat)
		{
			for (int i = 0; i < mat.GetLength(1)-1; i++)
			{
				for (int j = i + 1; j < mat.GetLength(0); j++)
				{
					if (i != j)
					{
						int pom = mat[i, j];
						mat[i, j] = mat[j, i];
						mat[j, i] = pom;
					}

				}

			}
		}
		public static void popuni2(int[,] mat)
		{

			for (int i = 0; i < mat.GetLength(0); i++)
			{
				for (int j = 0; j < mat.GetLength(1); j++)
				{
					if(i+j+1 <= mat.GetLength(0))
					mat[i, j] = i+1+j;
					else
					{
						mat[i, j] = i + j + 1 - mat.GetLength(0) ;
					}

					
				}
			}
		}
		public static bool proveri(int[,] mat)
		{
			for (int i = 0; i < mat.GetLength(0); i++)
			{
				for (int j = 0; j < mat.GetLength(1); j++)
				{
					if(i != j)
					{
						if(mat[i,j]!=mat[j,i])
						return false;
					}

				}
			}
			return true;
		}
		public static void popuni3(int[,] mat)
		{
			for (int i = 0; i < mat.GetLength(0); i++)
			{
				for (int j = 0; j < mat.GetLength(1); j++)
				{
					if(i!=j)
					mat[i, j] = 1;
				}
			}
		}
		public static void zameni(int[,] mat,int[] b,int k)
		{
			for (int i = 0; i < mat.GetLength(0); i++)
			{
				mat[k, i] = b[i];
			}
		}
		public static void popuniJAg(int[][] a)
		{
			for(int i = 0; i < a.Length; i++)
			{
				for(int j = 0; j < a[i].Length; j++)
				{
					a[i][j] = j + 1 + a[i].Length*i;
				}
			}
			
		}
		public static void StampajJag(int[][] a)
		{
			Console.WriteLine();
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = 0; j < a[i].Length; j++)
				{
					Console.Write(a[i][j]+" ");
				}
				Console.WriteLine();
			}
		}
		public static int[][] SaberiJag(int[][] a,int[][] b)
		{
			if (a.Length < b.Length)
			{
				for (int i = 0; i < a.Length; i++)
				{
					if(a[i].Length<b[i].Length)
					for (int j = 0; j < a[i].Length; j++)
					{
							b[i][j] += a[i][j];
					}
					else
					{
						int[] p = new int[a[i].Length];
						for (int j = 0; j < b[i].Length; j++)
						{
							p[j] = a[i][j] + b[i][j];
						}
						for(int j = b[i].Length; j < a[i].Length; j++)
						{
							p[j] = a[i][j];
						}
						b[i] = p;
					}

				}
				return b;
			}
			else
			{
				for (int i = 0; i < b.Length; i++)
				{
					if (a[i].Length > b[i].Length)
						for (int j = 0; j < b[i].Length; j++)
						{
							a[i][j] += b[i][j];
						}
					else
					{
						int[] p = new int[b[i].Length];
						for (int j = 0; j < a[i].Length; j++)
						{
							p[i] = a[i][j] + b[i][j];
						}
						for (int j = a.Length; j < b.Length; j++)
						{
							p[i] = b[i][j];
						}
						a[i] = p;
					}

				}
				return a;
			}
		}
		static void Main(string[] args)
		{
			int[][] jag1 = new int[][] {
				new int[4],
				new int[5],
				new int[1]

			};
			int[][] jag2 = new int[][] {
				new int[1],
				new int[3],
				new int[4],
				new int[5]

			};
			popuniJAg(jag1);
			StampajJag(jag1);
			popuniJAg(jag2);
			StampajJag(jag2);
			Console.WriteLine();
			Console.WriteLine();
			StampajJag(SaberiJag(jag1, jag2));
			

		}
	}
}
