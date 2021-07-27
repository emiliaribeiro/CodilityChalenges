using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CountNonDivisible
    {

        public CountNonDivisible()
        {

        }

        public int[] solution(int[] A)
        {
            Dictionary<int, int> numberListOfDivisors = new Dictionary<int, int>();
            int[] nonDivisors = new int[A.Length];
            int[] Aux = new int[A.Length];
            Array.Copy(A, Aux, A.Length);
            Array.Sort(Aux);
            int[] nonDivisorsByElement = new int[A.Length];
            
            int i = 0;
          
            int count = 0;
            int j;
            
            //numberListOfDivisors.Add(Aux[0], 0);

            while (i < A.Length)
            {
              
                int bigers = Aux.Count(x => x > Aux[i]);
                
                //ver o caso em que sao iguais
                count = bigers;
                j = i - 1;
 
                while ( j >= 0)
                {
                    if (Aux[i] % Aux[j] != 0)
                    {
                        count++;
                    }
                    j--;
                 }

                int equals = Aux.Count(x => x == Aux[i]) - 1;
                numberListOfDivisors.Add(Aux[i], count );
                

                i = i + equals +1;
            }

            for(int k=0; k< A.Length; k++)
            {
                nonDivisors[k] = numberListOfDivisors[A[k]];
            }

         return nonDivisors;
        }
    }
}
