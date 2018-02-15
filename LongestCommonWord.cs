using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Longest Common Word 
    /// Find the longest common word between two strings
    /// ex:  abcd   defab  length 2 of ab
    ///
    /// </summary>
    public class LongestCommonWord
    {
        static void Main(string[] args)
        {
            var firstWord = (from element in Console.ReadLine().ToCharArray()
                             select element.ToString()).ToArray();

            var secondWord = (from element in Console.ReadLine().ToCharArray()
                             select element.ToString()).ToArray();
            int maxSize = firstWord.Count() > secondWord.Count() ? firstWord.Count() : secondWord.Count();
            int[,] commonWord = new int[maxSize+1, maxSize+1];

            int maxLength = 0;
            for (int i = 0; i < maxSize; i++)
            {
                commonWord[i, maxSize] = 0;
            }

            for (int i = 0; i < maxSize; i++)
            {
                commonWord[maxSize, i] = 0;
            }
            // check using a table for each values whether they are matching or not
            for (int i = secondWord.Count() - 1; i >= 0; i--)
            {
                for (int j = firstWord.Count() - 1; j >= 0; j--)
                {
                    if (firstWord[j]==secondWord[i])
                    {
                        commonWord[j, i] = 1 + commonWord[j+1, i+1];
                    }
                    else
                    {
                        commonWord[j, i] = 0;
                    }
                    if (commonWord[j, i]> maxLength)
                    {
                        maxLength = commonWord[j, i];
                    }
                }
            }

        }

    }
}
