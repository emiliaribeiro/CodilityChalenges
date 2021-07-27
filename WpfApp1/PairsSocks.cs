using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PairsSocks
    {
        public PairsSocks()
        {
            List<int> ar = new List<int>() { 1, 2 };
            sockMerchant(7, ar);
        }

        public int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            foreach(int number in ar)
            {
                if (pairs.ContainsKey(number))
                {
                    pairs[number] = pairs[number] + 1;
                }
                else
                {
                    pairs.Add(number, 1);
                }
            }

            double count = 0;

            foreach(KeyValuePair<int,int> keyValuePair in pairs)
            {
                count += Math.Truncate((double)keyValuePair.Value / 2);
            }


            return (int) count;
        }
    }
}
