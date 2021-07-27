using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MissingInteger
    {
        public MissingInteger()
        {
           int [] A = { 10 };
           int reuslt = solution(A);
        }

        // returns the smallest positive integer (greater than 0)
        public int solution(int[] A)
        {
            Array.Sort(A);

            List<int> B = A.ToList();

            if(A.Length == 1)
            {
                if (A[0] != 1 )
                {
                    return 1;
                }
            }

            int aux = 0;

            int dif = 0;

            if (A[A.Length -1] < 0)
            {
                return 1;
            }
            else
            {
                int ele = A.FirstOrDefault(x => x >= 0);

                if(ele > 1)
                { return 1; }

                aux = B.IndexOf(ele);

                while (aux < A.Length -1 && (A[aux +1] - A[aux] == 1 || A[aux + 1] - A[aux] == 0))
                {
                    aux++;
                }
            }

            return A[aux] +1;
        }
    }
}
