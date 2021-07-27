using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class NailingPlanks
    {

        public NailingPlanks()
        {
            int[] A = { 2, 4, 6, 8 };
            int[] B = { 3, 5, 7, 9 };
            int[] C = { 2, 4, 6, 8};

            //int[] A = { 1, 4, 5, 8 };
            //int[] B = { 4, 5, 9, 10};
            //int[] C = { 4,6,7,10,2 };

            int result = solution(A, B, C);
        }

        //50%
        public int solution(int[] A, int[] B, int[] C)
        {
            if(A.Length == 0)
            {
                return -1;
            }

            if (C.Length == 0)
            {
                return -1;
            }

            int minA;
            int maxB;
            int nailC;

            int positionA = 0;
            int positionC = 0;

            int totalNails = 1;

            while(positionA < A.Length && positionC < C.Length)
            {
                minA = A[positionA];
                maxB = B[positionA];
                nailC = C[positionC];

                if(nailC >= minA && nailC <= maxB)
                {
                    positionA++;
                }
                else
                {
                    positionC++;
                    totalNails++;
                }
            }

            if (positionA == A.Length)
            {
                return totalNails;
            }
            else
            {
                return -1;
            }
        }



        //public int solution(int[] A, int[] B, int[] C)
        //{
        //    Dictionary<int, int> positions = new Dictionary<int, int>();
        //    //posiçoes de A
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        positions.Add(i, A[i]);
        //    }

        //    Array.Sort(A);

        //    int[] AuxB = new int[A.Length];
        //    int maxB = -1;
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        int posA = positions.FirstOrDefault(x => x.Value == A[i]).Key;
        //        positions.Remove(posA);
        //        AuxB[i] = B[posA];
        //        if (AuxB[i] > maxB)
        //        {
        //            maxB = AuxB[i];
        //        }
        //    }

        //    int maxC = C.Max();

        //    if (maxB > maxC)
        //    { return -1; }

        //    bool continueSearching = true;
        //    int result = 0;
        //    int pos = 0;

        //    for (int i = 0; i < C.Length && continueSearching; i++)
        //    {
        //        bool nailed = true;
        //        while (nailed && pos < A.Length)
        //        {
        //            if (A[pos] <= C[i] && C[i] <= AuxB[pos])
        //            {
        //                pos++;
        //            }
        //            else
        //            {
        //                nailed = false;
        //            }
        //        }

        //        if ( pos == A.Length )
        //        {
        //            result = i +1;
        //            continueSearching = false;
        //        }

        //        if (continueSearching && i == A.Length -1)
        //        {
        //            result = -1;
        //        }
        //    }


        //    return result;
        //}
    }
}
