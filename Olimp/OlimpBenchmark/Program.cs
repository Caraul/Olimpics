using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace OlimpBenchmark
{
	public class Program
	{
		public static void Main()
		{
			BenchmarkRunner.Run<Program>();
		}

		[Benchmark]
		public void CountLetterBenchmark()
		{
			Olimp.Program.CountLetter(101, 201, 'M');
		}
	}
}
