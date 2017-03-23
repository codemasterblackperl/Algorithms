using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class InsertionSort:ISort
    {
        public int NoOfSteps { get; set; }

        public int[] Sort(int[] arr)
        {
            var j = 0;
            NoOfSteps = 0;
            for (var i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                j = i;
                
                while (j > 0 && arr[j - 1] > value)
                {
                    NoOfSteps++;
                    arr[j] = arr[j - 1];
                    j = j - 1;
                }
                arr[j] = value;
            }
            return arr;
        }
    }
}
