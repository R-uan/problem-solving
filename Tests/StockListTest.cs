namespace Leet;
using System;
using NUnit.Framework;

[TestFixture]
public class StockListTests {

	[Test]
	public void Test1() {
		string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
		String[] cd = new String[] { "A", "B" };
		Assert.That(StockList.StockSummary(art, cd), Is.EqualTo("(A : 200) - (B : 1140)"));
	}
}
