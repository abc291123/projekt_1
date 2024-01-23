using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace proj_Sortowanie
{
    internal class QuickSort
    {
        public int[]arr;
        private DateTime start, stop;
        public Double Duration
        { 
            get
            {
                if (start!=null && stop != null)
                {
                    return (stop-start).TotalMilliseconds;
                }
                else
                { 
                    return 0; 
                }
            }
        }
        public QuickSort(int[] inputArray)
        {
            arr = new int[inputArray.Length];
            Array.Copy(inputArray, arr, inputArray.Length);
        }

        public QuickSort(int n, bool ascending)
        {
            arr = GenerateSequence(n, ascending);
        }

        private int[] GenerateSequence(int n, bool ascending)
        {
            int[] sequence = new int[n];

            if (ascending)
            {
                for (int i = 0; i < n; i++)
                {
                    sequence[i] = i + 1;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    sequence[i] = n - i;
                }
            }

            return sequence;
        }
        public void Sort()
        {
            start = DateTime.Now;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (var j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[minIndex]) minIndex = j;
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }

            stop = DateTime.Now;
        }
    }
}
