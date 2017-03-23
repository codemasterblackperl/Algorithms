using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[]{ 4,5,3,7,2 };
            var sort = new QuickSort();
            var a1=sort.Sort(arr);
            //int val = sort.Partition(ref arr,0,arr.Length-1,arr[arr.Length-1]);

        }
    }
}
