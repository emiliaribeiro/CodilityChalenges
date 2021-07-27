using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Frog
    {
        public Frog()
        {

        }

        public int solution(int X, int Y, int D)
        {
            int count = 0;
            int diference = Y - X;
    


            if (diference % D == 0)
            {
                count = diference / D;
            }
            else
            {
                count = diference / D + 1;
            }
            return count;
        }
    }
}
