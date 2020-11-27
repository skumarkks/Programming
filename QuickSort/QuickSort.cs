using System;
public class Program
{
    /*
    //Method -1
    public static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i = i + 1;
                swap(array, i, j);
            }
        }
        
        swap(array, i + 1, high);
        return i + 1;
    }

    public static void swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIdx = Partition(array, low, high);
            QuickSort(array, low, pivotIdx-1);
            QuickSort(array, pivotIdx + 1, high);            
        }
    }

    public static int[] QuickSort(int[] array)
    {
        if (array.Length == 0 || array.Length == 1) return array;
        int low = 0;
        int high = array.Length - 1;
        QuickSort(array, low, high);
        // Write your code here.
        return array;
    }
    */

    public static int[] QuickSort(int[] array)
    {
        // Write your code here.
        QuickSort(array, 0, array.Length - 1);
        return array;
    }

    public static void QuickSort(int[] array, int left, int right)
    {
        if (left >= right) return;
        int pivot = array[(left + right) / 2];
        int ploc = Partition(array, left, right, pivot);
        QuickSort(array, left, ploc-1);
        QuickSort(array, ploc , right);
    
    }
    public static int Partition(int[] array, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (array[left] < pivot)
            {
                left++;
            }

            while (array[right] > pivot)
            {
                right--;
            }

            if (left <= right)
            {
                swap(array, left, right);
                left++;
                right--;
            }
        }
        return left;
    }
    public static void swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void Main(string[] arg)
    {
        int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
        array = Program.QuickSort(array);

        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }
    }
}
