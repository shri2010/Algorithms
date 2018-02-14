using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
              List<int> data = new List<int>();
              Parallel.ForEach(Console.ReadLine().Split(' '), (x) =>
              {
                  data.Add(Convert.ToInt32(x));
              }
              );
            
            int [] datatest= MergeSort(data.ToArray(), 0, data.Count-1);
            foreach (var item in datatest)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] MergeSort( int[] dataValues, int start,int end)
        {
            if (start<end)
            {
                int mid = (start + end) / 2;
                MergeSort(dataValues, start, mid);
                MergeSort(dataValues, mid + 1, end);
                Merge(dataValues, start, mid,end);
            }
            return dataValues;
        }

        private static void Merge( int[] dataValues, int start,int mid, int end)
        {
            int[] data2 = new int[end-start+1];
            int j = start;
            int k = mid+1;

            for (int i = 0; i < data2.Length; i++)
            {
                if (j > mid)
                {
                    data2[i] = dataValues[k];
                    k++;
                }
                else if (k > end)
                {
                    data2[i] = dataValues[j];
                    j++;
                }

                else if (dataValues[j] < dataValues[k])
                {
                    data2[i] = dataValues[j];
                    j++;

                }
                else
                {
                    data2[i] = dataValues[k];
                    k++;
                }

            }

            for (int n = start; n < data2.Length; n++)
            {
                dataValues[n] = data2[n];

            }

        }
    }
}
