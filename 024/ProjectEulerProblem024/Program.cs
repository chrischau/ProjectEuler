namespace ProjectEulerProblem024 {
	internal class Program {
		static int count = 0;

		static void Main(string[] args) {
			string str = "0123456789";
			char[] charArry = str.ToCharArray();
			Permute(charArry, 0, str.Length-1);
			Console.WriteLine("Number of permutation: {0}", count);
		}

		static void Permute(char[] numbers, int i, int numberToPermut) {
			int j;
			if (i == numberToPermut) {
				count++;
				Console.WriteLine(numbers);				
				if (count == 1000000) {
					//Console.WriteLine("Count {0}", count);
					//Console.WriteLine(numbers);					
				}
			}
			else {
				for (j = i; j <= numberToPermut; j++) {
					Swap(ref numbers[i], ref numbers[j]);
					Permute(numbers, i + 1, numberToPermut);
					Swap(ref numbers[i], ref numbers[j]);

					if (count == 1000000) break;
				}
			}
		}

		static void Swap(ref char a, ref char b) {
			char tmp;
			tmp = a;
			a = b;
			b = tmp;
		}
	}
}