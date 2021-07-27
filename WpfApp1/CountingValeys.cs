using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CountingValeys
    {
        public CountingValeys()
        {
            string path = "UDDDUDUU";
            int steps = 7;
            int result = countingValleys(steps, path);
        }
        public int countingValleys(int steps, string path)
        {
            int count = 0;
            bool firstTime = true;
            int valeys = 0;

            foreach(char c in path)
            {
                if (c == 'D')
                {
                    count--;
                }
                if (c == 'U')
                {
                    count++;
                }

                if (count == 0 && c == 'U' && !firstTime)
                {
                    valeys++;
                }

                if (firstTime)
                {
                    firstTime = false;
                }
            }

            return valeys;

        }
    }
}
