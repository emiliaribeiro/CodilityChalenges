using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class TopMostRepeatedChar
    {
        /**
         * ditionario com char , quantidade
         * percorrer a palavra toda e adicionar quantidade
         * descobrir o valor que se repete mais vezes
        **/

        private Dictionary<char, int> quantityChar = new Dictionary<char, int>();
        private string word;
        private int count;

        public TopMostRepeatedChar()
        {
            Initialize();
            CountChars();
        }

        public List<char> MostRepeatedChar()
        {
            List<char> charMostRepeatedList = new List<char>(); ;
            List<char> charList = quantityChar.Keys.ToList();
            List<int> valuesList = quantityChar.Values.ToList();
            int max =valuesList.Max();
            int position;
            int auxMax = max;

            while (max == auxMax)
            {
                position = valuesList.FindIndex(x => x == max);
                charMostRepeatedList.Add(charList.ElementAt(position));
                charList.RemoveAt(position);
                valuesList.RemoveAt(position);
                auxMax = valuesList.Max();
            }

            return charMostRepeatedList;
        }

        private void CountChars()
        {
         
            foreach(char car in this.word)
            {
               if(!quantityChar.ContainsKey(car))
               {
                    quantityChar.Add(car, 1);
               }
               else
               {
                    quantityChar[car] = quantityChar[car] + 1;
               }
            }
        }

        private void Initialize()
        {
            //word = "hjvsadcbjlefnejmwfopjowFWENFJBUJFCBHWBFCUJBNJKZSNDN<JKABWEKJBMLKWWsssss";
            word = "hello wworld";
        }

    }
}
