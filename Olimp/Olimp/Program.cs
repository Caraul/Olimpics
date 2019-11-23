using System;

namespace Olimp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, v = 0, x = 0, l = 0, c = 0, d = 0, m = 0, num;
            Console.WriteLine("Какую римскую цифру?(I, V, X, L, C, D, M)");
            string n = Console.ReadLine();
            for (int f = 101; f < 201; f++)
            {
                num = ((f + f * f) / 2) % 2048;
                while (num != 0)
                {
                    if (num >= 1000)
                    {
                        num -= 1000;
                        m++;
                    }
                    else if (num >= 500)
                    {
                        num -= 500;
                        d++;
                    }
                    else if (num >= 400)
                    {
                        num -= 400;
                        c++;
                        d++;
                    }
                    else if (num >= 100)
                    {
                        num -= 100;
                        c++;
                    }
                    else if (num >= 90)
                    {
                        num -= 90;
                        x++;
                        c++;
                    }
                    else if (num >= 50)
                    {
                        num -= 50;
                        l++;
                    }
                    else if (num >= 40)
                    {
                        num -= 40;
                        x++;
                        l++;
                    }
                    else if (num >= 10)
                    {
                        num -= 10;
                        x++;
                    }
                    else if (num == 9)
                    {
                        num -= 9;
                        x++;
                        i++;
                    }
                    else if (num >= 5)
                    {
                        num -= 5;
                        v++;
                    }
                    else if (num == 4)
                    {
                        num -= 4;
                        i++;
                        v++;
                    }
                    else if (num >= 1)
                    {
                        num -= 1;
                        i++;
                    }
                }
            }
            if (n == "I")
            {
                Console.WriteLine(i);
            }
            else if (n == "V")
            {
                Console.WriteLine(v);
            }
            else if (n == "X")
            {
                Console.WriteLine(x);
            }
            else if (n == "L")
            {
                Console.WriteLine(l);
            }
            else if (n == "C")
            {
                Console.WriteLine(c);
            }
            else if (n == "D")
            {
                Console.WriteLine(d);
            }
            else if (n == "M")
            {
                Console.WriteLine(m);
            }
        }
    }
}
