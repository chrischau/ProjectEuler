namespace ProjectEulerProblem018 {
	internal class Program {
		static void Main(string[] args) {
						
			maxSum = 0;

			OutputTree(CreateTree());
			Console.WriteLine("Max Sum = {0}", maxSum);
		}

		static Tree CreateTree() {
			var row15_1 = new Tree(4);
			var row15_2 = new Tree(62);
			var row15_3 = new Tree(98);
			var row15_4 = new Tree(27);
			var row15_5 = new Tree(23);
			var row15_6 = new Tree(9);
			var row15_7 = new Tree(70);
			var row15_8 = new Tree(98);
			var row15_9 = new Tree(73);
			var row15_10 = new Tree(93);
			var row15_11 = new Tree(38);
			var row15_12 = new Tree(53);
			var row15_13 = new Tree(60);
			var row15_14 = new Tree(4);
			var row15_15 = new Tree(23);

			var row14_1 = new Tree(63, row15_1, row15_2);
			var row14_2 = new Tree(66, row15_2, row15_3);
			var row14_3 = new Tree(4, row15_3, row15_4);
			var row14_4 = new Tree(68, row15_4, row15_5);
			var row14_5 = new Tree(89, row15_5, row15_6);
			var row14_6 = new Tree(53, row15_6, row15_7);
			var row14_7 = new Tree(67, row15_7, row15_8);
			var row14_8 = new Tree(30, row15_8, row15_9);
			var row14_9 = new Tree(73, row15_9, row15_10);
			var row14_10 = new Tree(16, row15_10, row15_11);
			var row14_11 = new Tree(69, row15_11, row15_12);
			var row14_12 = new Tree(87, row15_12, row15_13);
			var row14_13 = new Tree(40, row15_13, row15_14);
			var row14_14 = new Tree(31, row15_14, row15_15);

			var row13_1 = new Tree(91, row14_1, row14_2);
			var row13_2 = new Tree(71, row14_2, row14_3);
			var row13_3 = new Tree(52, row14_3, row14_4);
			var row13_4 = new Tree(38, row14_4, row14_5);
			var row13_5 = new Tree(17, row14_5, row14_6);
			var row13_6 = new Tree(14, row14_6, row14_7);
			var row13_7 = new Tree(91, row14_7, row14_8);
			var row13_8 = new Tree(43, row14_8, row14_9);
			var row13_9 = new Tree(58, row14_9, row14_10);
			var row13_10 = new Tree(50, row14_10, row14_11);
			var row13_11 = new Tree(27, row14_11, row14_12);
			var row13_12 = new Tree(29, row14_12, row14_13);
			var row13_13 = new Tree(48, row14_13, row14_14);

			var row12_1 = new Tree(70, row13_1, row13_2);
			var row12_2 = new Tree(11, row13_2, row13_3);
			var row12_3 = new Tree(33, row13_3, row13_4);
			var row12_4 = new Tree(28, row13_4, row13_5);
			var row12_5 = new Tree(77, row13_5, row13_6);
			var row12_6 = new Tree(73, row13_6, row13_7);
			var row12_7 = new Tree(17, row13_7, row13_8);
			var row12_8 = new Tree(78, row13_8, row13_9);
			var row12_9 = new Tree(39, row13_9, row13_10);
			var row12_10 = new Tree(68, row13_10, row13_11);
			var row12_11 = new Tree(17, row13_11, row13_12);
			var row12_12 = new Tree(57, row13_12, row13_13);

			var row11_1 = new Tree(53, row12_1, row12_2);
			var row11_2 = new Tree(71, row12_2, row12_3);
			var row11_3 = new Tree(44, row12_3, row12_4);
			var row11_4 = new Tree(65, row12_4, row12_5);
			var row11_5 = new Tree(25, row12_5, row12_6);
			var row11_6 = new Tree(43, row12_6, row12_7);
			var row11_7 = new Tree(91, row12_7, row12_8);
			var row11_8 = new Tree(52, row12_8, row12_9);
			var row11_9 = new Tree(97, row12_9, row12_10);
			var row11_10 = new Tree(51, row12_10, row12_11);
			var row11_11 = new Tree(14, row12_11, row12_12);

			var row10_1 = new Tree(41, row11_1, row11_2);
			var row10_2 = new Tree(48, row11_2, row11_3);
			var row10_3 = new Tree(72, row11_3, row11_4);
			var row10_4 = new Tree(33, row11_4, row11_5);
			var row10_5 = new Tree(47, row11_5, row11_6);
			var row10_6 = new Tree(32, row11_6, row11_7);
			var row10_7 = new Tree(37, row11_7, row11_8);
			var row10_8 = new Tree(16, row11_8, row11_9);
			var row10_9 = new Tree(94, row11_9, row11_10);
			var row10_10 = new Tree(29, row11_10, row11_11);

			var row9_1 = new Tree(41, row10_1, row10_2);
			var row9_2 = new Tree(41, row10_2, row10_3);
			var row9_3 = new Tree(26, row10_3, row10_4);
			var row9_4 = new Tree(56, row10_4, row10_5);
			var row9_5 = new Tree(83, row10_5, row10_6);
			var row9_6 = new Tree(40, row10_6, row10_7);
			var row9_7 = new Tree(80, row10_7, row10_8);
			var row9_8 = new Tree(70, row10_8, row10_9);
			var row9_9 = new Tree(33, row10_9, row10_10);

			var row8_1 = new Tree(99, row9_1, row9_2);
			var row8_2 = new Tree(65, row9_2, row9_3);
			var row8_3 = new Tree(4, row9_3, row9_4);
			var row8_4 = new Tree(28, row9_4, row9_5);
			var row8_5 = new Tree(6, row9_5, row9_6);
			var row8_6 = new Tree(16, row9_6, row9_7);
			var row8_7 = new Tree(70, row9_7, row9_8);
			var row8_8 = new Tree(92, row9_8, row9_9);

			var row7_1 = new Tree(88, row8_1, row8_2);
			var row7_2 = new Tree(2, row8_2, row8_3);
			var row7_3 = new Tree(77, row8_3, row8_4);
			var row7_4 = new Tree(73, row8_4, row8_5);
			var row7_5 = new Tree(7, row8_5, row8_6);
			var row7_6 = new Tree(63, row8_6, row8_7);
			var row7_7 = new Tree(67, row8_7, row8_8);

			var row6_1 = new Tree(19, row7_1, row7_2);
			var row6_2 = new Tree(1, row7_2, row7_3);
			var row6_3 = new Tree(23, row7_3, row7_4);
			var row6_4 = new Tree(75, row7_4, row7_5);
			var row6_5 = new Tree(3, row7_5, row7_6);
			var row6_6 = new Tree(34, row7_6, row7_7);

			var row5_1 = new Tree(20, row6_1, row6_2);
			var row5_2 = new Tree(4, row6_2, row6_3);
			var row5_3 = new Tree(82, row6_3, row6_4);
			var row5_4 = new Tree(47, row6_4, row6_5);
			var row5_5 = new Tree(65, row6_5, row6_6);

			var row4_1 = new Tree(18, row5_1, row5_2);
			var row4_2 = new Tree(35, row5_2, row5_3);
			var row4_3 = new Tree(87, row5_3, row5_4);
			var row4_4 = new Tree(10, row5_4, row5_5);

			var row3_1 = new Tree(17, row4_1, row4_2);
			var row3_2 = new Tree(47, row4_2, row4_3);
			var row3_3 = new Tree(82, row4_3, row4_4);

			var row2_1 = new Tree(95, row3_1, row3_2);
			var row2_2 = new Tree(64, row3_2, row3_3);

			var headTree = new Tree(75, row2_1, row2_2);

			return headTree;
		}

		static internal int maxSum;
		static internal int tempSum;

		static internal void OutputTree(Tree tree) {
			//Console.Write("{0} - ", tree.Number);
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