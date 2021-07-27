using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class AbsDistinct
    {
        public AbsDistinct()
        {

        }

        //Todos os valores com valor absoluto diferente
        public int solution(int[] A)
        {
            bool continueSearching = true;
            int begin = 0;
            int end = A.Length-1;
            int aux1;
            int aux2;
            int total;
            //value/ quantity
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            if (begin == end)
            {
                return 1;
            }
            else
            {
                while (continueSearching)
                {
                    if (A[begin] == System.Int32.MinValue)
                    {
                        aux1 = System.Int32.MaxValue;
                    }
                    else
                    {
                        aux1 = Math.Abs(A[begin]);
                    }
                    
                    if(keyValuePairs.ContainsKey(aux1))
                    {
                        keyValuePairs[aux1]++;
                    }
                    else
                    {
                        keyValuePairs.Add(aux1, 1);
                    }

                    if (A[end] == System.Int32.MinValue)
                    {
                        aux2 = System.Int32.MaxValue;
                    }
                    else
                    {
                        aux2 = Math.Abs(A[end]);
                    }

                    if (keyValuePairs.ContainsKey(aux2))
                    {
                        keyValuePairs[aux2]++;
                    }
                    else
                    {
                        keyValuePairs.Add(aux2, 1);
                    }

                    begin++;
                    end--;

                    if(begin > end)
                    {
                        continueSearching = false;
                    }
                    else
                    {
                        if (begin == end)
                        {
                            aux2 = Math.Abs(A[end]);
                            if (keyValuePairs.ContainsKey(aux2))
                            {
                                keyValuePairs[aux2]++;
                            }
                            else
                            {
                                keyValuePairs.Add(aux2, 1);
                            }

                            continueSearching = false;
                        }
                    }
                }
            }

            total = keyValuePairs.Keys.Count();
            return total;
        }
    }
}
