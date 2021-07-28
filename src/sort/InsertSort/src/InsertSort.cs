using System;

namespace ALGO.InsertSort
{
    public class InsertSort
    {
        /// <summary>
        /// O(n²)
        /// O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>sort array</returns>
        public int[] Sort_1(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var insertVal = arr[i];
                var j = i - 1;
                while (j >= 0 && insertVal < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = insertVal;
            }
            return arr;
        }
    }
}
