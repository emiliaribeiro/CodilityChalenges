using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Dominator
    {
        public Dominator()
        {
            int[] A = { 1, 1, 1, 2, 2, 2};
            int value = solutionB(A);
        }
       
        //66%
        public int solution(int[] A)
        {
             Dictionary<int, int> elementoQuantidade = new Dictionary<int, int>();

                int position = 0;

            int max = 0;

            for (int i = 0; i < A.Length; i++)
            {

                if (elementoQuantidade.ContainsKey(A[i]))
                {
                    elementoQuantidade[A[i]] ++;
                    if(max < elementoQuantidade[A[i]])
                    {
                        max = elementoQuantidade[A[i]];
                        position = i;
                    }
                }
                else
                {
                    elementoQuantidade.Add(A[i], 1);
                }
            }

            if (max >= A.Length / 2)
            {
                return position;
            }
            else
            {
                return -1;
            }
        }

        //100%
        public int solutionB(int[] A)
        {
            if (A.Length == 0)
            {
                return -1;
            }

            if (A.Length == 1)
            {
                return 0;
            }

            //retorna uma das posiçoes onde se encontra o leader ou -1 se nao existir
            List<int> list = A.ToList();
            int[] aux = new int[A.Length];
            Array.Copy(A, aux, A.Length);

            Array.Sort(aux);
            int i = 0;
            int count = 0;
            
            while(i < A.Length && aux[i] <= aux[A.Length /2] )
            {
                if (aux[i] == aux[A.Length / 2])
                {
                    count++;
                }
                i++;
            }


            if (count > A.Length / 2)
            {
                int position = list.FindIndex(x => x == aux[A.Length / 2]);
                return position;
            }
            else
            {
                return -1;
            }
        }
    }
}
