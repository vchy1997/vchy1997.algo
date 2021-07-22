using System;

namespace ALGO.SelectionSort
{
    public class SelectionSort
    {
        /// <summary>
        /// O(n²)
        /// O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>sort array</returns>
        public int[] Sort_1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }
    }
}
