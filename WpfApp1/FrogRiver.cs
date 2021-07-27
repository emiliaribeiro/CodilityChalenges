using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class FrogRiver
    {
        public FrogRiver()
        {
            int[] A = { 1, 3, 1, 4, 2, 3, 5, 4 };
            int result = solution(5, A);
        }

        
        public int solution(int X, int[] A)
        {
            int position = -1;
            Dictionary<int, int> auxList = new Dictionary<int, int>();
            for (int i = 0; i<= X; i++ )
            {
                auxList.Add(i, 0);
            }
   
            int sumtotal = auxList.Keys.Sum();
            bool founded = false;
            int actualSum = 0;

            for (int i = 0; i < A.Length && !founded; i++)
            {
                if(auxList[A[i]] ==0)
                {
                    auxList[A[i]] = 1;
                    actualSum += A[i];

                    if (actualSum == sumtotal)
                    {
                        founded = true;
                        position = i;
                    }
                }
            }

            return position;
        }
    }
}
