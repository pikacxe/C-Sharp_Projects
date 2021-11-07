using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Unos(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
        }

        public static int najveciEl(int[] a)
        {
            int max = 0;
            foreach (int A in a)
            {
                if (max < A)
                    max = A;
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { };
            int x;
            string Out;

            x = int.Parse(Console.ReadLine());


            Unos(a, x);
            x = najveciEl(a);
            Console.WriteLine("Najeveci element niza A je:" + x);
           




        }

     

    }
}
