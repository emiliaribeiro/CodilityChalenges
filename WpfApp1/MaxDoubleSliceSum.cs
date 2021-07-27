using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MaxDoubleSliceSum
    {
        public MaxDoubleSliceSum()
        {
            int[] A = { 3, 2, 6, 4};
            int result = solutionBasica(A);
        }

        public int solutionBasica(int[] A)
        {
            int sum = 0;
            int sumi = 0;
            int sumj = 0;
            int sumk = 0;

            for (int i=0; i < A.Length -2; i++)
            {
                sumi = A[i];
                sumj = 0;
                for (int j = i+1; j < A.Length; j++)
                {
                    sumj = sumj + A[j];
                    sumk = A[j] + sumi;
                    for (int k = j+1; k < A.Length; k++)
                    {
                        sumk = Math.Max(sumk, sumk + A[k]);
                    }

                    sum = Math.Max(sum, sumk);
                    sumj = sumi + A[j];
                }

            }

            return sum;    

        }

        public int solution(int[] A)
        {
            int [] sumAsc = new int[A.Length];
            int[] sumDesc = new int[A.Length ];
            sumAsc[0] = A[0];

            //Y começa njo 1 e vai até N-2
            for (int i = 1; i < A.Length ; i++)
            {
                sumAsc[i] = Math.Max(sumAsc[i - 1] + A[i], 0);
            }

            sumDesc[A.Length - 1] = 0;
            for (int i = A.Length - 2; i >=0; i--)
            {
                sumDesc[i] = Math.Max(sumDesc[i + 1] + A[i], 0);
            }

            int max = sumAsc.ElementAt(1); 
            for (int i = 1; i < A.Length - 1; i++)
            {
                max= Math.Max(sumAsc[i-1] + sumDesc[i+1], max);
            }

            return max;
        }
    }

}
