using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CyclicRotation
    {
        private int[] A = new int[] { 3, 8, 9, 7, 6 };
        public CyclicRotation()
        {

        }

        public int[] solution(int[] A, int K)
        {

            if (A.Length > 0)
            {
                int[] AuxList = new int[A.Length];
                //int[] ReversedList = new int[A.Length];

                for (int i = 0; i < A.Length; i++)
                {
                    AuxList[i] = A[i];
                }

                for (int j = 0; j < K; j++)
                {
                    //ReversedList = new int[A.Length];
                    AuxList = AuxReverse(AuxList);
                }
                return AuxList;
            }
            else
            {
                return A;
            }

            return A; 
        }

        private int[] AuxReverse(int[] A)
        {
            int[] Aux = new int[A.Length];
            int element = A[A.Length - 1];
            Aux[0] = element;
            for (int i = 1; i < A.Length; i++)
            {
                element = A[i - 1];
                Aux[i] = element;
            }

            return Aux;
        }
    }
}
