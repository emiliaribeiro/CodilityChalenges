using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MMC
    {
        public MMC()
        {

        }

        public int MDC(int a,int b)
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
            return  m;
        }
    }
}
