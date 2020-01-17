using System;
using System.Collections.Generic;
using System.Text;

namespace Labirint
{
    public class Expr
    {
        public int[] PostfixVariables;
        public Expr(String postfix)
        {
            PostfixVariables = new int[postfix.Split(" ").Length];
            for (int index = 0; index != postfix.Split(" ").Length; index++)
            {
                PostfixVariables[index] = Int32.Parse(postfix.Split(" ")[index]);
            }
        }
        public int CountExprNum(int[] variables)
        {
            var ExprVariables = new Stack<int>();
            for (int WasAdded = 0, index = 1; WasAdded != PostfixVariables[0]; WasAdded++, index++)
            {
                if (PostfixVariables[index] >= 0)
                {
                    ExprVariables.Push(variables[PostfixVariables[index]]);
                }
                else
                {
                    switch (PostfixVariables[index])
                    {
                        case -1:
                            ExprVariables.Push(ExprVariables.Pop() + ExprVariables.Pop());
                            break;
                        case -2:
                            ExprVariables.Push(-(ExprVariables.Pop() - ExprVariables.Pop()));
                            break;
                        case -3:
                            ExprVariables.Push(ExprVariables.Pop() * ExprVariables.Pop());
                            break;
                    }
                }
            }
            return ExprVariables.Peek();
        }
    }
}
