using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PermCheck
    {
        public PermCheck()
        {

        }

        public int solution(int[] A)
        {
           
            if (A.Length == 0)
            {
                return 0;
            }

            if (A.Length != A.Max() || A.Min() !=1)
            {
                return 0;
            }

            int isPerm = 1;
            Array.Sort(A);
     
            int last = 0;
            int dif = 0;
            foreach (int number in A)
            {
                dif = number - last;

                if(dif != 1)
                {
                    return 0;
                }
                else
                {
                    last = number;
                }
            }

            return isPerm;
        }
    }
}
