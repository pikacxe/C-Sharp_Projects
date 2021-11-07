using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
	class Program
	{
		public class Queue
		{
			public int[] array;
			public int head;
			public int tail;
			public int numberOfElements;
			public int size;
			public Queue(int size)
			{
				array = new int[size];
				this.size = size;
				numberOfElements = 0;
				head = -1;
				tail = -1;
			}
			public void Engueue(int i)
			{
				if (numberOfElements < size)
				{
					if (head < tail)
					{
						array[++tail] = i;
						numberOfElements++;
					}
					else if(head == tail)
					{
						head = 0;
						tail++;
						array[tail] = i;
						numberOfElements++;
					}
				}
			}
			public void Dequeue()
			{
				if(numberOfElements > 0)
				{
					if(tail == head)
					{
						array[head] = 0;
						tail = head = -1;
						numberOfElements--;
					}
					else
					{
						array[head++] = 0;
						numberOfElements--;
					}
					
				}
			}
			public bool isEmpty()
			{
				return numberOfElements > 0 ? false : true;
			}
			public void Print()
			{
				if (head < tail)
				{
					for(int i = head; i <= tail; i++)
					{
						Console.WriteLine(array[i]);
					}
				}
				else
				{
					for(int i = head; i < size; i++)
					{
						Console.WriteLine(array[i]);
					}
					for(int i = 0; i <= tail; i++)
					{
						Console.WriteLine(array[i]);
					}
				}
				Console.WriteLine();
			}
		}



		static void Main(string[] args)
		{
			Queue q1 = new Queue(6);
			q1.Engueue(5);
			q1.Engueue(3);
			q1.Engueue(6);
			q1.Print();
			q1.Dequeue();
			q1.Print();
			q1.Engueue(2);
			q1.Engueue(8);
			q1.Engueue(4);
			q1.Print();
			q1.Dequeue();
			q1.Dequeue();
			q1.Print();
			q1.Engueue(1);
			q1.Print();
		}
	}
}
