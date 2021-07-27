using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MaxProductOfThree
    {
        public  MaxProductOfThree()
        {
            int[] A = { -5, 5, -5, 4 };
            int result = solution(A);
        }

        public int solution(int[] A)
        {
 
           Array.Sort(A);

            int max = A.Min();

            max = Math.Max(A[0] * A[1] * A[A.Length - 1], A[A.Length - 3] * A[A.Length - 2] * A[A.Length - 1]);

            return max;
        }
    }
}
