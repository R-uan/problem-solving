using Leet;
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
}