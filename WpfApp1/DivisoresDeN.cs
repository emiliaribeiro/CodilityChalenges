using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DivisoresDeN
    {
        public DivisoresDeN()
        {

            int result = solution(36);
        }

        //numero de divisores de N
        //O(raiz de N)
        public int solution(int N)
        {
            int result = 0;

            if(N ==1)
            {
                return result = 1;
            }

            int i = 1;

            while ( i*i < N)
            {
                if(N % i == 0)
                {
                    result += 2;
                }
                
                i = i +1;
            }

            if (i*i == N)
            {
                result += 1;
            }

            return result;
        }
    }
}
