using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Distinct
    {
        public Distinct()
        {

        }

        public int solution(int[] A)
        {
            int distintNumbers = 0;

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach(int number in A)
            {
                if(!keyValuePairs.ContainsKey(number))
                {
                    keyValuePairs[number] = 1;
                }
            }

            return keyValuePairs.Count();
        }
    }
}
