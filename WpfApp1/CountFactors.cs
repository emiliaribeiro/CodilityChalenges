using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CountFactors
    {
        public CountFactors()
        {
            
        }

        public int solution(int N)
        {
            int max = N;
            HashSet<int> numbersMulti = new HashSet<int>();
            if (N == 1)
            {
                return 1;
            }

            for (int i =1; i <= Math.Sqrt(N); i++)
            {
                if(N % i == 0)
                {
                    numbersMulti.Add(i);
                    numbersMulti.Add(N/i);

                }
            }
            return numbersMulti.Count();
        }

        public int solutionB(int N)
        {
            int max = N;
            HashSet<int> sum = new HashSet<int>();
            if (N == 1)
            {
                return 4;
            }

            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    sum.Add(2 * (i + N / i));
                }
            }
            return sum.Min();
        }
    }
}
