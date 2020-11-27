using System;

public class Program
{
    public static void MergeSort(int[] arr)
    {
        int[] temp = new int[arr.Length];
        MergeSort(arr, temp, 0, arr.Length - 1);
    }

    public static void MergeSort(int[] arr, int[] temp, int low, int high)
    {
        if (low < high)
        {
            int mid = (low + high) / 2;
            MergeSort(arr, temp, low, mid);
            MergeSort(arr, temp, mid + 1, high);
            Merge(arr, temp, low, mid, high);
        }
    }

    public static void Merge(int[] arr, int[] temp, int low, int mid, int high)
    {
        int firstArrayIdx = low;
        int secondArrayIdx = mid+1;
        int k = low;

        while (firstArrayIdx <= mid && secondArrayIdx <= high)
        {
            if (arr[firstArrayIdx] <= arr[secondArrayIdx])
            {
                temp[k++] = arr[firstArrayIdx];
                firstArrayIdx++;
            }
            else
            {
                temp[k++] = arr[secondArrayIdx];
                secondArrayIdx++;
            }
        }

        while (firstArrayIdx <= mid)
        {
            temp[k++] = arr[firstArrayIdx];
            firstArrayIdx++;
        }

        while (secondArrayIdx <= high)
        {
            temp[k++] = arr[secondArrayIdx];
            secondArrayIdx++;
        }

        for (int i = 0; i <= high; i++)
        {
            arr[i] = temp[i];
        }

    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
        Program.MergeSort(array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

}
