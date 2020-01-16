using System;
using System.Collections.Generic;

namespace Labirint
{
    public class expr
    {
        public int ExprNum;
        public expr(String postfix, List<int> variables)
        {
            var ExprVariables = new List<int>();
            for (int WasAdded = 0, index = 1; WasAdded != Int32.Parse(postfix.Split(" ")[0]); WasAdded++, index++)
            {
                if (!postfix.Split(" ")[index].Contains("-"))
                {
                    ExprVariables.Add(variables[Convert.ToInt32(postfix.Split(" ")[index])]);
                }
                else
                {
                    switch (postfix.Split(" ")[index])
                    {
                        case "-1":
                            ExprVariables.Add(ExprVariables[ExprVariables.Count - 2] + ExprVariables[ExprVariables.Count - 1]);
                            ExprVariables.RemoveAt(ExprVariables.Count - 2);
                            ExprVariables.RemoveAt(ExprVariables.Count - 2);
                            break;
                        case "-2":
                            ExprVariables.Add(ExprVariables[ExprVariables.Count - 2] - ExprVariables[ExprVariables.Count - 1]);
                            ExprVariables.RemoveAt(ExprVariables.Count - 2);
                            ExprVariables.RemoveAt(ExprVariables.Count - 2);
                            break;
                        case "-3":
                            ExprVariables.Add(ExprVariables[ExprVariables.Count - 2] * ExprVariables[ExprVariables.Count - 1]);
                            ExprVariables.RemoveAt(ExprVariables.Count - 2);
                            ExprVariables.RemoveAt(ExprVariables.Count - 2);
                            break;
                    }
                }
            }
            ExprNum = ExprVariables[0];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var variables = new List<int>();
            for (int index = Int32.Parse(Console.ReadLine()), index1 = 0; index1 != index; index1++)    //цикл  для обЪявление чисел листа т.к. пока нужно вручную выставлять
            {
                variables.Add(Int32.Parse(Console.ReadLine()));
            }
            var postfix = Console.ReadLine();
            var expr1 = new expr(postfix, variables);
            Console.WriteLine(expr1.ExprNum);
        }
    }
}
