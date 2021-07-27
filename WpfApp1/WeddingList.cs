using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class WeddingList
    {
        private List<string> carlosList = new List<string>();
        private List<string> linaList = new List<string>();
        private List<string> carlosListAux = new List<string>();
        private List<string> linaListAux = new List<string>();
        private Dictionary<string, int> carlosDicAux = new Dictionary<string, int>();
        private Dictionary<string, int> linaDicAux = new Dictionary<string, int>();
        public WeddingList()
        {
            this.Initialize();
            this.RemoveEmptySpacesAndConvertLowerCase();
        }

        public bool AreListsEquals()
        {
            bool same = true;

            if (carlosListAux.Count != linaListAux.Count || (carlosListAux.Count == 0 && linaListAux.Count == 0))
            {
                return false;
            }
            else
            {
                //for (int i=0; i< carlosListAux.Count; i++ )
                //{
                //    if(!carlosListAux.Contains(linaListAux.ElementAt(i)))
                //    {
                //        same = false;
                //        return same;
                //    }
                //}
                return !carlosDicAux.ContainsValue(1);
            }

            //return same;
        }

        private void RemoveEmptySpacesAndConvertLowerCase()
        {
            foreach(string person in carlosList)
            {
                string aux = person.ToLower().Replace(" ", string.Empty);

                if(!carlosDicAux.ContainsKey(aux))
                {
                    carlosDicAux.Add(aux, 1);
                }

                if (!carlosListAux.Contains(aux))
                {
                    carlosListAux.Add(aux);
                }
            }

            foreach (string person in linaList)
            {
                string aux = person.ToLower().Replace(" ", string.Empty);

                if (!linaListAux.Contains(aux))
                {
                    linaListAux.Add(aux);
                }

                if (!carlosDicAux.ContainsKey(aux))
                {
                    carlosDicAux.Add(aux, 1);
                }
                else
                {
                    carlosDicAux[aux] = 2;
                }
            }

            carlosDicAux.Add("testc", 3);
        }

        private void Initialize()
        {
            carlosList.Add("Lisa Germano");
            carlosList.Add("bell Germano");
            carlosList.Add("dhd Germano");
            carlosList.Add("Lisdfhbza Germano");
            carlosList.Add("dbhdfzzf Germano");
            carlosList.Add("szedf Germano");
            carlosList.Add("Libjlsa Germano");
            carlosList.Add("Li<estgsa Germano");
            carlosList.Add("dtjhu Germano");
            carlosList.Add("dfgj Germano");
            carlosList.Add("dfhj Germano");
            carlosList.Add("dht Germano");


            //linaList.Add("Lisa Germano");
            //linaList.Add("bell Germano");
            //linaList.Add("dhd Germano");
            //linaList.Add("Lisdfhbza Germano");
            //linaList.Add("dbhdfzzf Germano");

            //linaList.Add("Libjlsa Germano");
            //linaList.Add("Li<estgsa Germano");
            //linaList.Add("dtjhu Germano");
            //linaList.Add("dfgj Germano");
            //linaList.Add("dfhj Germano");
            //linaList.Add("dht Germano");
            //linaList.Add("dfgj Germano");
            //linaList.Add("dfhj Germano");
            //linaList.Add("dht Germano");

            linaList.Add("Lisa Germano");
            linaList.Add("bell Germano");
            linaList.Add("bell Germano");
            linaList.Add("dhd Germano");
            linaList.Add("Lisdfhbza Germano");
            linaList.Add("dbhdfzzf Germano");
            linaList.Add("szedf Germano");
            linaList.Add("Libjlsa Germano");
            linaList.Add("Li<estgsa Germano");
            linaList.Add("dtjhu Germano");
            linaList.Add("dfgj Germano");
            linaList.Add("dfhj Germano");
            linaList.Add("dht Germano");
        }
    }
}
