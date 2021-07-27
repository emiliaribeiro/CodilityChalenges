using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Repeated_String
    {

        public Repeated_String()
        {
            string s = "abacaba";
            //int result = threeCharsDistinct(s);

            int[] numb = { 1, 3, 2, 1 };
            almostIncreasingSequence(numb);

        }

        bool almostIncreasingSequence(int[] sequence)
        {

            int count = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    if (i + 2 < sequence.Length && sequence[i] < sequence[i + 2])
                    {
                        count++;
                        i++;
                    }
                    else
                      if (i - 1 >= 0 && sequence[i - 1] < sequence[i + 1])
                    {
                        count++;
                        i++;
                    }
                }
            }

            if (count > 1)
                return false;
            else
                return true;
        }

        int[] prefixSumsToSuffixSums(int[] prefixSums)
        {

            int sum = prefixSums[prefixSums.Length - 1];

            int[] suffix = new int[prefixSums.Length];

            for (int i = 0; i < prefixSums.Length; i++)
            {
                suffix[i] = sum;
                sum -= prefixSums[i];
            }

        

            return suffix;
        }

        int threeCharsDistinct(string s)
        {
            int count = 0;
            List<char> chars = s.ToList();
            for (int i=0; i < chars.Count -2; i++)
            {
                if (chars.ElementAt(i) != chars.ElementAt(i + 1) &&
                    chars.ElementAt(i + 1) != chars.ElementAt(i + 2) &&
                    chars.ElementAt(i) != chars.ElementAt(i + 2))
                    count++;
            }

            return count;
        }


        double arrayMedian(int[] sequence)
        {

            Array.Sort(sequence);

            int lenght = sequence.Length;
            int midle;
            if (lenght % 2 != 0)
            {
                midle = lenght / 2;
                return sequence[midle];
            }
            else
            {
                midle = lenght / 2;
                int midle2 = midle -1;
                double result = (double) (sequence[midle] + sequence[midle2]) / 2;
                return result;
            }
                return 0;

        }
        int addTwoDigits(int n)
        {
            int firstD = n / 10;
            int secondD = n % 10;
            return 2;
        }

        public long repeatedString(string s, long n)
        {
            long countA = 0;

            foreach(char c in s)
            {
                if (c == 'a')
                {
                    countA++;
                }
            }

            int stringLenght = s.Length;

            long div = n % stringLenght;

            if(div == 0)
            {
                countA = (n / stringLenght) * countA;
            }
            else
            {
                countA = (long)Math.Truncate((double)n / stringLenght) * countA;
                long count = (long)Math.Truncate((double)n / stringLenght) * stringLenght;
                int i = 0;
                while (count <= n)
                {
                    if(s.ElementAt(i) == 'a')
                    {
                        countA++;
                    }
                    count++;
                    i++;
                }
            }

            return countA;
        }
    }
}
