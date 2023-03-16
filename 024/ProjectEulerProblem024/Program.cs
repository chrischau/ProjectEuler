using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace ProjectEulerProblem024 {
	internal class Program {
		static int count = 0;

		static void Main(string[] args) {
			//string str = "0123456789";
			//char[] charArry = str.ToCharArray();
			//Permute(charArry, 0, str.Length - 1);
			//Console.WriteLine("Number of permutation: {0}", count);

			Console.WriteLine(solution(1000000));
		}

		static void Permute(char[] numbers, int i, int numberToPermut) {
			int j;
			if (i == numberToPermut) {
				count++;
				//Console.WriteLine(numbers);				
				if (count == 1000000) {
					//Console.WriteLine("Count {0}", count);
					Console.WriteLine(numbers);
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

		static string solution(int num) {
			var fac = new List<int> { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
			var arr = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var ret = "";

			num--;
			for (var i = arr.Count - 1; i >= 0; i--) {
				var t = num / fac[i] | 0;
				//Console.WriteLine("{0} - {1} / {2} = {3}, {4}, {5}", i, num, fac[i], t, arr[t], ret); 
				
				num %= fac[i];
				ret += arr[t];
				arr.RemoveAt(t);
			}
			return ret;
		}
	}
}