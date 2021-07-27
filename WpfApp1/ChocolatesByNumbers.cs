using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ChocolatesByNumbers
    {
        public ChocolatesByNumbers()
        {

        }

        public int solution(int N, int M)
        {
            
             if(N == 1)
            {
                return 1;
            }

            Dictionary<int, bool> positionIsAte = new Dictionary<int, bool>();
            positionIsAte.Add(0, true);
            int count = 1;

            for (int i= 1; i < N; i++)
            {
                positionIsAte.Add(i, false);
            }

            bool possible = true;
            int j;
            if ( M < N)
            {
                j = M;
            }
            else
            {
                if(M % N == 0)
                { 
                    return count; 
                }
                else
                {
                    j = M % N;
                }
            }

            while (possible)
            {
                if(positionIsAte[j] == false)
                {
                    positionIsAte[j] = true;
                    count++;
                }
                else
                {
                    possible = false;
                }
                 
                if (j +M < N)
                {
                    j = j + M;
                } 
                else
                {
                    if (M < N)
                    {
                        j = M - 1 - (N - 1 - j);
                    }
                    else
                    {
                        if (M % N <=  N-1-j)
                        {
                            j = j + M % N;
                        }
                        else
                        {
                            j = M % N - (N-1 -j)-1;
                        }
                    }
                }
            }


            return count;
        }

        public int solutionB(int N, int M)
        {
            if (N == 1)
            {
                return 1;
            }

            int mdc = MDC(N, M);
            int count = 0;
            while (mdc * count < N)
            {

                count++;
            }

            return count;

        }

        public int MDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            // se primos retorna 1
            return a;
        }

        public int mmc(int a, int b)
        {
            int m = a / MDC(a, b) * b;
            return m;
        }
    }
}
