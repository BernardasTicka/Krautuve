using Krautuve;
using System;

namespace Krautuve
{
    public class Filtras
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        swapped = true;
                    }
                }

                n--;
            } while (swapped);
        }
    }
}