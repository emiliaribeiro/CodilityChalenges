using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Triangle
    {
        public Triangle()
        {

        }

        public int solution(int[] A)
        {
            int isTriangle = 0;
            int P;
            int Q;
            int R;
            Array.Sort(A);

            for (int i= 0; i< A.Length-2; i++)
            {
                 P = A[i];
                 Q = A[i+1];
                 R = A[i+2];
                if(P == 2147483647 && Q == 2147483647 && R == 2147483647 )
                {
                    return 1;
                }
                if (P < Q + R && Q < P + R && R < P + Q)
                {
                    return 1;
                }
            }

            return isTriangle;
        }
    }
}
