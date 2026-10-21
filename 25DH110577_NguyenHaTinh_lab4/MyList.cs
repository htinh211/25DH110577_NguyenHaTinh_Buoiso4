using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab4
{
    
        internal class MyList
        {
            
            private IntNode first;
            private IntNode last;
            private int count;


            public IntNode First { get { return first; } set { first = value; } }
            public IntNode Last { get { return last; } set { last = value; } }
            public int Count { get { return count; } }


            public MyList()
            {
                first = null;
                last = null;
                count = 0;
            }


            public bool IsEmpty()
            {
                return first == null;
            }

            public void AddFirst(IntNode newNode)
            {
                if (IsEmpty())
                    first = last = newNode;
                else
                {
                    newNode.Next = first;
                    first = newNode;
                }
                count++;
            }

            public void AddLast(IntNode newNode)
            {
                if (IsEmpty())
                    first = last = newNode;
                else
                {
                    last.Next = newNode;
                    last = newNode;
                }
                count++;
            }

            public void Input_Front()
            {
                int x;
                while (true)
                {
                    Console.Write("x (0 to stop) = ");
                    int.TryParse(Console.ReadLine(), out x);
                    if (x == 0)
                        break;
                    AddFirst(new IntNode(x));
                }
            }

            public void Input_Last()
            {
                int x;
                while (true)
                {
                    Console.Write("x (0 to stop) = ");
                    int.TryParse(Console.ReadLine(), out x);
                    if (x == 0)
                        break;
                    AddLast(new IntNode(x));
                }
            }

            public void ShowList()
            {
                IntNode p = first;
                while (p != null)
                {
                    Console.Write("{0} -> ", p.Data);
                    p = p.Next;
                }
                Console.WriteLine("null");
            }

            public IntNode SearchX(int x)
            {
                for (IntNode p = first; p != null; p = p.Next)
                {
                    if (p.Data == x)
                        return p;
                }
                return null;
            }

            public IntNode GetMax()
            {
                IntNode max = first;
                for (IntNode p = first; p != null; p = p.Next)
                {
                    if (p.Data > max.Data)
                        max = p;
                }
                return max;
            }

            public IntNode GetMin()
            {
                IntNode min = first;
                for (IntNode p = first; p != null; p = p.Next)
                {
                    if (p.Data < min.Data)
                        min = p;
                }
                return min;
            }

            public MyList GetEvenList()
            {
                MyList evenList = new MyList();
                for (IntNode p = first; p != null; p = p.Next)
                {
                    if (p.Data % 2 == 0)
                    {
                        evenList.AddLast(new IntNode(p.Data));
                    }
                }
                return evenList;
            }

            public MyList GetOddList()
            {
                MyList oddList = new MyList();
                for (IntNode p = first; p != null; p = p.Next)
                {
                    if (p.Data % 2 != 0)
                    {
                        oddList.AddLast(new IntNode(p.Data));
                    }
                }
                return oddList;
            }


            public static MyList JoinList(MyList list1, MyList list2)
            {
                MyList list3 = new MyList();

                if (list1 != null)
                {
                    for (IntNode p = list1.First; p != null; p = p.Next)
                    {
                        list3.AddLast(new IntNode(p.Data));
                    }
                }

                if (list2 != null)
                {
                    for (IntNode p = list2.First; p != null; p = p.Next)
                    {
                        list3.AddLast(new IntNode(p.Data));
                    }
                }

                return list3;
            }
        }
    }