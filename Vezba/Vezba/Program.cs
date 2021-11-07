using System;

namespace Vezba
{
    class Program
    {


		 class Ptica
		{
			public string vrsta;
			public int tezina;

			public Ptica(string vrsta, int tezina)
			{
				this.vrsta = vrsta;
				this.tezina = tezina;
			}

			public virtual void  Ishrana()
			{
				Console.WriteLine("Jedem semenke!");
			}
		}
		class Letaci : Ptica
		{
			public float BrzinaLeta;
			public Letaci(string vrsta, int tezina,float BrzinaLeta) : base(vrsta, tezina)
			{
				this.BrzinaLeta = BrzinaLeta;
			}
			public override void Ishrana()
			{
				Console.WriteLine("Jedem meso!");
			}
		}
		class Neletaci : Ptica
		{
			public string Boja;

			public Neletaci(string Boja,string vrsta,int tezina):base(vrsta,tezina)
			{
				this.Boja = Boja;
			}
		}
		class Grabljivac : Letaci
		{
			public Grabljivac(string vrsta, int tezina, float BrzinaLeta) : base(vrsta, tezina, BrzinaLeta)
			{
			}
			public void Lovi()
			{
				Console.WriteLine("Hvata plen!");
			}
			public override void Ishrana()
			{
				Console.WriteLine("Jedem plen!");
			}
		}
		class Ljubimac : Letaci
		{
			public Ljubimac(string vrsta, int tezina, float BrzinaLeta) : base(vrsta, tezina, BrzinaLeta)
			{
			}
			public void Cvrkut()
			{
				Console.WriteLine("Cvrkut!");
			}
			public override void Ishrana()
			{
				Console.WriteLine("Jedem Proso!");
			}
		}
		static void Main(string[] args)
		{
			Ljubimac L1 = new Ljubimac("Papagaj", 200, 10);
			L1.Ishrana();
        }
    }
}
