using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CountSemiprimes
    {
        public CountSemiprimes()
        {

        }

        public int[] solution(int N, int[] P, int[] Q)
        {
            int[] semiprimes = new int[P.Length];
            int maxP = P.Max();
            int maxQ = Q.Max();
            int max = Math.Max(maxP, maxQ);
            int semiprimesCount = 0;
            List<int> primes = primesNumbers(max);
            HashSet<int> semiPrimes = semiPrimesNumbers(primes, N);
            //1 ≤ P[K] ≤ Q[K] ≤ N.


            for (int i = 0; i < P.Length; i++)
            {
                var aux1Position = semiPrimes.Where(x => x >= P[i] && x<= Q[i]);
               
                
                semiprimes[semiprimesCount] = aux1Position.Count();
                semiprimesCount++;
            }

            return semiprimes;
        }

        public List<int> primesNumbers(int number)
        {
            List<int> vs = new List<int>();

            //numero / IsPrime
            Dictionary<int, int> erastothenes = new Dictionary<int, int>();

            for (int i = 2; i <= number; i++)
            {
                erastothenes.Add(i, 2);
                vs.Add(i);
            }

            int position = 2;


            while (position < number && position != 0)
            {
                for (int i = position + 1; i <= number; i++)
                {
                    if (erastothenes[i] == 2 && i % position == 0)
                    {
                        erastothenes[i] = 0;
                        vs.Remove(i);
                    }

                }
                erastothenes[position] = 1;
                position = erastothenes.FirstOrDefault(x => x.Value == 2).Key;
            }

            return vs;
        }

        public HashSet<int> semiPrimesNumbers(List<int> primes, int number)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            HashSet<int> subArray = new HashSet<int>();

            //A semiprime is a natural number that is the product of two(not necessarily distinct) prime numbers.

            bool continueSearch = true;
            HashSet<int> aux;
            for (int i = 0; i < primes.Count && continueSearch; i++)
            {
                aux = new HashSet<int>();
                int j = i;
                while (primes[j] * primes[i] <= number && j < primes.Count)
                {
                    aux.Add(primes[j] * primes[i]);
                    j++;
                }

                subArray.UnionWith(aux);
            }

            return subArray;
        }
    }
}
