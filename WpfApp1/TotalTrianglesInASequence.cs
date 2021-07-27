using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class TotalTrianglesInASequence
    {
        public TotalTrianglesInASequence()
        {

        }

        // A estão ordenados
        //Para encontrar um triangulo basta encontrar um x<y<z: ax + ay > az
        //Para qualquer k: y<k<z, continua a verificar-se ax+ak > az
        //O(n^2)
        public int Triangles(int[] A)
        {
            int total = 0;
            int z;
            for (int x=0; x < A.Length; x++)
            {
                z = x + 2;

                for (int y = x+1; y < A.Length - 1; y++ )
                {
                    while(A[x] + A[y] > A[z])
                    {
                        z++;
                    }

                    total += z - y - 1;
                }
            }

            return total;
        }
    }
}
