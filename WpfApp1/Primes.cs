using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Primes
    {

        public Primes()
        {

        }

        public List<int> primesNumbers (int number)
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
             

            while ( position < number && position != 0)
            {
                for(int i= position +1; i <=number; i++)
                {
                    if(erastothenes[i] ==2 && i % position ==0)
                    {
                        erastothenes[i] = 0;
                        vs.Remove(i);
                    }

                }
                erastothenes[position] = 1;
                position = erastothenes.FirstOrDefault(x => x.Value == 2).Key;
            }

            Dictionary<int, int> subArray = erastothenes.Where(x => x.Value == 1)
                            .ToDictionary(dict => dict.Key, dict => dict.Value);
            HashSet<int> h1 = new HashSet<int>(subArray.Keys);
            var test = erastothenes.Where(x => x.Value == 1);
            return vs;
        }
    }
}
