using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class FishQueues
    {
        public FishQueues()
        {
            int[] A = { 10,1,1,1,12,1};
            int[] B = { 1,0,0,0,1,0};

            int value = solutionB(A, B);
        }

        public int solution(int[] A, int[] B)
        {
            Queue<int> q0 = new Queue<int>();
            Queue<int> q1 = new Queue<int>();
            List<int> suverviers = new List<int>();

            Dictionary<int, int> position = new Dictionary<int, int>();

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 0)
                    q0.Enqueue(i);
                else
                {
                    q1.Enqueue(i);
                    position.Add(i, 1);
                }
            }

            int aux0 = q0.Peek();
            int aux1 = q1.Peek();

            while (q0.Count != 0 && q1.Count != 0)
            {
                //procurar o primeiro 1 no dicionario

                int pos = position.FirstOrDefault(x => x.Value == 1).Key;
                aux0 = q0.Peek();
                while (aux0 < pos)
                {
                    q0.Dequeue();
                    suverviers.Add(aux0);
                    aux0 = q0.Peek();
                }

                if (aux0 < aux1)
                {
                    aux0 = q0.Dequeue();
                    suverviers.Add(aux0);
                    aux0 = q0.Peek();
                    aux1 = q1.Peek();
                }
                else
                {
                    if (A[aux0] > A[aux1])
                    {
                        q1.Dequeue();
                        position.Remove(aux1);
                    }
                    else
                    {
                        q0.Dequeue();
                    }
                }


            }

            return q0.Count + q1.Count + suverviers.Count;
        }

        public int solutionB(int[] A, int[] B)
        {
            Queue<int> q0 = new Queue<int>();
            Queue<int> q1 = new Queue<int>();
            int suverviers = 0;
            List<int> indexList1 = new List<int>();

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 0)
                {
                    if (q1.Count == 0)
                    {
                        suverviers++;
                    }
                    else
                    {
                        q0.Enqueue(i);
                    }

                }
                else
                {
                    if (q1.Count == 0)
                    {
                        q1.Enqueue(i);
                        indexList1.Add(i);
                    }
                    else
                    {
                        int aux = q1.Peek();
                        if (i - 1 == aux)
                        {
                            q1.Dequeue();
                            q1.Enqueue(i);

                            suverviers++;
                        }
                        else
                        {
                            q1.Enqueue(i);
                        }
                        indexList1.Add(i);
                    }
                }
            }

            if (q0.Count == A.Length || q1.Count == A.Length || A.Length == 1)
            {
                return A.Length;
            }

            int index0;
            int index1;
            while (q0.Count != 0 && q1.Count != 0)
            {
                index0 = q0.Peek();
                index1 = q1.Peek();
                
                while(indexList1.Count >= index1 + 1 && indexList1.ElementAt(index1 +1) < index0 )
                {
                    q1.Dequeue();
                    if (q1.Count == 0)
                    {
                        int final = suverviers + q0.Count + 1;
                        return final;
                    }
                    suverviers++;
                    index1 = q1.Peek();
                }

                while(index0 < index1)
                {
                    q0.Dequeue();
                    if (q0.Count == 0)
                    {
                        int final = suverviers + q1.Count +1;
                        return final;
                    }
                    
                    index0 = q0.Peek();
                    suverviers++;
                }

                if(A[index0] > A[index1])
                {
                    q1.Dequeue();
                }
                else
                {
                    q0.Dequeue();
                }

            }

            int value = suverviers + q0.Count + q1.Count;

            return value;
        }
    }
}
