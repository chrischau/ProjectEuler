using System.Numerics;

namespace ProjectEulerProblem025 {
	internal class Program {
		static void Main(string[] args) {
			for (BigInteger i = 0; i <= 4785; i++) {
				fibonacci(i);
			}
			
		}

		static void fibonacci(BigInteger len) {
			BigInteger a = 0, b = 1, c = 0;

			//Console.Write("{0} {1}", a, b);

			for (BigInteger i = 2; i < len; i++) {
				c = a + b;
				//Console.Write(" {0}", c);
				
				if (c.ToString().Length == 1000) {
					Console.WriteLine("{0} - {1}", len-1, c);
					break;
				}
				a = b;
				b = c;
			}
		}
	}
}