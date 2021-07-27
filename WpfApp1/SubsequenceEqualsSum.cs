using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class SubsequenceEqualsSum
    {
        public SubsequenceEqualsSum()
        {

        }

        //descobrir se há uma subsequencia cuja soma = a um valor dado
        public bool SubSum(int[] A, int sum)
        {
            int subSum;
            int back = 0;
            int front = 1;
    
            bool exists = false;

            if (A[0] == sum)
            {
                return true;
            }
            else
            {
                subSum = A[back];
            }
            
            //O(n)
            //Ao total vai sempre acrescentando um valor da frente se
            //ultrapassar retira à soma o primeiro e continua a somar

            while (front < A.Length && !exists)
            {
                
                subSum += A[front];
                if(subSum == sum)
                {
                    exists = true;
                }
                else
                {
                    if (subSum < sum)
                    {
                        front++;
                    }
                    else
                    {
                        subSum -= A[back];
                        front++;

                        if (subSum == sum)
                        {
                            exists = true;
                        }
                        else
                        {
                           
                            back++;
                        }

                    }
                }
            }

            return exists;
        }
    }
}
