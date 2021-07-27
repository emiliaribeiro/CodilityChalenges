using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DecomposicaoPrimos
    {
        public DecomposicaoPrimos()
        {

        }

        //Nao usar o crivo pk torna muito lento
        //em vez disso criar uma lista com o menor factor primo para cada numero ate N
        public List<int> solution(int N)
        {
            int[] spf = new int[N +1];
            spf = sieve(spf, N +1);

            List<int> result = new List<int>();

            int value = N;
            int aux;

            while(value != 1)
            {
                aux = spf[value];
                value = value / aux;
                result.Add(aux);
            }

            return result;
        }
        
        

        // Calcular o menor factor primo ate N
        private int[] sieve(int[] spf, int N)
        {
            spf[1] = 1;
            for (int i = 2; i < N; i++)
            {
                // initializar o array com cada numero
                spf[i] = i;
            }

            // em seguida marcar como o menor factor 2, para cada numero par
            for (int i = 4; i < N; i += 2)
            {
                spf[i] = 2;
            }

            //para os numeros de 3 para cima e k nao foram alterados ainda
            // se o numero for igual ao indice, entao é primo e 
            //vamos marcar todos os multiplos com esse primo pois é o menor
            for (int i = 3; i * i < N; i++)
            {
                // ver se nao esta marcado
                if (spf[i] == i)
                {
                    // marcar com o primo todos os numeros que ainda nao foram marcados
                    //e que sao multiplos deste numero
                    for (int j = i * i; j < N; j += i)
                    {
                        if (spf[j] == j)
                            spf[j] = i;
                    }

                }
            }

            return spf;
        }
    }
}
