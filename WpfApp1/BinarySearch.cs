using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class BinarySearch
    {
        public BinarySearch()
        {
            int[] A = {};

            int n = 59;
            int position = FindPosition(A, n);
        }

        //retorna -1 se nao encontrar
        //O(logn)
        private int FindPosition(int[] a, int n)
        {
            int begin = 0;
            int end = a.Length - 1;
            int middle ;
            bool found = false;
            int pos = -1;

            while (!found && begin < end)
            {
                middle = (end + begin) / 2;

                if (a[middle] == n)
                {
                    pos = middle;
                    found = true;
                }
                else
                {
                    if (a[end] == n)
                    {
                        pos = end;
                        found = true;
                    }
                    else
                    {
                        if (a[begin] == n)
                        {
                            pos = begin;
                            found = true;
                        }
                        else
                        {
                            if (a[middle] > n)
                            {
                                end = middle-1;
                            }
                            else
                            {
                                begin = middle+1;
                            }
                        }
                    }
                    
                }
            }

            return pos;
        }
    }
}
