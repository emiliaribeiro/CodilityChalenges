using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MaxSlice
    {
        public MaxSlice()
        {
            int[] A = { 23171
,21011
 , 21123
  , 21366
  ,21013
  ,21367};
            //int result = solutionB(A);
            int result = solutionBProfitTentativa(A);
        }

        //O(n) só falha num caso, 93%
        public int solutionB
            (int[] A)
        {
            int max_end = 0;
            int max_slice = 0; 

            if (A.Length == 0)
            { return 0; }

            if (A.Length == 1)
            { return A[0]; }

            if (A.Max() < 0)
            {
                max_end = 0;
                max_slice = -1000000;

                foreach (int number in A)
                {

                    if (max_end == -2147483647)
                    {
                        max_end = number;
                    }
                    else
                    {
                        max_end = Math.Max(-1000000, max_end + number);
                    }


                    max_slice = Math.Max(max_slice, max_end);

                }
            }
            else { 
            foreach (int number in A)
            {
                if (max_end == 2147483647)
                {
                    max_end = number;
                }
                else
                {
                    if (max_end == -2147483647)
                    {
                        max_end = Math.Max(0, number);
                    }
                    else
                    {
                        max_end = Math.Max(0, max_end + number);
                    }
                }

                max_slice = Math.Max(max_slice, max_end);

            }
            }
            return max_slice;
        }

        //O(n^2)
        public int solution(int[] A)
        {
            int result = A[0];
            int sum;
            for (int i = 0; i < A.Length; i++)
            {
                sum = 0;

                //j começa no i pk pode existir um slice so de um elemento
                for (int j = i; j < A.Length; j++)
                {
                    sum = sum + A[j];
                    result = Math.Max(result, sum);
                }

            }

            return result;
        }

        //O(n) --> 100%
        public int solutionBProfitTentativa
            (int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }

            if (A.Length == 1)
            {
                return 0;
            }

            int max_profit = 0; ;
            int min = A[0];
            for (int i=1; i < A.Length; i++)
            {
                min = Math.Min(min, A[i]);
                max_profit = Math.Max(max_profit, A[i] - min);
            }

            if (max_profit <= 0)
            {
                return 0;
            }

            return max_profit;
        }

        //O(n^2)
        public int solutionProfitON(int[] A)
        {
            if(A.Length == 0)
            {
                return 0;
            }

            if (A.Length == 1)
            {
                return 0;
            }

            int M = 0;
            int begin = 0;
            int end = 1;
            bool constinueSearching = true;
            int value;

            while(constinueSearching)
            {
                value = A[end] - A[begin];
                M = Math.Max(M, value);

                if(begin == A.Length -2)
                {
                    constinueSearching = false;
                }
                else
                {
                    if (end == A.Length - 1)
                    {
                        begin++;
                        end = begin + 1;
                    }
                    else
                    {
                        end++;
                    }
                }
            }

            if (M <= 0)
            {
                return 0;
            }

            return M;
        }


        //O(n^2)
        public int solutionProfit(int[] A)
        {
            int result = 0;
            int sum;
            for (int i = 0; i < A.Length; i++)
            {
                sum = 0;

                //j começa no i pk pode existir um slice so de um elemento
                for (int j = i +1; j < A.Length; j++)
                {
                    sum = A[j] - A[i];
                    result = Math.Max(result, sum);
                }

            }

            return result;
        }

        public int solutionProfitB(int[] A)
        {
            int result = 0;
            int dif;
       
            Dictionary<int, int> ts = A.Select((index, value) => new { index, value })
                      .ToDictionary(pair => pair.value, pair => pair.index);
            for (int i = 0; i < A.Length-1; i++)
            {
                ts.Remove(i);

                int max = ts.Values.Max();
                dif =  max - A[i] ;
                result= Math.Max(result, dif);

            }

            return result;
        }
    }
}
