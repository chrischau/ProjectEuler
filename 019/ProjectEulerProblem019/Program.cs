namespace ProjectEulerProblem019 {
	internal class Program {
		static void Main(string[] args) {
			int sundayCount = 0;

			var day = new DateTime(1901, 1, 1);
			var lastDay = new DateTime(2000, 12, 31);

			while (day <= lastDay) {
				if (day.DayOfWeek == DayOfWeek.Sunday	&& day.Day == 1) {
					sundayCount++;
					//Console.WriteLine(day);
				}
				day = day.AddDays(1);
			}

			Console.WriteLine("Total number of Sundays: {0}", sundayCount); //171
		}
	}
}