using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PermMissingElem
    {
        private Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        public PermMissingElem()
        {
            int[] A = { };
            int value = solutionB(A);
        }

        public int solutionB(int[] A)
        {

            if (A.Length == 0)
            {
                    return 1;
            }

            if (A.Length ==1)
            {
                if (A[0] == 1)
                    return 2;
                else
                    return 1;
            }

            Array.Sort(A);
            int begin = 0;
            int end = A.Length - 1;
            int missingElement = 0;
            bool continuSearching = true;

            if (A[0] !=1)
            { return 1; }

            if(A[A.Length -1] == A.Length )
            { return A.Length +1; }

            while (continuSearching)
            {
                if (A[begin +1] - A[begin] !=1)
                {
                    missingElement = A[begin] + 1;
                    continuSearching = false;
                }
                if (A[end ] - A[end -1] != 1)
                {
                    missingElement = A[end] - 1;
                    continuSearching = false;
                }

                if(continuSearching)
                {
                    begin++;
                    end--;
                    continuSearching = (begin < end);
                }
            }

            return missingElement;
        }

        public int solution(int[] A)
        {
            if (A.Length > 0)
            {
                int min = A.Min();
                if (A.Length == 1)
                {
                    if (min != 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return min + 1;
                    }
                }
                else
                {
                    return this.FoundMissingValue(A.Length, min, A);
                }
            }
            else
            {
                return 1;
            }
        }

        private int FoundMissingValue(int length, int min, int[] A)
        {
            int auxSum = 0;
            foreach(int i in A)
            {
                auxSum += i;
            }

            int SumTotal = (A.Length +1) * (A.Length + 2) / 2;
            //bool founded = false;
            //int element = min;
            //for (int i=min; i <length + min && !founded; i++)
            //{
            //    if (!A.Contains(i))
            //    {
            //        founded = true;
            //        element = i;
            //    }    
            //}

            //if (founded)
            //{
            //    return element;
            //}
            //else
            //{
            //    if (min != 1)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return A.Max() + 1;
            //    }

            //}

            return SumTotal - auxSum;
        }
    }
}
