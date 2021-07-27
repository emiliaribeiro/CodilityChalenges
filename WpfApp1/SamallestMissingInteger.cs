using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class SamallestMissingInteger
    {
        public SamallestMissingInteger()
        {

        }
        public int solution(int[] A)
        {
            List<int> numberFrequency = new List<int>();
            foreach (int number in A)
            {
                if (number > 0)
                {
                    if (!numberFrequency.Contains(number))
                    {
                        numberFrequency.Add(number);
                    }
                }
            }

            if (numberFrequency.Count == 0 || numberFrequency.Min() > 1)
            {
                return 1;
            }
            else
            {
                bool founded = false;
                int count = 1;
                int min = numberFrequency.Min() + 1;
                while (!founded && count < numberFrequency.Count)
                {
                    if (numberFrequency.Contains(min))
                    {
                        min++;
                        count++;
                    }
                    else
                    {
                        founded = true;
                    }
                }

                return min;
            }
        }
    }
}
