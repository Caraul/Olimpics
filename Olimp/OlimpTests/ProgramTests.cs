using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olimp;
using RomanNumerals;

namespace OlimpTests
{
	[TestClass]
	public class ProgramTests
	{
		[TestMethod]
		public void CountLetterTest()
		{
			// arrange
			const int from = 119;
			const int to = 120;
			const char letter = 'M';

			// act
			var result = Program.CountLetter(from, to, letter);

			// assert
			var expected = CountLetter(from, to, letter);
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void CountLetterSpecificTest()
		{
			// arrange
			(int from, int to, char letter)[] trys =
				{
					(1, 2, 'I'),
					(2, 3, 'I'),
					(3, 4, 'V'),
					(4, 5, 'X')
				};

			// act
			foreach (var @try in trys)
			{
				var result = Program.CountLetter(@try.from, @try.to, @try.letter);

				// assert
				var expected = CountLetter(@try.from, @try.to, @try.letter);
				Assert.AreEqual(expected, result, $"Expected {expected} for {@try.letter} in [{@try.from}, {@try.to}) - found {result}");
			}
		}

		[TestMethod]
		public void CountLetterRandomTest()
		{
			// arrange
			var random = new Random();
			var from = random.Next(1, 1000);
			var to = from + random.Next(1, 100);
			var letter = (new[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' })[random.Next(0, 8)];

			// act
			var result = Program.CountLetter(from, to, letter);

			// assert
			var expected = CountLetter(from, to, letter);
			Assert.AreEqual(expected, result);
		}

		private static int CountLetter(int fromIndex, int toIndex, char letter)
		{
			var result = 0;
			for (var index = fromIndex; index < toIndex; index++)
			{
				var num = ((index + index * index) / 2) % 2048;
				var romanNumber = new RomanNumeral(num).ToString();
				result += romanNumber.Count(ltr => ltr == letter);
			}

			return result;
		}
	}
}
