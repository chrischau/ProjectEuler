using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectEulerProblem021 {
	internal class Program {
		static void Main(string[] args) {

			int amicablePairCount = 0;
			int amicableSum = 0;

			for (int number = 4; number < 10000; number++) {
				int divisorSum = FindDivisorSum(number);
				int divisorSum2 = FindDivisorSum(divisorSum);

				if (divisorSum2 == number && divisorSum != number) {
					Console.WriteLine("Found an amicable pair! #{0} - {1} - {2}", number, divisorSum, divisorSum2);
					amicablePairCount++;
					amicableSum += number;
				}
			}

			Console.WriteLine("Total amicable pairs: {0}",  amicablePairCount/2);
			Console.WriteLine("Sum of amicable pairs: {0}", amicableSum);
		}

		static int FindDivisorSum(int number) {
			var divisorList = new List<int>();

			for (int divisor = 2; divisor < number; divisor++) {
				if (number % divisor == 0) {
					divisorList.Add(divisor);
					//Console.WriteLine(divisor);
				}
			}

			return divisorList.Sum() + 1;
		}
	}
}