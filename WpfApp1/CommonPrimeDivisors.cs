using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CommonPrimeDivisors
    {
        HashSet<int> primes = new HashSet<int>();
        Dictionary<int, HashSet<int>> primesFounded = new Dictionary<int, HashSet<int>>();

        public CommonPrimeDivisors()
        {

        }

        public int solution(int[] A, int[] B)
        {
            int count = 0;

            if(A.Length == 1 && A.Length ==1 && (A[0] == 1 || B[0] == 1))
            {
                return 1;
            }

            Initialize(A,B);

            for (int i = 0; i < A.Length; i++)
            {
                HashSet<int> d1 = new HashSet<int>();

                HashSet<int> d2 = new HashSet<int>();

                if (primesFounded.Keys.Contains(A[i]))
                {
                    d1 = primesFounded[A[i]];
                }
                else
                {
                    d1 = divisors(A[i]);
                    primesFounded.Add(A[i], d1);
                }

                if (primesFounded.Keys.Contains(B[i]))
                {
                    d2 = primesFounded[B[i]];
                }
                else
                {
                    d2 = divisors(B[i]);
                    primesFounded.Add(B[i], d2);
                }
                

                if (d1.SetEquals(d2))
                {
                    count++;
                }

            }

            return count;
        }

        private HashSet<int> DecompFactPrimes(int number)
        {
            HashSet<int> d = new HashSet<int>();
            int result = number;
            int i= 0;
            
            if (number == 1)
            {
                d.Add(0);
                return d;
            }

            while (result != 1 && i< primes.Count)
            {
                if (primes.Contains(result))
                {
                    d.Add(result);
                    result = 1;
                }
                else
                if (result % primes.ElementAt(i) ==0)
                {
                    d.Add(primes.ElementAt(i));

                    result = result / primes.ElementAt(i);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return d;
        }

        public void Initialize(int[] A, int[] B)
        {
            int maxA = A.Max();
            int maxB = B.Max();

            int min = Math.Min(maxA, maxB);

            primesNumbers(min);
    
        }



        //retorna os divisores primos de um numero
        private HashSet<int> divisors(int number)
        {
            HashSet<int> m = new HashSet<int>();

            if (primes.Contains(number))
            {
                m.Add(number);
                return m;
            }

            for (int i = 2; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                {
                    if (primes.Contains(i))
                    {
                        m.Add(i);
                    }
                    if (primes.Contains(number / i))
                    {
                        m.Add(number / i);
                    }
                }
            }

            return m;
        }

        public void primesNumbers(int number)
        {
          

            //numero / IsPrime
            Dictionary<int, int> erastothenes = new Dictionary<int, int>();

            for (int i = 2; i <= number; i++)
            {
                erastothenes.Add(i, 2);
                primes.Add(i);
            }

            int position = 2;


            while (position < number && position != 0)
            {
                for (int i = position + 1; i <= number; i++)
                {
                    if (erastothenes[i] == 2 && i % position == 0)
                    {
                        erastothenes[i] = 0;
                        primes.Remove(i);
                    }

                }
                erastothenes[position] = 1;
                position = erastothenes.FirstOrDefault(x => x.Value == 2).Key;
            }

            //return primes;
        }
    }
}
