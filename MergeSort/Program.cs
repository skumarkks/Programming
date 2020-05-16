using System;

public class Program
{
    public static int[] MergeSort(int[] array)
    {
        // Write your code here.
        if (array.Length == 0) return null;
        if (array.Length == 1) return array;

        int low = 0;
        int high = array.Length - 1;
        int[] temp = new int[array.Length];

        MergeSort(array, temp, low, high);
        return array;
    }

    public static void MergeSort(int[] array, int[] temp, int low, int high)
    {
        if (low < high)
        {
            int mid = (low + high) / 2;
            MergeSort(array, temp, low, mid);
            MergeSort(array, temp, mid + 1, high);
            Merge(array, temp, low, mid, high);
        }
    }

    public static void Merge(int[] array, int[] temp, int low, int mid, int high)
    {
        int firstArrayIdx = low;
        int secondArrayIdx = mid + 1;
        int k = low;

        while (firstArrayIdx <= mid && secondArrayIdx <= high)
        {
            if (array[firstArrayIdx] <= array[secondArrayIdx])
            {
                temp[k++] = array[firstArrayIdx++];
            }
            else if (array[firstArrayIdx] > array[secondArrayIdx])
            {
                temp[k++] = array[secondArrayIdx++];
            }
        }
                
        while (firstArrayIdx <= mid)
        {
            temp[k] = array[firstArrayIdx];
            k++;
            firstArrayIdx++;
        }
        
        while (secondArrayIdx <= high)
        {
            temp[k] = array[secondArrayIdx];
            k++;
            secondArrayIdx++;
        }
        
        for (int i = 0; i < high; i++)
        {
            array[i] = temp[i];
        }
    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 2, 1 };
        int[] result = Program.MergeSort(array);
    }

}
