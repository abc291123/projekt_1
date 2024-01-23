using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace proj_Sortowanie
{
    internal class BubbleSort
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
        public BubbleSort(int[] inputArray)
        {
            arr = new int[inputArray.Length];
            Array.Copy(inputArray, arr, inputArray.Length);
        }

        public BubbleSort(int n, bool ascending)
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
            for(int i=0; i < arr.Length; i++)
            {
                for (int j = 0; j<arr.Length; j++) 
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }    
            }
            stop = DateTime.Now;
        }
    }
}
