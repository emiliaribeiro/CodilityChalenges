using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class JumpClouds
    {

        public JumpClouds()
        {
            List<int> c = new List<int>() { 0, 0, 1, 0, 0, 1, 0 };
            int result = jumpingOnClouds(c);
        }

        public int jumpingOnClouds(List<int> c)
        {
            int jumps = 0;
            int i = 0;

            while( i < c.Count -1)
            {
                if(c.Count > i + 2 && c.ElementAt(i+2) == 0)
                {
                    jumps++;
                    i += 2;
                }
                else
                {
                    jumps++;
                    i += 1;
                }
            }

            return jumps;
        }
    }
}
