namespace Leetwars;

public class TargetHour {
	public static int Run(int[] hours, int target) {
		int result = 0;
		foreach (int hour in hours) if (hour >= target) result++;
		return result;
	}
}
