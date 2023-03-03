namespace ProjectEulerProblem018 {
	internal class Program {
		static void Main(string[] args) {

			//3
			//7, 4
			//2, 4, 6
			//8, 5, 9, 3

			var row4_1 = new Tree(3);
			var row4_2 = new Tree(9);
			var row4_3 = new Tree(5);
			var row4_4 = new Tree(8);

			var row3_1 = new Tree(6, row4_1, row4_2);
			var row3_2 = new Tree(4, row4_2, row4_3);
			var row3_3 = new Tree(2, row4_3, row4_4);

			var row2_1 = new Tree(4, row3_1, row3_2);
			var row2_2 = new Tree(7, row3_2, row3_3);

			var headTree = new Tree(3, row2_1, row2_2);

			maxSum = 0;

			OutputTree(headTree);
			Console.WriteLine("Max Sum = {0}", maxSum);
		}

		static internal int maxSum;
		static internal int tempSum;

		static internal void OutputTree(Tree tree) {
			Console.Write("{0} - ", tree.Number);
			tempSum += tree.Number;

			//Console.WriteLine("Temp {0} > Max {1} : {2}", tempSum, maxSum, tempSum > maxSum);
			if (tempSum > maxSum) { maxSum = tempSum; }

			while (tree.LeftLeaf is not null) {
				OutputTree(tree.LeftLeaf);
				tempSum -= tree.LeftLeaf.Number;
				break;
			}

			while (tree.RightLeaf is not null) {
				OutputTree(tree.RightLeaf);
				tempSum -= tree.RightLeaf.Number;
				break;
			}
		}

	}
}