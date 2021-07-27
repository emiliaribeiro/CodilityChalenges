using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class BinaryGap
    {
        private string binary;

        public BinaryGap()
        {
            this.Initialize();
            
        }

        private void Initialize()
        {
            //List<int> range = new List<int> { 1, 2, 147, 483, 647 };

            //int random_number = new Random().Next(0, 4);
            //int number = range.ElementAt(random_number);
            //this.binary = Convert.ToString(1041, 2);
            int N = 123;
            solution(N);
        }

        public int solution(int N)
        {
            this.binary = Convert.ToString(N, 2);
            int i = 0;
            int finalPosition;
            int auxMax = 0;
            int max = 0;
            while (i < this.binary.Length)
            {
                char car = this.binary.ElementAt(i);

                if (car.Equals('1') && i+1 < this.binary.Length && this.binary.ElementAt(i+1).Equals('0'))
                {
                    auxMax = StartCounting(i+1, out finalPosition);
                    i = finalPosition;

                    if (auxMax > max)
                    {
                        max = auxMax;
                    }
                }
                else
                {
                    i++;
                }
            }

            return max;
        }

        private int StartCounting(int position, out int finalPosition)
        {
            bool ended = false;
            int count = 0;
            finalPosition = position;

            for (int i= position; i< this.binary.Length && !ended; i++)
            {
                if (this.binary.ElementAt(i).Equals('0'))
                    count++;
                else
                {
                    ended = true;
                    if (!this.binary.ElementAt(i).Equals('1'))
                    {
                        count = 0;
                    }
                }

                finalPosition = i;
            }
            
            if(this.binary.ElementAt(finalPosition).Equals('0'))
            {
                return 0;
            }
            else
            return count;
        }
    }
}
