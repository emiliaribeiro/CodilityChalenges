using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Triplet
    {

        public Triplet()
        {

        }

        public int sum(int[] numbers)
        {
            Dictionary<int, int> keyValuePairs;
            int sum;

            sum = numbers.Min();

            for (int i = 0; i < numbers.Count() - 2; i++)
            {
                keyValuePairs = new Dictionary<int, int>();

                for (int j = i + 1; j < numbers.Count(); j++)
                {
                    if (!keyValuePairs.ContainsKey(numbers[j]))
                    {
                        keyValuePairs.Add(numbers[j], 1);
                    }
                    else
                    {
                        keyValuePairs[numbers[j]]++;
                    }

                }

                int max1 = keyValuePairs.Keys.Max();
                int max2;
                //Nao tem repetidos
                if (keyValuePairs[max1] > 1)
                {
                    max2 = max1;
                }
                else
                {
                    keyValuePairs.Remove(max1);
                    max2 = keyValuePairs.Keys.Max();
                }

                if (sum < numbers[i] + max1 + max2)
                {
                    sum = numbers[i] + max1 + max2;
                }
            }

            return sum;
        }

        public int Product(int[] numbers)
        {
            // /posiçao / numero
            Dictionary<int, int> keyValuePairsPos = new Dictionary<int, int>();
            Dictionary<int, int> keyValuePairsNeg = new Dictionary<int, int>();
            Dictionary<int, int> keyValuePairsPosAux = new Dictionary<int, int>();
            Dictionary<int, int> keyValuePairsNegAux = new Dictionary<int, int>();

            if (numbers.Length == 3)
            {
                return numbers[0] * numbers[1] * numbers[2];
            }

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] < 0)
                {
                    keyValuePairsNeg.Add(i, numbers[i]);
                    keyValuePairsNegAux.Add(i, numbers[i]);
                }
                else
                {
                    keyValuePairsPos.Add(i, numbers[i]);
                    keyValuePairsPosAux.Add(i, numbers[i]);
                }
            }

            int prod;

            if (keyValuePairsNeg.Count > 0)
            {
                prod = keyValuePairsNeg.Values.Min();
            }
            else
            {
                prod = keyValuePairsPos.Values.Min();
            }

            int auxProd = prod;

            for (int i = 0; i < numbers.Count() - 2; i++)
            {
                int myKey;
                int max1;
                int max2;
                int max3;
                int max4;
                int max1pos;
                int max3pos;
                auxProd = prod;
                int auxProd1;
                int auxProd2;

                if (numbers[i] >= 0)
                {
                    //remover o elemento currente
                    keyValuePairsPos.Remove(i);
                    keyValuePairsPosAux.Remove(i);
                    //procurar 2 maximos positivos
                    if (keyValuePairsPos.Count >= 2)
                    {
                        max1 = keyValuePairsPos.Values.Max();
                        max1pos = keyValuePairsPos.FirstOrDefault(x => x.Value == max1).Key;
                        keyValuePairsPosAux.Remove(max1pos);
                        max2 = keyValuePairsPosAux.Values.Max();
                        keyValuePairsPosAux.Add(max1pos, max1);
                        auxProd1 = max1 * max2 * numbers[i];
                    }
                    else
                    {
                        auxProd1 = numbers[i];
                    }


                    //procurar 2 maximos negativos
                    if (keyValuePairsNeg.Count >= 2)
                    {
                        max3 = keyValuePairsNeg.Values.Max();
                        max3pos = keyValuePairsNeg.FirstOrDefault(x => x.Value == max3).Key;

                        keyValuePairsNegAux.Remove(max3pos);
                        max4 = keyValuePairsNegAux.Values.Max();
                        keyValuePairsNegAux.Add(max3pos, max3);
                        auxProd2 = max3 * max4 * numbers[i];
                    }
                    else
                    {
                        auxProd2 = numbers[i];
                    }


                    auxProd = Math.Max(auxProd1, auxProd2);


                }
                else//
                {
                    //remover o elemento currente
                    keyValuePairsNeg.Remove(i);
                    keyValuePairsNegAux.Remove(i);
                    if (keyValuePairsNeg.Count > 0 && keyValuePairsPos.Count > 0)
                    {
                        max1 = keyValuePairsPos.Values.Max();
                        max2 = keyValuePairsNeg.Values.Min();
                        auxProd = max1 * max2 * numbers[i];
                    }
                    else
                    {
                        if (keyValuePairsNeg.Count >= 2)
                        {
                            max3 = keyValuePairsNeg.Values.Max();
                            max3pos = keyValuePairsNeg.FirstOrDefault(x => x.Value == max3).Key;

                            keyValuePairsNegAux.Remove(max3pos);
                            max4 = keyValuePairsNegAux.Values.Max();
                            keyValuePairsNegAux.Add(max3pos, max3);
                            auxProd = max3 * max4 * numbers[i];
                        }
                    }

                    if (i == 0)
                    {
                        prod = auxProd;
                    }
                }


                if (prod < auxProd)
                {
                    prod = auxProd;
                }

            }

            return prod;
        }

        public int Product2(int[] A)
        {
            int count = A.Length -1;
            Array.Sort(A);
            int firstElements;
            int lastElements = A[count] * A[count - 1] * A[count - 2];

            if (A[0] < 0 && A[1] < 0)
            {
                firstElements = A[0] * A[1] * A[count];

                if (firstElements > lastElements)
                {
                    lastElements = firstElements;
                }

            }

            return lastElements;
        }
    }
}
