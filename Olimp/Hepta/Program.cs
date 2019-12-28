using System;
using System.Collections.Generic;

namespace Hepta
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bit(3, 3));
        }
        public static string bit(int ind1, int ind2)
        {
            int index1 = ind1, index2 = ind2;
            if (index1 > index2)
            {
                index1 = ind2;
                index2 = ind1;
            }
            string bit = "";
            bool IsOne;
            List<int> hepta = InitHepta();
            if (index1 != index2)
            {
                for (int index = index1 + 1; index < index2; index++)
                {
                    IsOne = false;
                    foreach (int num in hepta)
                    {
                        if (num == index)
                        {
                            IsOne = true;
                            break;
                        }
                    }
                    if (IsOne == false)
                    {
                        bit = bit + "0";
                    }
                    else if (IsOne == true)
                    {
                        bit = bit + "1";
                    }
                }
                return bit;
            }
            else
            {
                foreach (int num in hepta)
                {
                    bit = "0";
                    if (num == index1)
                    {
                        bit = "1";
                        break;
                    }
                }
                return bit;
            }
        }
        public static List<int> InitHepta()
        {
            List<int> hepta = new List<int> { 0, 0, 0, 0, 0, 0, 1 };
            var index = 6;
            while (hepta[index] < 6300)
            {
                index++;
                hepta.Add(hepta[index - 1] + hepta[index - 2] + hepta[index - 3] + hepta[index - 4] + hepta[index - 5] + hepta[index - 6] + hepta[index - 7]);
            }
            hepta.RemoveAt(hepta.Count - 1);
            return hepta;
        }
    }
}
