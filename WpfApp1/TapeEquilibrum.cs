using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class TapeEquilibrum
    {
        public TapeEquilibrum()
        {
            int[] A = { -1000, 1000 };
            int result = solution(A);
        }

        public int solution(int[]A  )
        {
            int min;

            if (A.Length == 0 || A.Length == 1)
            {
                return 0;
            }
            else
            if(A.Length == 2)
            {
                int aux = A[1] - A[0];
                return aux;
            }
            else
            {
                int sum1 = A.ElementAt(0);
                int sum = A.Sum();
                int sum2 = A.Sum() - sum1;
                min = Math.Abs(sum1 - sum2);
                int dif = min;

                for (int i = 1; i < A.Length; i++)
                {
                    sum1 += A.ElementAt(i);
                    sum2 -= A.ElementAt(i);
                    dif = Math.Abs(sum1 - sum2);

                    if (dif < min)
                    {
                        min = dif;
                    }
                }

                return min;
            }
        }
    }
}
