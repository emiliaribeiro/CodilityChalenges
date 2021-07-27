using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class TriangularTriplet
    {
        public TriangularTriplet()
        {

        }

        //quantos triplets (x, y, z) com x<y<z que fazem um triangulo
        public int solution(int[] A)
        {
            int dimension = A.Length;
            int sum = 0;
            int aux = 0;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < dimension ; i++)
            {
                keyValuePairs.Add(i, A[i]);
            }

            for (int i=0; i<= dimension - 2; i++)
            {
                for (int j= i +1; j <= dimension - 1;  j ++ )
                {
                    aux = A[i] + A[j];
                    int z = keyValuePairs.Where(w => (w.Key > j && w.Key > i && w.Value < aux 
                    && A[j] - A[i] > -w.Value && A[i] - A[j] > -w.Value)).Count();

                    sum += z;
                }
            }
            return sum;
        }
    }
}
