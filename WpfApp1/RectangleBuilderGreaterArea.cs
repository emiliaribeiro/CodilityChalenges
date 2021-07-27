using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class RectangleBuilderGreaterArea
    {
        public RectangleBuilderGreaterArea()
        {
            int[] A = { 6,6,6,6 };
            int result = solution(A, 10);
        }

        public int solution(int[] A, int X)
        {
            if (A.Length < 4 )
            {
                return 0;
            }

             int result = 0;

            Array.Sort(A);

            Dictionary<int, int> valueCount = new Dictionary<int, int>();

            foreach(int number in A)
            {
                if (valueCount.ContainsKey(number))
                {
                    valueCount[number]++;
                }
                else
                {
                    valueCount.Add(number, 1);
                }
            }

            int begin = valueCount.Count()-1;
            int end;

            if (begin == 0 && valueCount.ElementAt(begin).Value >= 4 && valueCount.ElementAt(begin).Key * valueCount.ElementAt(begin).Key >= X)
            {
                return 1;
            }

            while (begin >= 2)
            {
                if (valueCount.ElementAt(begin).Value >= 4)
                {
                    end = begin;
                }
                else
                {
                    end = begin -1;
                }

                if(valueCount.ElementAt(begin).Value >=2)
                {
                    while(end >=0)
                    {
                        if (valueCount.ElementAt(end).Value >= 2
                        && valueCount.ElementAt(end).Key * valueCount.ElementAt(begin).Key >= X)
                        {
                            result++;
                        }

                        end--;
                    }

                    if (end == -1)
                    {
                        begin = begin - 1;
                    }
                }
                else
                {
                    begin = begin - 1;
                }
            }

            if (result > 1000000000)
            {
                return -1;
            }

            return result;
        }
    }
}
