using System;
using System.Text;
using System.Collections.Generic;

namespace Hepta
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bit(-1, 9));
        }
        public static string bit(int ind1, int ind2)
        {
            var hepta = InitHepta();
            return Cycle(ind1, ind2, hepta);
        }
        public static List<int> InitHepta()
        {
            var hepta = new List<int> { 0, 0, 0, 0, 0, 0, 1 };
            for (var index = 6; hepta[index] < 63000; index++)
            {
                hepta.Add(hepta[index] + hepta[index - 1] + hepta[index - 2] + hepta[index - 3] + hepta[index - 4] + hepta[index - 5] + hepta[index - 6]);
            }
            hepta.RemoveAt(hepta.Count - 1);
            return hepta;
        }
        public static string Cycle(int ind1, int ind2, List<int> hepta)
        {
            var bit = new StringBuilder();
            int BiggerIndex, SmallerIndex;
            if (ind1 == ind2)
            {
                if (hepta.Contains(ind1))
                {
                    return "1";
                }
                return "0";
            }
            if (ind1 > ind2)
            {
                BiggerIndex = ind1;
                SmallerIndex = ind2;
            }
            else
            {
                BiggerIndex = ind2;
                SmallerIndex = ind1;
            }
            for (int index = SmallerIndex + 1; index < BiggerIndex; index++)
            {
                if (hepta.Contains(index))
                {
                    bit.Append("1");
                }
                else
                {
                    bit.Append("0");
                }
            }
            return bit.ToString();
        }
    }
}
