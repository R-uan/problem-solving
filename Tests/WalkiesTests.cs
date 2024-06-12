using Leetwars;
using NUnit.Framework;

[TestFixture]
public class WalkiesTests {
	[Test]
	public void TestGoodWalkie() {
		char[] GoodWalkie = { 'n', 'n', 'e', 'e', 's', 'w', 's', 'w', 'n', 's' };
		bool result = Walkies.Walk(GoodWalkie);
		Assert.IsTrue(result);
	}

	[Test]
	public void TestShortWalkie() {
		char[] ShortWalkie = { 'n', 's', 's' };
		bool result = Walkies.Walk(ShortWalkie);
		Assert.IsFalse(result);
	}

	[Test]
	public void TestBadWalkie() {
		char[] BadWalkie = { 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n' };
		bool result = Walkies.Walk(BadWalkie);
		Assert.IsFalse(result);
	}

	[Test]
	public void TestBadWalkie2() {
		char[] BadWalkie = { 'n', 's', 's', 's', 's', 'e', 'e', 'e', 'e', 'w' };
		bool result = Walkies.Walk(BadWalkie);
		Assert.IsFalse(result);
	}

	[Test]
	public void TestProblem() {
		char[] Problem = { 'n', 'n', 'n', 'n', 'n', 'e', 'e', 'e', 'e', 'e' };
		bool result = Walkies.Walk(Problem);
		Assert.IsFalse(result);
	}
}