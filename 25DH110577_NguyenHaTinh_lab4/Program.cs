using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_lab4
{
  
        internal class Program
        {
            static void Main(string[] args)
            {
                int choice;
                do
                {
                    Console.WriteLine("\n--- BAI TAP 4: DSLK DON ---");
                    Console.WriteLine("1. Test Input_Front + ShowList");
                    Console.WriteLine("2. Test Input_Last + ShowList");
                    Console.WriteLine("3. Test SearchX");
                    Console.WriteLine("4. Test GetMax");
                    Console.WriteLine("5. Test GetMin");
                    Console.WriteLine("6. Test GetEvenList");
                    Console.WriteLine("7. Test GetOddList");
                    Console.WriteLine("8. Test JoinList");
                    Console.WriteLine("0. Thoat");
                    Console.Write("Nhap lua chon: ");
                    int.TryParse(Console.ReadLine(), out choice);

                    switch (choice)
                    {
                        case 1: TestInput_Front(); break;
                        case 2: TestInput_Last(); break;
                        case 3: TestSearchX(); break;
                        case 4: TestGetMax(); break;
                        case 5: TestGetMin(); break;
                        case 6: TestGetEvenList(); break;
                        case 7: TestGetOddList(); break;
                        case 8: TestJoinList(); break;
                    }
                } while (choice != 0);
            }

            static void TestInput_Front()
            {
                MyList list = new MyList();
                list.Input_Front();
                Console.WriteLine("\n--- Integer linked list:");
                list.ShowList();
                Console.WriteLine("Count = " + list.Count);
            }

            static void TestInput_Last()
            {
                MyList list = new MyList();
                list.Input_Last();
                Console.WriteLine("\n--- Integer linked list:");
                list.ShowList();
                Console.WriteLine("Count = " + list.Count);
            }

            static void TestSearchX()
            {
                MyList list = new MyList();
                list.Input_Last();
                Console.WriteLine("\n--- Integer linked list:");
                list.ShowList();

                Console.Write("Nhap x can tim: ");
                int x;
                int.TryParse(Console.ReadLine(), out x);

                IntNode kq = list.SearchX(x);
                if (kq != null)
                    Console.WriteLine("Tim thay, Data = " + kq.Data);
                else
                    Console.WriteLine("Khong tim thay!");
            }

            static void TestGetMax()
            {
                MyList list = new MyList();
                list.Input_Last();
                Console.WriteLine("\n--- Integer linked list:");
                list.ShowList();

                IntNode max = list.GetMax();
                if (max != null)
                    Console.WriteLine("Max = " + max.Data);
                else
                    Console.WriteLine("Danh sach rong!");
            }

            static void TestGetMin()
            {
                MyList list = new MyList();
                list.Input_Last();
                Console.WriteLine("\n--- Integer linked list:");
                list.ShowList();

                IntNode min = list.GetMin();
                if (min != null)
                    Console.WriteLine("Min = " + min.Data);
                else
                    Console.WriteLine("Danh sach rong!");
            }

            static void TestGetEvenList()
            {
                MyList list = new MyList();
                list.Input_Last();
                Console.WriteLine("\n--- Danh sach goc:");
                list.ShowList();

                MyList evenList = list.GetEvenList();
                Console.WriteLine("Danh sach so chan:");
                evenList.ShowList();
                Console.WriteLine("Count = " + evenList.Count);

                Console.WriteLine("Danh sach goc (phai khong doi):");
                list.ShowList();
            }

            static void TestGetOddList()
            {
                MyList list = new MyList();
                list.Input_Last();
                Console.WriteLine("\n--- Danh sach goc:");
                list.ShowList();

                MyList oddList = list.GetOddList();
                Console.WriteLine("Danh sach so le:");
                oddList.ShowList();
                Console.WriteLine("Count = " + oddList.Count);

                Console.WriteLine("Danh sach goc (phai khong doi):");
                list.ShowList();
            }

            static void TestJoinList()
            {
                Console.WriteLine("\n--- Nhap danh sach 1:");
                MyList list1 = new MyList();
                list1.Input_Last();

                Console.WriteLine("\n--- Nhap danh sach 2:");
                MyList list2 = new MyList();
                list2.Input_Last();

                Console.WriteLine("\n--- List 1:");
                list1.ShowList();
                Console.WriteLine("--- List 2:");
                list2.ShowList();

                MyList list3 = MyList.JoinList(list1, list2);
                Console.WriteLine("\n--- List 3 (Noi List 1 va List 2):");
                list3.ShowList();
                Console.WriteLine("Count = " + list3.Count);

                Console.WriteLine("\n--- Kiểm tra tinh doc lap:");
                Console.WriteLine("List 1 (phai khong doi):");
                list1.ShowList();
                Console.WriteLine("List 2 (phai khong doi):");
                list2.ShowList();
            }
        }
    }