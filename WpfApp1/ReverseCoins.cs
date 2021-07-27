using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ReverseCoins
    {

        public ReverseCoins()
        {
            int n = 10;

            int result = solution(n);
        }

        private int solution(int n)
        {
            int j = 1;
            Dictionary<int, bool> indiceValue = new Dictionary<int, bool>();
            //0 virada para cima, 1 virada para baixo
            //inicialmente todas viradas cima
            for(int i=0; i<n; i++)
            {
                indiceValue.Add(i + 1, true);
            }

            int aux;
            while (j < n)
            {
                aux = j +1;
                while( aux <= n)
                {
                    indiceValue[aux] = !indiceValue[aux];
                    aux += j + 1;
                }

                j++;
            }

            int result = indiceValue.Where(x => x.Value == true).Count();

            return result;
        }
    }
}
