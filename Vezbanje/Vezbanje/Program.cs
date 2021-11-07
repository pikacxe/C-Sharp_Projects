using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbanje
{
	class Program
	{

		class Proba
		{

			private int a;
			private int b;
			public Proba()
			{
				a = 0;
				b = 0;
			}
			public Proba(int a, int b)
			{
				this.a = a;
				this.b = b;
			}
			
			public int a1
			{
				get
				{
					if (b == 10)
					{
						return a;
					}
					else
					{
						return 0;
					}

				}
				set
				{
					a = value;
				}
			}

		


		}



		static void Main(string[] args)
		{
			Proba proba = new Proba(10, 11);
			proba.a1 = 100;
			Console.WriteLine(proba.a1);




		}
	}
}
