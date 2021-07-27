using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MaxCounters
    {
        
        public MaxCounters()
        {
            int[] A = { 3};
            int[] result = solution(5, A);
        }

        public int[] solution(int N, int[] A)
        {
            int[] counters = new int[N];
            for (int i=0; i<N; i++)
            {
                counters[i] = 0;
            }

            int aux;
            int max = 0;

            for (int i= 0; i< A.Length; i++)
            {
                aux = A[i];

                if(aux == N+1)
                {
                    for (int j = 0; j < N; j++)
                    {
                        counters[j] = max;
                    }
                }
                else
                {
                    counters[aux - 1] = counters[aux - 1] +1;
                    max = Math.Max(max, counters[aux - 1]);
                }
            }

            return counters;
        }
    }
}
