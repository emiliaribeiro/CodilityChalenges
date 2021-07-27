using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CountDiv
    {
        public CountDiv()
        {

        }

        public int solution(int A, int B, int K)
        {
            int count = 0;
            if (A == 0)
            {
                count = 1;

                if (B==0 || B< K)
                {
                    return count;
                }
            }

            int firstMultiple = this.FirstMultiple(A, K);

            if(firstMultiple * K == B)
            {
                return 1;
            }
            
            
           
           for (int i = firstMultiple; i * K<= B; i++)
            { 
                count++;
        
            }

            return count;
        }

        private int FirstMultiple(int A, int k)
        {
            if(A < k)
            {
                return 1;
            }
            else
            {
                if (A % k == 0)
                {
                    return A / k;
                }
                else
                {
                    double value = A / k;
                    int t = (int)Math.Truncate(value);
                    return t + 1;
                }
            }
        }
    }
}
