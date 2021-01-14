using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 1; i < array.Length; i++)
            {
                var temp = array[i];
                int index;
                for (index = i; index > 0 && array[index - 1] > temp; index--)
                {
                    array[index] = array[index - 1];
                }

                array[index] = temp;
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            SortArray(array, array.Length);
        }

        private static void SortArray(int[] array, int length)
        {
            if (length <= 1)
            {
                return;
            }

            SortArray(array, length - 1);

            int last = array[length - 1];
            int i = length - 2;

            while (i >= 0 && array[i] > last)
            {
                array[i + 1] = array[i];
                i--;
            }

            array[i + 1] = last;
        }
    }
}
