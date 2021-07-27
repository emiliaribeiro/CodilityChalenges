using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class StrSymmetryPoint
    {
        public StrSymmetryPoint()
        {
            string s = "x22x";
            int result = solution(s);
        }

        public int solution(String S)
        {
            int result = -1;
            List<char> chars = S.ToList();

            int count = chars.Count();
            int midle = 0;
            int inf = 0;
            int sup = 0;

            if (count == 1)
            { return 0; }

            if (count %2 == 0)
            {
                return -1;
            }
            else
            {
                 midle = (count + 1) / 2 -1;
                 inf = midle - 1;
                 sup = midle + 1;
                bool continueSearching = true;

                while (inf >= 0 && sup <= count -1 && continueSearching)
                {
                    if(chars.ElementAt(inf) == chars.ElementAt(sup))
                    {
                        inf--;
                        sup++;
                    }
                    else
                    {
                        continueSearching = false;
                    }
                }
            }
            
            if(inf == -1 && sup == count)
            {
                return midle;
            }

            return result;
        }
    }
}
