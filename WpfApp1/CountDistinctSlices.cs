using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CountDistinctSlices
    {
        public CountDistinctSlices()
        {
        }
        public int solution(int M, int[] A)
        {
            int count = 0;
            int first = 0;//indice de onde começa
            int last = A[first];// ultimo elemento a ser observado
            int end = first; //indice do ultimo
            bool continueSearching = true;
            int min = A.Min();
            int max = A.Max();
            int maxRange = max - min + 1;
            HashSet<int> setForIndice = new HashSet<int>();
            // if the number of distinct slices is greater than 1,000,000,000,
            // the function should return 1,000,000,000
            if (A.Length == 1)
            {
                return 1;
            }

            while (continueSearching)
            {
                if (first == end)
                {
                    setForIndice = new HashSet<int>();
                    setForIndice.Add(A[first]);
                    count++;
                    if (count > 1000000000)
                    {
                        return 1000000000;
                    }


                    if (end + 1 < A.Length)
                    {
                        last = A[end];
                        end++;
                    }
                    else
                    {
                        first++;
                        end = first;
                    }

                }
                else
                {
                    if (last != A[end] && !setForIndice.Contains(A[end]))
                    {
                        count++;
                        setForIndice.Add(A[end]);
                        if (count > 1000000000)
                        {
                            return 1000000000;
                        }

                        if (setForIndice.Count == maxRange)
                        {
                            first++;
                            end = first;
                            last = A[end];
                        }
                        else
                        {
                            if (end + 1 < A.Length)
                            {
                                last = A[end];
                                end++;
                            }
                            else
                            {
                                first++;
                                end = first;
                                last = A[end];
                            }
                        }
                    }
                    else
                    {
                        first++;
                        end = first;
                    }
                }

                if (first == A.Length - 1)
                {
                    return count + 1;
                }


            }

            return count;
        }
    }
}
