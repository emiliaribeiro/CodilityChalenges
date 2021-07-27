using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MinMaxDivision
    {
        public MinMaxDivision()
        {
            int[] A = { 2,1,5,1,2,2,2};

            int K = 3;
            int M = 5;
            int position = solution(K, M,  A);
        }

        public int solution(int K, int M, int[] A)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {//get the sum as max, and the largest number as min
                max += A[i];
                min = Math.Max(min, A[i]);
            }

            int result = max;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (divisionSolvable(mid, K - 1, A))
                {
                    max = mid - 1;
                    result = mid;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return result;
        }
        private bool divisionSolvable(int mid, int k, int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (sum > mid)
                {
                    sum = a[i];
                    k--;
                }
                if (k < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}