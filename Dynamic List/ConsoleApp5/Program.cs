using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
	class Program
	{
		public class Node
		{
			public int info;
			public Node next;

			public Node()
			{
				info = 0;
				next = null;
			}

			public Node(int info)
			{
				this.info = info;
				next = null;
			}
		}
		public class List
		{
			public Node Head;
			public void AddToHead(int info)
			{
				if (Head.next == null)
				{
					Head.next = new Node(info);
				}
				else
				{
					Node n = new Node(info);
					n.next = Head.next;
					Head.next = n;
				}
			}
			public void AddToHead(Node n)
			{
				if (Head.next == null)
				{
					Head.next = n;
				}
				else
				{
					n.next = Head.next;
					Head.next = n;
				}
			}
			public void Push(int info)
			{
				Node i;
				for (i = Head.next; i.next != null; i = i.next);
				i.next = new Node(info);
			}
			public void Push(Node n)
			{
				Node i;
				for (i = Head.next; i.next != null; i = i.next) ;
				i.next = n;
			}
			public void AddAfter(int info,int a)
			{
				Node n = new Node(a);
				for (Node i = Head.next; i != null; i = i.next)
				{
					if(i.info == info)
					{
						n.next = i.next;
						i.next = n;
						break;
					}
				}

			}
			public void AddBefore(int info,int a)
			{
				Node n = new Node(a);
				for (Node i = Head.next; i != null; i = i.next)
				{
					if(i.next.info == info)
					{
						n.next = i.next;
						i.next = n;
						break;
					}
				}
			}
			public Node Pop(int a)
			{
				Node n = null;
				for (Node i = Head.next, j = i.next; j != null; i = i.next,j=i.next)
				{
					if(i.info == a)
					{
						n = j;	
						i.next = j.next;
						break;
					}
				}
				return n;
			}
			public Node Pop()
			{
				Node n = null,i,j;
				for (i = Head.next, j = i.next; j.next != null; i = i.next,j=i.next) ;
				n = j;
				i.next = null;
				return n;
			}
			public Node RemoveFromHead()
			{
				if(Head.next != null)
				{
					Node n = Head.next;
					Head.next = n.next;
					return n;
				}
				return null;
			}
			public void Print()
			{
				for (Node i = Head.next; i != null; i = i.next)
				{
					Console.WriteLine(i.info);
				}
				Console.WriteLine();
			}
		}

		static void Main(string[] args)
		{
			List l1 = new List();
			l1.Head = new Node();
			l1.AddToHead(5);
			l1.AddToHead(6);
			l1.AddToHead(7);
			l1.AddToHead(8);
			l1.Push(3);
			l1.AddBefore(3, 5);
			l1.AddAfter(3, 10);
			l1.Pop(5);
			l1.Pop();
			l1.RemoveFromHead();
			l1.Print();

		}
	}
}
