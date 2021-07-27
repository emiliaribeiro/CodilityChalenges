using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PassingCars
    {
        public PassingCars()
        {

        }

        public int solution(int[] A)
        {
            int value = 0;
            List<int> positions1 = new List<int>();
            List<int> positions2 = new List<int>();
            List<int> ArrayA = A.ToList();
            
   

            int indice0 = ArrayA.IndexOf(0);
            int indice1 = ArrayA.LastIndexOf(1);

            if (indice0 > indice1 || indice0 < 0 || indice1 <0)
            {
                return 0;
            }
   
            List<int> list0 = new List<int>();
            List<int> list1 = new List<int>();

            for(int i= indice0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    list0.Add(i);
                }
                else
                {
                    list1.Add(i);
                }
            }

            //percorrer a lista de zeros e ver todos os elementos na lista de 1 que tem indice superior à do zero
            int count = 0;

            foreach(int indice in list0)
            {
                int pairs = this.FindPairs(indice, list1);

                if(pairs == 0)
                {
                    return count;
                }

                count += pairs;

                if(count > 1000000000)
                {
                    return -1;
                }
            }

            return count;
        }

        private int FindPairs(int indice, List<int> list1)
        {
            //int currentElement = list1.FirstOrDefault(x => x > indice);
            int currentIndice = list1.FindIndex(x => x > indice);
            int count = 0;

            if (currentIndice >= 0 && currentIndice <list1.Count())
            {
                count = list1.Count() - currentIndice;
            }

            return count;
        }
    }

}
