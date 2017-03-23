using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class QuickSort : ISort
    {

        public int[] Sort(int[] arr)
        {
            QuickSortRecursive(ref arr, 0, arr.Length - 1);
            return arr;
        }

        private void QuickSortRecursive(ref int[] arr,int left,int right)
        {
            if (right - left <= 0)
                return;
            int pivot = arr[right];
            int partition = Partition(ref arr, left, right, pivot);
            QuickSortRecursive(ref arr, left, partition - 1);
            QuickSortRecursive(ref arr,partition + 1,right);
        }

        public int Partition(ref int[] arr,int left,int right,int pivot)
        {
            int leftPtr = left;
            int rightPtr = right - 1;

            while (true)
            {
                while (arr[leftPtr] < pivot)
                    leftPtr++;

                while (rightPtr > 0 && arr[rightPtr] > pivot)
                    rightPtr--;

                if (leftPtr >= rightPtr)
                    break;
                else
                    Swap(ref arr,leftPtr,rightPtr);
            }

            Swap(ref arr, leftPtr, right);

            return leftPtr;
        }

        private void Swap(ref int[] arr, int a,int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
