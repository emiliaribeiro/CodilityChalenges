using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class TennisTournament
    {

        public TennisTournament()
        {
            int P = 2;
            int C = 3;
            int result = solution(P, C);
        }

        public int solution(int P, int C)
        {
            int count = 1;


            if (P == 1)
            { return 0; }

            if (C==1)
            { return 1; }


            while (count *2 <= P && count <= C)
            {
                count++;
            }

            return count -1;
        }
    }
}
