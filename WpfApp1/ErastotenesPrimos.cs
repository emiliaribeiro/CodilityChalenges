using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ErastotenesPrimos
    {
        public ErastotenesPrimos()
        {

        }

        public List<int> simpleSieve(int limit)
        {
            List<int> primes = new List<int>();
              bool[] mark = new bool[limit];
            mark = mark.Select(i => true).ToArray();

            
            for (int p = 2; p * p < limit; p++)
            {
                // If p is not changed, then it is a prime
                if (mark[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * p; i < limit; i += p)
                        mark[i] = false;
                }
            }

            for (int i = 2; i< mark.Length; i++)
            {
                if (mark[i] == true)
                {
                    primes.Add(i);
                }
            }
            return primes;

        }
    }
}
