using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokaemAlgoritms
{
    public class Algoritms
    {
        public int BinarySearch(int[] arr, int item)
        {
            int first = 0;
            int last = arr.Length;
             while (first <= last) //пока не останется один элемент
            {
                int mid = (first + last) / 2; //Находим средний элемент
                if (arr[mid] == item) return mid; //Если попали, то возвращаем индекс
                if (arr[mid] > item) last = mid - 1; //Если значение больше искомого, то отсекаем всё что меньше(слева)
                else first = mid + 1; //Если меньше, то отсекаем всё что справа
            }
            return 0;
        }
        public int[] QuickSort (int[] arr, int start, int end)
        {
            if (start >= end)
                return arr;
            int marker = Partition(arr,start,end);
            QuickSort(arr, start, marker -1 );
            QuickSort(arr, marker+1, end);

            void swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            int Partition (int[] list, int first, int last)
            {
                int pivot = first -1;
                for (int i=0; i<=last;i++)
                {
                    if (list[i] < list[last])
                    {
                        pivot++;
                        swap(ref list[pivot], ref list[i]);
                    }
                }
                pivot++;
                swap(ref list[pivot], ref list[last]);
                return pivot;
            }

            return arr;
        }
    }
}
