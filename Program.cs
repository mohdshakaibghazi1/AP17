using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConAppSelectionSort
{
    internal class Program
    {
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {


                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }

                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  "); // Changed WriteLine to Write to print on the same line.
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 4, 7, 6 };
            Console.WriteLine("array without  sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SelectionSort(arr);
            stopwatch.Stop();
            Console.WriteLine("array with selection sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time TAken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");


            Console.ReadLine();
        }
    }
}
