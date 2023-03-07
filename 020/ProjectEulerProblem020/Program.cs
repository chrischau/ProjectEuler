using System.Numerics;

namespace ProjectEulerProblem020 {
	internal class Program {
		static void Main(string[] args) {
			int sum = 0;
			BigInteger factorialSum = 1;
			
			for (int i = 2; i <= 99; i++) {
				factorialSum *= i;
			}

			Console.WriteLine("100 Factorial Sum: {0}", factorialSum);

			foreach (var singleDigit in factorialSum.ToString().ToCharArray()) {
				int tempNumber = Convert.ToInt32(singleDigit.ToString());
				sum += tempNumber;
				//Console.WriteLine("{0} - {1}", tempNumber, sum);
			}
			
			Console.WriteLine("Sum of 100 Factorial: {0}", sum); //648
		}
	}
}