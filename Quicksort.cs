using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            QuicksortArray(data.ToArray(), 0, data.Count);
        }

        private static void QuicksortArray(int[] dataElements, int start, int end)
        {
            if (start < end)
            {



            }
        }
    }
}
