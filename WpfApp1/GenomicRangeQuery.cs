using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class GenomicRangeQuery
    {
        public GenomicRangeQuery()
        {

        }

        public int[] solution(String S, int[] P, int[] Q)
        {
            if (P.Length == 0)
            {
                int[] solEmpty = new int[1];
                solEmpty[0] = 0;

                return solEmpty;
            }

            int[] sol = new int[P.Length];
            Dictionary<string, int> pairValues  = new Dictionary<string, int>();
            Dictionary<char, int> charValue = new Dictionary<char, int>();
            charValue.Add('A', 1);
            charValue.Add('C', 2);
            charValue.Add('G', 3);
            charValue.Add('T', 4);
            List<char> querie =new List<char>();
            int firstIndex = 0;
            int lastIndex = 0;
            char min;
            string currentPair;
            for (int i=0; i < P.Length; i++)
            {
                firstIndex = P[i];
                lastIndex = Q[i];
                currentPair = firstIndex.ToString() + lastIndex.ToString();

                if (pairValues.ContainsKey(currentPair))
                {
                    sol[i] = pairValues[currentPair];
                }
                else
                {
                    if(firstIndex == lastIndex)
                    {
                        min = S.ElementAt(lastIndex);

                    }
                    else
                    {
                        querie = S.Substring(firstIndex, lastIndex- firstIndex +1).ToList(); ;
                        querie.Sort();
                        min = querie.ElementAt(0);
                    }

                    pairValues.Add(currentPair, charValue[min]);
                    sol[i] = charValue[min];
                }
            }

            return sol;
        }
    }
}
