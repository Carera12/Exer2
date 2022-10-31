using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    class Program
    {
        int[] Rera = new int[83];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 83))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("----------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Rera[i] = Int32.Parse(s1);
            }

        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                Console.Write("\nEnter Element want you to search: ");
                int item = Convert.ToInt32(Console.ReadLine());

                int low = 0;
                int high = n - 1;

                int mid = (low + high) / 2;
                int ctr = 1;

                while ((item != Rera[mid]) && (low < high))
                {
                    if (item > Rera[mid])
                        low = mid + 1;
                    else
                        high = mid - 1;
                    mid = (low + high) / 2;
                    ctr++;
                }
                if (item == Rera[mid])
                    Console.WriteLine("\n" + item.ToString() + " found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " not found in the array\n");
                Console.WriteLine("\nNumber of coparison: " + ctr);
                Console.WriteLine("\nContinue search (y/n): ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Shorted array elements");
            Console.WriteLine("----------------------");
            for (int SC = 0; SC < n; SC++)
            {
                Console.WriteLine("Rera[SC]");
            }
        }
        public void SelectionSort()
        {
            for (int i= 0; i < n - 1; i++)
            {
                int min = i;
                for (int SC = i + 1; SC < n; SC++)
                {
                    if (Rera[SC] <= Rera[min])
                    {
                        int temp;
                        temp = Rera[SC];
                        Rera[SC] = Rera[min];
                        Rera[min] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            myList.input();
            myList.BinarySearch();
            myList.display();
        }
    }
}
