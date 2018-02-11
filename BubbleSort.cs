using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort
    {

        static void Main(string[] args)
        {
            List<int> data = new List<int>();

            Parallel.ForEach(Console.ReadLine().Split(' '), (element) =>
            {
                data.Add(Convert.ToInt32(element));

            }

            );

            int[] datatest = BubbleSortArray(data.ToArray());
            foreach (var item in datatest)
            {
                Console.WriteLine(item);
            }


        }

        private static int[] BubbleSortArray(int[] dataValues)
        {

            for (int i = 0; i < dataValues.Length; i++)
            {
                for (int j = i+1; j < dataValues.Length; j++)
                {
                    if (dataValues[i]>dataValues[j])
                    {
                        int temp = dataValues[i];
                        dataValues[i] = dataValues[j];
                        dataValues[j] = temp;
                    }

                }
            }
            return dataValues;

        }
    }
}
