using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class FibonnacciSequence
    {

        public FibonnacciSequence()
        {

        }

        //O(n)
        public int[] Sequence(int N)
        {
            int[] sequence = new int[N ];

            if(N == 0)
            {
                sequence[0] = 0;
            }else
            if (N==1)
            {
                sequence[0] = 0;
                sequence[1] = 1;
            }
            else
            {
                sequence[0] = 0;
                sequence[1] = 1;

                for (int i= 2; i< N; i++)
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
            }

            return sequence;
        }

        //O(logn)
        public int[] Sequence2(int N)
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
                    double aux5 = (aux3 -aux4)/Math.Sqrt(5);
                    sequence[i] = (int)aux5;
                }
            }

            return sequence;
        }
    }
}
