using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Peaks
    {

        public Peaks()
        {
            int[] A = { 0,1,0, 0, 1,0, 0 };

            solution(A);

            //A soluçao comentãda é a certae mesmo assim esta mal
        }

        //public int solution(int[] A)
        //{
        //    //posiçoes dos peaks
        //    List<int> peaks = new List<int>();

        //    for (int i=1; i< A.Length-1; i++)
        //    {
        //        if(A[i] > A[i-1] && A[i] > A[i + 1])
        //        {
        //            peaks.Add(i);
        //        }
        //    }

        //    if (A.Length < 3)
        //    {
        //        return 0;
        //    }

        //    if (peaks.Count == 0)
        //    {
        //        return 0;
        //    }
            
        //    List<int> div = Divisores(A.Length);
        //    //o bloco total tem pelo menos um peak
        //    int result = 1;
        //    div.Remove(1);
        //    div.Remove(A.Length);

        //    //numeros primos
        //    if(div.Count == 0)
        //    {
        //        return 1;
        //    }
        //    //posiçao na lista dos divisores
        //    int pos = 0;
        //    int d;
        //    int subGroup;

        //    while(result < peaks.Count && pos <= div.Count)
        //    {
        //        d = div.ElementAt(pos);


        //            subGroup = A.Length / d;

        //            bool hasPeaks = true;
        //            int count = 1;
        //            while (count <= d && hasPeaks)
        //            {
        //                hasPeaks = (peaks.Where(x => x < subGroup * count).Count() != 0);
        //                count++;
        //            }

        //            if (count - 1 == d && hasPeaks)
        //            {
        //                result = Math.Max(result, d);
        //            }


        //        pos++;
        //    }

        //    return result;

        //}

        public List<int> Divisores(int N)
        {
            List<int> result = new List<int>();

            if (N == 1)
            {
                result.Add(1);
                return result;
            }

            int i = 1;

            while (i * i < N)
            {
                if (N % i == 0)
                {
                    result.Add(i);
                    result.Add(N / i);
                }

                i = i + 1;
            }

            if (i * i == N)
            {
                result.Add(i);
            }

            return result;
        }


        public int solution(int[] A)
        {
            int length = A.Length;

            if (A.Length < 3)
            {
                return 0;
            }

            Dictionary<int, bool> positionCount = new Dictionary<int, bool>();
            //Count Peaks
            int count = 0;
            positionCount.Add(0, false);

            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                {
                    count++;
                    positionCount.Add(i, true);
                }
                else
                {
                    positionCount.Add(i, false);
                }
            }

            positionCount.Add(A.Length - 1, false);

            int numberOfPeaks = count;
            //o array total é um bloco
            int countBlocks = 1;
            int div;
            bool continueSearching = true;

            if (numberOfPeaks == 0)
            {
                return numberOfPeaks;
            }

            for (int i = 2; i <= numberOfPeaks && continueSearching; i++)
            {
                if (length % i == 0)
                {
                    div = length / i;
                    int j = 0;
                    bool hasPeak = true;
                    while (j < length && hasPeak)
                    {
                        //sub array de j a j+div-1
                        var subArray = positionCount.Where(s => s.Key >= j && s.Key < j + div)
                             .ToDictionary(dict => dict.Key, dict => dict.Value);
                        hasPeak = subArray.ContainsValue(true);
                        j = j + div;
                    }

                    if (hasPeak)
                    {
                        countBlocks = Math.Max(countBlocks, i);
                    }
                    else
                    {
                        continueSearching = false;
                    }
                }

            }

            return countBlocks;
        }
    }
}
