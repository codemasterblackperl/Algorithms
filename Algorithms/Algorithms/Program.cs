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
            var arr = new int[]{ 2, 1, 3, 1, 2 };
            ISort sort = new InsertionSort();
            arr = sort.Sort(arr);
        }
    }
}
