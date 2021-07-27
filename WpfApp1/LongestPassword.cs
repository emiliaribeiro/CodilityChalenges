using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class LongestPassword
    {
        public LongestPassword()
        {
            string pass = "test 5 a0A pass007 test/5?a0A&passss007/test ?xy1 ?xy1";
            int result = solution(pass);

        }

        public int solution(String S)
        {
            int numberLetters = 0;
            int numberDigits = 0;
            int max = 0;
            bool isAlpha = true;


            foreach (char c in S)
            {
                if (c == ' ')
                {
                    if (isAlpha && numberLetters %2 == 0 && numberDigits %2 != 0)
                    {
                        max = Math.Max(max, numberLetters + numberDigits);
                    }
                    numberLetters = 0;
                    numberDigits = 0;
                    isAlpha = true;
                }
                else
                {
                    if(!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
                    {
                        isAlpha = false;
                        numberLetters = 0;
                        numberDigits = 0;
                    }
                    else
                    {
                        if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                        {
                            numberLetters++;
                        }

                        if ((c >= '0' && c <= '9'))
                        {
                            numberDigits++;
                        }
                    }

                }
            }

            if (max == 0 && (isAlpha && numberLetters % 2 == 0 && numberDigits % 2 != 0))
            {
               return numberLetters + numberDigits;
            }

            if (max == 0)
            {
                return -1;
            }

            return max;
        }
    }
}
