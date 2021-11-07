using System;
using System.Collections.Generic;
using System.Text;

namespace Operatori
{
	class Program
	{
		class Kompleksni
		{
			int x;
			int y;

			public Kompleksni(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			public static Kompleksni operator+(Kompleksni a,Kompleksni b)
			{
				return new Kompleksni(a.x + b.x, a.y + b.y);
			}
			public override string ToString()
			{
				if (y > 0)
				{
					return x + "+" + "j" + y;
				}
				else
				{
					return x + "-" + "j" + Math.Abs(y);
				}
			}
		}




		static void Main(string[] args)
		{
			Kompleksni A1 = new Kompleksni(3, -6);
			Kompleksni A2 = new Kompleksni(4, -2);
			A1 += A2;
			Console.WriteLine(A1.ToString());

		}
	}
}
