namespace ProjectEulerProblem031 {
	internal class Program {
		static void Main(string[] args) {
			int count = PossibleChange(200);

			Console.WriteLine("Number of possibility = {0}", count);
		}

		static int PossibleChange(int total) {
			int count = 0;

			for (int a = total; a >= 0; a -= 200) // 200p
				for (int b = a; b >= 0; b -= 100) // 100p
					for (int c = b; c >= 0; c -= 50) // 50p
						for (int d = c; d >= 0; d -= 20) // 20p
							for (int e = d; e >= 0; e -= 10) // 10p
								for (int f = e; f >= 0; f -= 5) // 5p
									for (int g = f; g >= 0; g -= 2) { // 2p, if 3p, it will produce count 2										
										count++;
									}

			return count;
		}
	}
}