using System;
using System.Collections.Generic;
using System.Text;

namespace Labirint
{
    public class Expr
    {
        public int ExprNum;
        public Expr(String postfix, int[] variables)
        {
            CountExprNum(postfix, variables);
        }
        public void CountExprNum(String postfix, int[] variables)
        {
            var ExprVariables = new Stack<int> { };
            for (int WasAdded = 0, index = 1; WasAdded != Int32.Parse(postfix.Split(" ")[0]); WasAdded++, index++)
            {
                if (!postfix.Split(" ")[index].Contains("-"))
                {
                    ExprVariables.Push(variables[Convert.ToInt32(postfix.Split(" ")[index])]);
                }
                else
                {
                    switch (postfix.Split(" ")[index])
                    {
                        case "-1":
                            ExprVariables.Push(ExprVariables.Pop() + ExprVariables.Pop());
                            break;
                        case "-2":
                            ExprVariables.Push(-(ExprVariables.Pop() - ExprVariables.Pop()));
                            break;
                        case "-3":
                            ExprVariables.Push(ExprVariables.Pop() * ExprVariables.Pop());
                            break;
                    }
                }
            }
            ExprNum = ExprVariables.Peek();
        }
    }
}
