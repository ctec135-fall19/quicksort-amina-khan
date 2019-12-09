/*
-Create static methods as needed to program the algorithm provided in the slides for this module

To test your algorithm create a data structure with at least 10 elements filled with random int values. 

Print the initial values before calling your quick sort method
Print the final values after completion of your method. 
Print a count of the number of swaps required to sort the values. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static int swapCount = 0;
        static void Main(string[] args)
        {
            // declare array
            int[] myList = new int[10] { 22, 44, 55, 77, 66, 32, 11, 3, 2, 6};
            int lo = 0;
            int high = myList.Length - 1;

            //printing array
            Console.Write("List of numbers: ");
            foreach (int i in myList)
            {
                Console.Write("  {0}", i);
            }

            // calling sort function
            
            
            Console.WriteLine("\n\n...Sorting\n\n");
            QuickSort(myList, lo, high);


            //printing array after sorting
            Console.Write("Sorted List of numbers: ");
            foreach (int i in myList)
            {
                Console.Write("  {0}", i);
            }

            Console.WriteLine("\n\nNumber of swaps: {0}", swapCount);
            Console.ReadLine();
        }

        public static void QuickSort(int[] list, int lo, int high)
        {

            if (lo < high)
            {
                int p = Partition(list, lo, high);
                QuickSort(list, lo, p-1);
                QuickSort(list, p + 1, high);

            }
            
        }

        public static int Partition(int[] list, int lo, int high)
        {
            int pivot = list[high];
            int i = lo - 1;
            for (int j = lo; j < high; j++)
            {
                if(list[j] < pivot)
                {
                    i++;
                    int swap = list[i];
                    list[i] = list[j];
                    list[j] = swap;
                    swapCount++;
                }
            }

            int swap2 = list[i+1];
            list[i+1] = list[high];
            list[high] = swap2;
            
            swapCount++;

            return i + 1;
        }
    }
}
