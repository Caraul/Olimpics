﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Labirint
{
    public class Expr
    {
        int[] PostfixVariables;
        public Expr(int[] postfixVariables)
        {
            PostfixVariables = postfixVariables;
        }
        public int CountExprNum(int[] variables)
        {
            var ExprVariables = new Stack<int>();
            foreach (var Variable in PostfixVariables)
            {
                if (Variable >= 0)
                {
                    ExprVariables.Push(variables[Variable]);
                }
                else
                {
                    switch (Variable)
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
