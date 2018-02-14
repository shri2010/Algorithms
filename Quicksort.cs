using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Algorithms
{

    public class Quicksort
    {
        public static void Main(string[] args)
        {
            List<int> data = new List<int>();
            Parallel.ForEach(Console.ReadLine().Split(' '), (element) =>
            {
                data.Add(Convert.ToInt32(element));
            });

            int[] dataSet = QuicksortArray(data.ToArray(), 0, data.Count);

            foreach (var item in dataSet)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] QuicksortArray(int[] dataElements, int start, int end)
        {
            if (end-start>=1)
            {
                int partitionedIndex =  PartitionArray(dataElements, start, end);
                QuicksortArray(dataElements, start, partitionedIndex-1);
                QuicksortArray(dataElements, partitionedIndex, end);

            }

            return dataElements; 
        }

        /// <summary>
        /// Partition the array based on pivot, by choosing it the first element
        /// </summary>
        /// <param name="dataElements"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static int PartitionArray(int[] dataElements, int start, int end)
        {
            int pivot = dataElements[start];
            int indexOfElmentBelowPivot = start + 1;
            for (int i = start+1; i < end; i++)
            {
                if (dataElements[i] <= pivot) // checking if the element is less than pivot element and if found yes then increment pointer and exchanging smaller element with current index
                {
                    int temp = dataElements[i];
                    dataElements[i] = dataElements[indexOfElmentBelowPivot];
                    dataElements[indexOfElmentBelowPivot] = temp;
                    indexOfElmentBelowPivot++;
                }
            }
            int tempVar = dataElements[indexOfElmentBelowPivot - 1]; // moving pivot to its respective position
            dataElements[indexOfElmentBelowPivot - 1] = dataElements[start];
            dataElements[start] = tempVar;
            return indexOfElmentBelowPivot;
        }
    }
}
