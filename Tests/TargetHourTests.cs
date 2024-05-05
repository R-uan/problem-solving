using NUnit.Framework;
using Leet;

namespace ProblemSolving;
[TestFixture]
public class TargetHourTests {
	[Test]
	public void Test0() {
		int[] hours = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, };
		int result = Leet.TargetHour.Run(hours, 1);
		Assert.That(result, Is.EqualTo(0));
	}

	[Test]
	public void Test4() {
		int[] hours = new int[] { 6, 0, 1, 0, 4, 0, 3, 0, };
		int result = Leet.TargetHour.Run(hours, 1);
		Assert.That(result, Is.EqualTo(4));
	}
}
