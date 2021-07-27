using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class OddOccurrencesInArray
    {
        private Dictionary<int, int> numberFrequency = new Dictionary<int, int>();
        public OddOccurrencesInArray()
        {

        }

        public int solution(int[] A)
        {
            int oddNumber = 0;
            foreach(int number in A)
            {
                if (numberFrequency.ContainsKey(number))
                {
                    numberFrequency[number] += 1;
                }
                else
                {
                    numberFrequency.Add(number, 1);
                }
            }

            oddNumber = this.FindOddNumber();

            return oddNumber;
        }

        private int FindOddNumber()
        {
            int myKey = numberFrequency.FirstOrDefault(x => x.Value %2 != 0).Key;

            return myKey;
        }
    }
}
