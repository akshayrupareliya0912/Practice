/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Akshay
{
    internal class ArrayExp
    {
     static void Main(string[] args)
        {
            //Sum
            *//* int[] sum = { 10, 20, 30, 4, 2, 8, 6, 2, 1 };
             int total = 0;

             for (int i = 0; i < sum.Length; i++)
             {
                 total += sum[i];
             }
             Console.WriteLine("Total Sum is : " + total);
             *//*

            //Max & Min
            *//* int[] number = { 10, 20, 30, 4, 2, 8, 6, 2, 1 };

             int max = number[0];
             int min = number[0];


             for (int i = 0; i < number.Length; i++)
             {
                 if (number[i] > max)
                 {
                     max = number[i];
                 }
                 if (number[i] < min)
                 {
                     min = number[i];
                 }
             }
             Console.WriteLine("Maximum Number is : " + max);
             Console.WriteLine("Minimum Number is : " + min);*//*

            //odd & even
            *//*int[] num = { 2,32,5,8,9,6};
            int odd = 0;
            int even = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Total Odd Numbers are : " + odd);
            Console.WriteLine("Total Even Numbers are : " + even);*//*

            //Reverse
            *//* Console.Write("Enter Numbers");
             int num = int.Parse(Console.ReadLine());

             int[] rev = new int[num];
             for (int i = 0; i < num; i++)
             {
                 rev[i] = num - i;
             }
             Console.WriteLine("Reversed Array is : ");
             for (int i = 0; i < rev.Length; i++)
             {
                 Console.Write(rev[i] + " ");
             }
             Console.WriteLine();
 *//*

            //Remove Duplicates
            *//*int[] arr = { 1, 2, 2, 3, 4, 4, 5 ,5,6,7,8,8,9};
            List<int> dublicate = new List<int>();

            foreach (int item in arr)
            {
                if (!dublicate.Contains(item))
                {
                    dublicate.Add(item);
                }
            }

            Console.WriteLine("Array after removing duplicates:");
            foreach (int num in dublicate)
            {
                Console.Write(num + " ");
            }*//*

            //Merge Two Array
            *//*  Console.Write("Enter size of first array: ");
              int size1 = int.Parse(Console.ReadLine());
              int[] arr1 = new int[size1];

              Console.WriteLine("Enter elements of first array:");
              for (int i = 0; i < size1; i++)
              {
                  Console.Write($"Element {i + 1}: ");
                  arr1[i] = int.Parse(Console.ReadLine());
              }

              Console.Write("Enter size of second array: ");
              int size2 = int.Parse(Console.ReadLine());
              int[] arr2 = new int[size2];

              Console.WriteLine("Enter elements of second array:");
              for (int i = 0; i < size2; i++)
              {
                  Console.Write($"Element {i + 1}: ");
                  arr2[i] = int.Parse(Console.ReadLine());
              }

              int[] merged = new int[size1 + size2];

              for (int i = 0; i < size1; i++)
              {
                  merged[i] = arr1[i];
              }
              for (int i = 0; i < size2; i++)
              {
                  merged[size1 + i] = arr2[i];
              }

              Console.WriteLine("Merged Array:");
              foreach (int item in merged)
              {
                  Console.Write(item + " ");
              }

              Console.WriteLine();*//*

            //2D array
            *//*
                        Console.Write("Enter Row : ");
                        int row = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Column : ");   
                        int col = Convert.ToInt32(Console.ReadLine());

                        int[,] ar = new int[row, col];

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; i < col; i++) 
                            {
                                Console.Write($"Enter Array Element [{i},{j}] : ");
                                ar[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();


                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < row; j++)
                            {
                                Console.Write(ar[i, j] + " ");
                            }
                            Console.WriteLine();
                        }*//*

            // use  r input array size
            *//* int a = Convert.ToInt32(Console.ReadLine());
             int[] ar = new int[a];

             for (int i = 0; i < a; i++)
             {
                 Console.Write($"Enter Array Element [{i}] : ");
                 ar[i] = Convert.ToInt32(Console.ReadLine());
             }

             for (int i = 0; i < ar.Length - 1; i++)
             {
                 for (int j = i + 1; j < ar.Length; j++)
                 {
                     if (ar[i] < ar[j])
                     {
                         int temp = ar[i];
                         ar[i] = ar[j];
                         ar[j] = temp;
                     }
                 }
             }
             Console.WriteLine("Sorted Array Elements Are");

             for (int i = 0; i < ar.Length; i++)
             {
                 Console.WriteLine(ar[i]);
             }*//*

            // Example of Array Declaration and Initialization   
            *//* int[] ar = new int[5];
             ar[0] = 10;
             ar[1] = 20;
             ar[2] = 30;
             ar[3] = 40;

             Console.WriteLine(ar[0]);
             Console.WriteLine(ar[1]);
             Console.WriteLine(ar[2]);
             Console.WriteLine(ar[3]);*//*

            //Insert range
            *//* ArrayList arylist = new ArrayList()
             {
                 "India",
                 "USA",
                 "China",
                 "UK",
                 "Japan"
             };
             //Remove 
             arylist.Remove("UK");
             arylist.RemoveAt(2);
             arylist.RemoveRange(1, 2);
             Console.WriteLine("Array List");
             foreach (string item in arylist)
             {
                 Console.WriteLine($"{item}");
             }
             ArrayList arr1 = new ArrayList()
             {
                 "Sri Lanka",
                 "Britem"
             };
             // Inserting data of seond array
             arylist.InsertRange(2, arr1);

             Console.WriteLine("Cloned Array List");
             foreach (string item in arylist)
             {
                 Console.WriteLine($"{item}");
             }
             Console.ReadKey();*//*

            //Clone
            *//*ArrayList arrayList1= new ArrayList()
            {
                "India",
                "USA",
                "China",
                "UK",
                "Japan"
            };
            Console.WriteLine("Array List 1");
            foreach (string list1 in arrayList1)
            {
                Console.WriteLine($"{list1}");
            }
            ArrayList clonearray= (ArrayList)arrayList1.Clone();
            Console.WriteLine();
            //object[] arrayListCopy = new object[arrayList1.Count];
            //arrayList1.CopyTo(arrayListCopy);
            Console.WriteLine("Cloned Array List");
            //foreach (var item in arrayListCopy)
                foreach (var item in clonearray)
            {
                  Console.WriteLine($"{item}");
            }
            Console.ReadKey();*//*

            //sort
            *//*ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "Nepal",
                    "HongKong",
                    "Austrailla",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "Brazil",
            };
            Console.WriteLine("Array List Before Sorting");
            Console.WriteLine();
            foreach (string sor in arrayList) 
            {
                Console.WriteLine($"{sor}");
            }
            arrayList.Sort();
            Console.WriteLine();
            Console.WriteLine("Array List After Sorting");
            Console.WriteLine();
            foreach (string asor in arrayList) 
            {
                Console.WriteLine($"{asor}");   
            }*//*

        }
    }
}
*/