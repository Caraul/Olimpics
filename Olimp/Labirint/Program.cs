using System;
using System.Collections.Generic;

namespace Labirint
{

    class Program
    {
        static void Main(string[] args)
        {
            var variables =new int[Int32.Parse(Console.ReadLine())];
            for (int index = variables.Length, index1 = 0; index1 != index; index1++)    //цикл  для обЪявление чисел массива т.к. пока нужно вручную выставлять
            {
                variables[index1] = Int32.Parse(Console.ReadLine());
            }
            var postfix = Console.ReadLine();
            var expr1 = new Expr(postfix);
            Console.WriteLine(expr1.CountExprNum(variables));
        }
    }
}
