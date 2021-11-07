using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
	class Program
	{
		public class Stack
		{
			public int[] niz;
			public int size;
			public int top;
			public Stack(int size)
			{
				this.niz = new int[size];
				this.size = size;
				this.top = -1;
			}
			public void Push(int i)
			{
				if (top + 1 < size)
				{
					niz[++top] = i;
				}

			}
			public int Pop()
			{
				int i=-1;
				if(top != -1)
				{
					i = niz[top];
					niz[top--] = 0;
				}
				return i;
			}
			public void Print()
			{
				for(int i = top; i >= 0; i--)
				{
					Console.WriteLine(niz[i]);
				}
			}
			public bool isEmpty()
			{
				return top == -1 ? true : false; 
			}
		}
		static void Main(string[] args)
		{
				
		}
	}
}
