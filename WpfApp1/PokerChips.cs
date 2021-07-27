using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PokerChips
    {
        private List<int> auxList = new List<int>();
        private int totalCache; 
        private int subTotal;

        public PokerChips()
        {
            this.Initialize();
           
        }

        public Dictionary<int, int> GetValues()
        {
            Dictionary<int, int> chipValues = new Dictionary<int, int>();
            int quantity = 0;

            foreach (int kvp in auxList)
            {
                quantity = GetHighterValue(kvp);
                chipValues.Add(kvp, quantity);
            }

            return chipValues;
        }

        private int GetHighterValue(int keyValue)
        {
            int key = this.subTotal / keyValue;
            this.subTotal = this.subTotal - keyValue * key;
            return key;
        }

        private void Initialize()
        {
            this.auxList.Add(100);
            this.auxList.Add(50);
            this.auxList.Add(25);
            this.auxList.Add(10);
            this.auxList.Add(5);
            this.auxList.Add(1);
            this.totalCache = 126;
            this.subTotal = totalCache;
        }


    }
}
