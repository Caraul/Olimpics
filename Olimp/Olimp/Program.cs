using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("OlimpTests")]
[assembly: InternalsVisibleTo("OlimpBenchmark")]

namespace Olimp
{
	internal static class Program
	{
		internal static void Main()
		{
			var result = CountLetter(101, 200, 'M');
			Console.WriteLine('M');
			Console.WriteLine(result);
		}

		internal static int CountLetter(int fromIndex, int toIndex, char letter)
		{
			int i = 0, v = 0, x = 0, l = 0, c = 0, d = 0, m = 0;

			for (var index = fromIndex; index < toIndex; index++)
			{
				var num = ((index + index * index) / 2) % 2048;
				while (num != 0)
				{
					if (num >= 1000)
					{
						num -= 1000;
						m++;
					}
					else if (num >= 900)
					{
						num -= 900;
						c++;
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

			switch (letter)
			{
				case 'I':
					return i;
				case 'V':
					return v;
				case 'X':
					return x;
				case 'L':
					return l;
				case 'C':
					return c;
				case 'D':
					return d;
				case 'M':
					return m;
				default:
					throw new Exception();
			}
		}
	}
}
