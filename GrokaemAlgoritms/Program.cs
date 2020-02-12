using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokaemAlgoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            Algoritms qsort = new Algoritms();
            int[] list = new int[] { 4, 5, 1, 6, 8, 9 };
            list = qsort.QuickSort(list, 0, list.Length - 1);
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
