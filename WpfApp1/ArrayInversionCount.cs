using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ArrayInversionCount
    {
        public ArrayInversionCount()
        {
            //[0], [], [1,2,3], [1,1,1]
            int[] A = { 1, 1, 1 };

            int result = solution(A);
        }
        int solution(int[] A)
        {
            int result = 0;
           if (A.Length == 0 || A.Length == 1)
            {
                return 0;
            }

            if (A.Length == 2 && A[0] > A[1])
            {
                return 1;
            }
            if (A.Length == 2 && A[0] <= A[1])
            {
                return 0;
            }

            for (int i=0; i < A.Length -1; i++)
            {
                int elem = A[i];

                for (int j = i+1; j < A.Length; j++)
                {
                    if (A[j] == -2147483647 && A[i] != -2147483647)
                    {
                        result++;
                    }
                    else
                    {
                        if (A[i] == 2147483647 && A[j] != 2147483647)
                        {
                            result++;
                        }
                        else
                        if (A[j] < A[i])
                        {
                            result++;
                        }
                    }

                }

            }

            if (result == 1000000000)
            {
                return -1;

            }

            return result;

        }
    }
}
