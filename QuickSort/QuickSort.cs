using System;
public class Program
{
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

    public static void Main(string[] arg)
    {
        int[] array = new int[] { 3,2,1 };
        array = Program.QuickSort(array);

        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }
    }
}
