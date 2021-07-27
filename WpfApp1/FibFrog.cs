using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class FibFrog
    {
        public FibFrog()
        {

        }

        public int solution(int[] A)
        {
            //The frog can jump between positions −1 and N(the banks of the river) --> N+1
            //and every position containing a leaf.
            int[] sequence = Sequence(A.Length);

            for (int i= 0; i< A.Length; i++)
            {
               
            }
            return 0;
        }

        public int[] Sequence(int N)
        {
            int[] sequence = new int[N];

            if (N == 0)
            {
                sequence[0] = 0;
            }
            else
            if (N == 1)
            {
                sequence[0] = 0;
                sequence[1] = 1;
            }
            else
            {
                sequence[0] = 0;
                sequence[1] = 1;

                for (int i = 2; i < N; i++)
                {
                    double aux1 = (1 + Math.Sqrt(5)) / 2;
                    double aux2 = (1 - Math.Sqrt(5)) / 2;
                    double aux3 = Math.Pow(aux1, i);
                    double aux4 = Math.Pow(aux2, i);
                    double aux5 = (aux3 - aux4) / Math.Sqrt(5);
                    sequence[i] = (int)aux5;
                }
            }

            return sequence;
        }
    }
}
