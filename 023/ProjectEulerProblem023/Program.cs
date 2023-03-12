namespace ProjectEulerProblem023 {
	internal class Program {

		const string Abundant = "abundant";
		const string Perfect = "perfect";
		const string Deficient = "deficient";

		static void Main(string[] args) {
			var numberDictionary = new Dictionary<int, string>();

			for (int i = 12; i < 28123; i++) {
				numberDictionary.Add(i, Dividor(i));
			}

			foreach (int i in numberDictionary.Keys) {
				if (numberDictionary[i] == Abundant) {
					Console.WriteLine(i);
				}
			}
		}


		static string Dividor(int number) {
			var workingNumbers = new List<int>();

			for (int i = 1; i < number; i++) {
				if (number % i == 0) {
					workingNumbers.Add(i);
				}
			}

			var sum = workingNumbers.Sum();
			if (sum > number) {
				return Abundant;
			}
			else if (sum == number) {
				return Perfect;
			}
			return Deficient;
		}

	}
}