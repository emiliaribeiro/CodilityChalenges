using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class NumberOfDiscIntersections
    {
        public NumberOfDiscIntersections()
        {
            int[] A = {1, 2147483647, 0};
            int result = solution(A);
        }

        public int solution(int[] A)
        {
            List<int> range = new List<int>();
            Dictionary<int, List<int>> indiceRangeI = new Dictionary<int, List<int>>();
            
            for (int i= 0; i < A.Length; i++)
            {
                range = new List<int>();
                if(A[i] == 2147483647)
                {
                    range.Add(-2147483647);
                    range.Add(2147483647);
                }
                else
                {
                    range.Add(i - A[i]);
                    range.Add(i + A[i]);
                }

                indiceRangeI.Add(i, range);
            }
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i+1; j < A.Length; j++)
                {
                    int maxInf = Math.Max(indiceRangeI[i][0], indiceRangeI[j][0]);
                    int minSup = Math.Min(indiceRangeI[i][1], indiceRangeI[j][1]);

                    if (maxInf <= minSup)
                    {
                        count++;

                        if (count > 10000000)
                        { return -1; }
                    }
                }
            }

            

            return count;
        }
    }
}
