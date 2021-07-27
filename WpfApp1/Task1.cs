using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Task1
    {
        public Task1()
        {

            int[] A = { 1, 2, 4, 4, 3 };
            int[] B = { 2, 3, 1, 3, 1 };
            int N;
            //string RESULT = solution( S); 
        }


        //public string solution (int[] A,
        //int[] B )
        //{
        //    int begin = 0;
        //    int end = 0;
        //    List<int> Alist = A.ToList();
        //    List<int> Blist = B.ToList();
        //    for (int i =1; i <= N, i++)
        //}

        //public string solution(string[] A, string[] B, string P)
        //{
        //    string result = "NO CONTACT";
        //    //A names
        //    //B numbers

        //    if (A.Length == 0 || P.Length >9)
        //    {
        //        return result;
        //    }

        //    List<string> aux = new List<string>();
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (B[i].Contains(P))
        //        {
        //            aux.Add(A[i]);
        //        }
        //    }

        //    if (aux.Count ==0)
        //    {
        //        return result;
        //    }
        //    else
        //    {
        //        if (aux.Count == 1)
        //        {
        //            return aux.ElementAt(0);
        //        }
        //        else
        //        {
        //            List<string> resulOrdered = aux.OrderBy(q => q).ToList();
        //            return resulOrdered.ElementAt(0);
        //        }
        //    }



        //    return result;
        //}
//        string result = string.Empty;
//        string aux = string.Empty;
//        string auxLast = string.Empty;
//        int count = 0;
      
     

//            foreach (char c in S)
//            {
//                if (c != ' ' && c != '-')
//                {
//                    if(aux.Length == 3)
//                    {
//                        if(result.Length == 0)
//                        {
//                            auxLast = aux;
//                            result += aux;
//                            aux = c.ToString(); 
//                        }
//                        else
//                        {
//                            result += "-" + aux;
//                            auxLast = aux;
//                            aux = c.ToString();
//                        }
                        
//                    }
//                    else
//{
//    aux += c.ToString();
//    count++;
//}
//                }
//            }

//            if ((aux.Length == 3 || aux.Length == 2) && auxLast.Length == 3)
//{
//    result += "-" + aux;
//}
//else
//            if (aux.Length == 1 && auxLast.Length == 3)
//{
//    string auxString = result.Substring(0, result.Length - auxLast.Length);

//    auxString += auxLast.Substring(0, 2) + "-" + auxLast.Last() + aux;

//    result = auxString;
//}
//else
//{
//    if (aux.Length == 2 && result == string.Empty)
//    {
//        result += aux;
//    }
//    else
//    if (aux.Length == 2)
//    {
//        result += "-" + aux;
//    }
//}



//return result;
    }
}
