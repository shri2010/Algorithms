using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SelectionSort
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();

            Parallel.ForEach(Console.ReadLine().Split(' '), (element) =>
            {

                data.Add(Convert.ToInt32(element));
            });

            int[] dataSet= SelectionSortArray(data.ToArray());

            foreach (var item in dataSet)
            {
                Console.WriteLine(item);
            }


        }

        /// <summary>
        /// Finding minimun element and moving it to front
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static int[] SelectionSortArray(int[] data)
        {
            int min = 0;
            for (int i = 0; i < data.Length; i++)
            {
                min = i;

                for (int j = i; j < data.Length; j++)
                {
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }

                int temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }
            return data;
        }
    }
}
