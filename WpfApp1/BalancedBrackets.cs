using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    
    class BalancedBrackets
    {
        private string operation;
        private List<char> initialBrackets = new List<char>();
        private List<char> finalBrackets = new List<char>();
        private List<char> initialBracketsTotal = new List<char>();
        private List<char> finalBracketsTotal = new List<char>();
        private Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
        //initial / final
        public BalancedBrackets()
        {
            //initialBrackets.Add('(');
            //initialBrackets.Add('{');
            //initialBrackets.Add('[');
            //finalBrackets.Add(')');
            //finalBrackets.Add('}');
            //finalBrackets.Add(']');
 

            operation = "";
            int value = solution(operation);

            //operation = "{2345(6)(7)]}";
            //int value = solutionB(operation);
        }

        //public bool IsBalanced()
        //{
        //    bool balanced = true;

        //    finalBracketsTotal.Reverse();

        //    if (initialBracketsTotal.Count != finalBracketsTotal.Count)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        char initialChar;
        //        char finalChar;

        //        for (int i= 0; i < initialBracketsTotal.Count && balanced; i++)
        //        {
        //            initialChar = initialBracketsTotal.ElementAt(i);
        //            finalChar = finalBracketsTotal.ElementAt(i);

        //            if (keyValuePairs[initialChar] != finalChar)
        //            {
        //                balanced = false;
        //            }
        //        }
        //    }

        //    return balanced;
        //}
        //private void CountBrackets()
        //{
        //    foreach(char car in operation)
        //    {
        //        if(initialBrackets.Contains(car))
        //        {
        //            initialBracketsTotal.Add(car);
        //        }
        //        else
        //        {
        //            if (finalBrackets.Contains(car))
        //            {
        //                finalBracketsTotal.Add(car);
        //            }
        //        }
        //    }
        //}

        // Esta soluçao finciona para strings so com~parentesis
        public int solution(String S)
        {
            keyValuePairs.Add(')', '(');
            keyValuePairs.Add('}', '{');
            keyValuePairs.Add(']', '[');
            Stack<char> stack = new Stack<char>();
            char aux;
            //dicionario
            //final/inicial
            foreach (char c in S)
            {
                if (keyValuePairs.Values.Contains(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    if (keyValuePairs.Keys.Contains(c))
                    {
                        aux = stack.Pop();

                        if (keyValuePairs[c] != aux)
                        {
                            return 0;
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // Esta soluçao finciona para strings  com~parentesis e outros chars
        public int solutionB(String S)
        {
            keyValuePairs.Add(')', '(');
            keyValuePairs.Add('}', '{');
            keyValuePairs.Add(']', '[');
            Stack<char> stack = new Stack<char>();
            char aux;
            //dicionario
            //final/inicial
            foreach (char c in S)
            {
                if (keyValuePairs.Values.Contains(c) || keyValuePairs.Keys.Contains(c))
                {
                    if (keyValuePairs.Values.Contains(c))
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            return 0;
                        }

                        if (keyValuePairs.Keys.Contains(c))
                        {
                            aux = stack.Pop();

                            if (keyValuePairs[c] != aux)
                            {
                                return 0;
                            }
                        }
                    }
                }
            }

            return 1;
        }

        // Esta soluçao é so para ()))((())) 
        public int Nesting(String S)
        {
            keyValuePairs.Add(')', '(');

            Stack<char> stack = new Stack<char>();
            char aux;
            //dicionario
            //final/inicial
            foreach (char c in S)
            {
                if (keyValuePairs.Values.Contains(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    if (keyValuePairs.Keys.Contains(c))
                    {
                        aux = stack.Pop();

                        if (keyValuePairs[c] != aux)
                        {
                            return 0;
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
