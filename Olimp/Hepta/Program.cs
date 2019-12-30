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
            int index1 = ind1, index2 = ind2;
            if (index1 > index2)
            {
                index1 = ind2;
                index2 = ind1;
            }
            var bit = new StringBuilder("");
            var hepta = InitHepta();
            if (index1 != index2)
            {
                bit = Cycle(index1, index2, hepta);
                return bit.ToString();
            }
            else
            {
                bit.Append("0");
                if (hepta.Contains(index1))
                {
                    bit.Append("1");
                }
                return bit.ToString();
            }
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
        public static StringBuilder Cycle(int ind1, int ind2, List<int> hept)
        {
            int index1 = ind1, index2 = ind2;
            var hepta = hept;
            var bit = new StringBuilder("");
            for (int index = index1 + 1; index < index2; index++)
            {
                var IsOne = false;
                if (hepta.Contains(index))
                {
                    IsOne = true;
                }
                if (IsOne == false)
                {
                    bit.Append("0");
                }
                else if (IsOne == true)
                {
                    bit.Append("1");
                }
            }
            return bit;
        }
    }
}
