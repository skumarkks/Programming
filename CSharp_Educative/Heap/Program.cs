using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class MaxHeap
    {
        public List<int> heap = new List<int>();
        public int heapSize = 0;

        public MaxHeap(List<int> array)
        {
            heap = BuildHeap(array);
        }

        private List<int> BuildHeap(List<int> array)
        {
            int firstParentIx = (array.Count - 2) / 2;
            for (int currentIdx = firstParentIx; currentIdx >= 0; currentIdx--)
            {
                SwiftDown(currentIdx, array.Count - 1, array);
                heapSize = array.Count;
            }
            return array;
        }

        private void SwiftDown(int currentIdx, int endIdx, List<int> heap)
        {
            int childOneIdx = currentIdx * 2 + 1;

            while (childOneIdx <= endIdx)
            {
                int childTwoIdx = currentIdx * 2 + 2 <= endIdx ? currentIdx * 2 + 2 : -1;

                int idxToSwap;

                if (childTwoIdx != -1 && heap[childTwoIdx] > heap[childOneIdx])
                    idxToSwap = childTwoIdx;
                else
                    idxToSwap = childOneIdx;

                if (heap[idxToSwap] > heap[currentIdx])
                {
                    swap(heap, idxToSwap, currentIdx);
                    currentIdx = idxToSwap;
                    childOneIdx = currentIdx * 2 + 1;
                }
                else
                {
                    return;
                }
            }
        }

        public void SwiftUp(int currentIdx, List<int> heap)
        {
            int parentIdx = (currentIdx - 1) / 2;
            while (currentIdx >= 0 && heap[currentIdx] > heap[parentIdx])
            {
                swap(heap, currentIdx, parentIdx);
                currentIdx = parentIdx;
                parentIdx = (currentIdx - 1) / 2;

            }
        }

        public int Peek()
        {
            return heap[0];
        }

        public int Remove()
        {
            swap(heap, 0, heap.Count - 1);
            int valueToRemove = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            SwiftDown(0, heap.Count - 1, heap);
            heapSize--;
            return valueToRemove;
        }

        public void Insert(int value)
        {
            heap.Add(value);
            SwiftUp(heap.Count - 1, heap);
            heapSize++;
        }


        private void swap(List<int> array, int idxToSwap, int currentIdx)
        {
            int temp = array[idxToSwap];
            array[idxToSwap] = array[currentIdx];
            array[currentIdx] = temp;
        }
    }


    public class MinHeap
    {
        public List<int> heap = new List<int>();
        public int heapSize = 0;

        public MinHeap(List<int> array)
        {
            heap = BuildHeap(array);
        }

        private List<int> BuildHeap(List<int> array)
        {
            int firstParentIx = (array.Count - 2) / 2;
            for (int currentIdx = firstParentIx; currentIdx >= 0; currentIdx--)
            {
                SwiftDown(currentIdx, array.Count - 1, array);
                heapSize = array.Count;
            }
            return array;
        }

        private void SwiftDown(int currentIdx, int endIdx, List<int> heap)
        {
            int childOneIdx = currentIdx * 2 + 1;

            while(childOneIdx <= endIdx)
            {
                int childTwoIdx = currentIdx * 2 + 2 <= endIdx ? currentIdx * 2 + 2 : -1;

                int idxToSwap;

                if (childTwoIdx != -1 && heap[childTwoIdx] < heap[childOneIdx])
                    idxToSwap = childTwoIdx;
                else
                    idxToSwap = childOneIdx;

                if(heap[idxToSwap] < heap[currentIdx])
                {
                    swap(heap, idxToSwap, currentIdx);
                    currentIdx = idxToSwap;
                    childOneIdx = currentIdx * 2 + 1;
                }
                else
                {
                    return;
                }
            }            
        }

        public void SwiftUp(int currentIdx, List<int> heap)
        {
            int parentIdx = (currentIdx - 1) / 2;
            while (currentIdx >= 0 && heap[currentIdx] < heap[parentIdx])
            {
                swap(heap, currentIdx, parentIdx);
                currentIdx = parentIdx;
                parentIdx = (currentIdx - 1) / 2;

            }
        }
        
        public int Peek()
        {
            return heap[0];
        }

        public int Remove()
        {
            swap(heap, 0, heap.Count - 1);
            int valueToRemove = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            SwiftDown(0, heap.Count - 1, heap);
            heapSize--;
            return valueToRemove;
        }

        public void Insert(int value)
        {
            heap.Add(value);
            SwiftUp(heap.Count - 1, heap);
            heapSize++;
        }


        private void swap(List<int> array, int idxToSwap, int currentIdx)
        {
            int temp = array[idxToSwap];
            array[idxToSwap] = array[currentIdx];
            array[currentIdx] = temp;
        }
    }
    /*class Program
    {
        static void Main(string[] args)
        {
            //var test1 = new List<int>() { 2, 1, 3, 6 };

            var test1 = new List<int>() {2,3,1 };

            var heap = new Heap(test1);

            heap.Insert(-1);
            heap.Remove();
            

        }
    }*/
}
