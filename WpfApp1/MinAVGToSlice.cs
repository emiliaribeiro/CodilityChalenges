using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MinAVGToSlice
    {
        public MinAVGToSlice()
        {

        }

        public int solution(int[] A)
        {
            double minAverage = 0;

            for (int i = A.Length; i > 1; i--)
            {
                this.FindMinSum(A, i);
            }

            minAverage= sumPosition.Keys.Min();

            int position = sumPosition[minAverage];
            return position;
        }
        Dictionary<double, int> sumPosition = new Dictionary<double, int>();
        private void FindMinSum(int[] a, int i)
        {
            int sum = 0;
            double average = 0;
            //soma-posiçao

            for (int k = 0; k + i <= a.Length; k++)
            {
                sum = 0;
                int countJ = 1;
                for (int j =k; countJ<=i && j < a.Length; j++)
                {
                    sum += a[j];
                    countJ++;
                }

                average = (double)sum / i;

                if (sumPosition.ContainsKey(average))
                {
                    if(sumPosition[average] > k)
                    {
                        sumPosition[average] = k;
                    }
                }
                else
                {
                    sumPosition.Add(average, k);
                }
                
            }
        }
    }
}
