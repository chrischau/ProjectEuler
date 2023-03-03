namespace ProjectEulerProblem018 {
	internal class Tree {
		public Tree? LeftLeaf;
		public Tree? RightLeaf;

		public int Number;

		public Tree(int number, Tree? leftLeaf = null, Tree? rightLeaf = null) {
			Number = number;
			LeftLeaf = leftLeaf;
			RightLeaf = rightLeaf;
		}

	}
}
