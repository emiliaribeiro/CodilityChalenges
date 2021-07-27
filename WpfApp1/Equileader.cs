using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Equileader
    {
        Stack<int> positions = new Stack<int>();
        public Equileader()
        {
            //sao as posiçoes que dividem em dois arrays em que o leader é leader
            int[] A = { 4, 4, 2, 5, 3, 4, 4, 4 };
            int leader = Leader(A);
            int leaderTotal = 0;
            for (int i= A.Length -1; i>=0; i--)
            {
                if (A[i] == leader)
                {
                    positions.Push(i);
                    leaderTotal++;
                }
            }

            int aux;
            int count = 0;
            int result = 0;
            int last = 0;
            while(positions.Count != 0)
            {
                aux = positions.Pop();
                if (aux - last > 1)
                {
                    for (int i = last + 1; i < 2 * count -1 && i < aux; i++ )
                    {
                        if (count > (i + 1) / 2 && (leaderTotal - count > (A.Length - (i + 1)) / 2))
                        {
                            result++;
                        }
                    }
                }
                
                count++;
                int val1 = leaderTotal - count;
                int val2 = (A.Length - (aux + 2));
                int val3 = val2 / 2;

                if (count > (aux+1) /2 && (leaderTotal - count > (A.Length - (aux +1))/2))
                {
                    result++;
                }

                last = aux;

            }

        }

        public int Leader(int[] A)
        {
            if (A.Length == 1)
            {
                return 0;
            }

            List<int> list = A.ToList();
            int[] aux = new int[A.Length];
            Array.Copy(A, aux, A.Length);

            Array.Sort(aux);
            int i = 0;
            int count = 0;

            while (i < A.Length && aux[i] <= aux[A.Length / 2])
            {
                if (aux[i] == aux[A.Length / 2])
                {
                    count++;
                }
                i++;
            }


            if (count > A.Length / 2)
            {
                return aux[A.Length / 2];
            }
            else
            {
                return -1;
            }
        }
    }




        //public int solution(int[] A)
        //{
        //    Dictionary<int, int> elementoQuantidade = new Dictionary<int, int>();
        //    Dictionary<int, int> indiceElemento = new Dictionary<int, int>();
        //    int position = 0;
        //    int equileader = 0;
        //    int max = 0;

        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        indiceElemento.Add(i, A[i]);
        //        if (elementoQuantidade.ContainsKey(A[i]))
        //        {
        //            elementoQuantidade[A[i]]++;
        //            if (max < elementoQuantidade[A[i]])
        //            {
        //                max = elementoQuantidade[A[i]];
        //                position = i;
        //            }
        //        }
        //        else
        //        {
        //            elementoQuantidade.Add(A[i], 1);
        //        }
        //    }

        //    if (A[0] == A[position])
        //    {
        //        equileader++;
        //    }


            
        //    //if (A[A.Length -1] == max)
        //    //{
        //    //    equileader++;
        //    //}

        //    for (int i=1; i< A.Length; i++)
        //    {
        //        if (IsEquiLeader(i, A, A[position]))
        //        {
        //            equileader++;
        //        }
        //    }

        //    return equileader;
        //}

        //private bool IsEquiLeader(int i, int[] A, int leader)
        //{
        //    int[] subList = new int[i];
        //    Array.Copy(A, 0, subList, 0, i);

        //    int max = FindEquileader(subList);

        //    if(max == leader)
        //    {
        //        int[] supList = new int[A.Length - i];
        //        Array.Copy(A, i, supList, 0, A.Length - i);
        //        max = FindEquileader(supList);

        //        if(max == leader)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private int FindEquileader(int[] A)
        //{
        //    Dictionary<int, int> elementoQuantidade = new Dictionary<int, int>();

        //    int position = 0;

        //    int max = 0;

        //    for (int i = 0; i < A.Length; i++)
        //    {

        //        if (elementoQuantidade.ContainsKey(A[i]))
        //        {
        //            elementoQuantidade[A[i]]++;
        //            if (max < elementoQuantidade[A[i]])
        //            {
        //                max = elementoQuantidade[A[i]];
        //                position = i;
        //            }
        //        }
        //        else
        //        {
        //            elementoQuantidade.Add(A[i], 1);
        //        }
        //    }

        //    if (max > A.Length / 2)
        //    {
        //        return A[position];
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}
}

