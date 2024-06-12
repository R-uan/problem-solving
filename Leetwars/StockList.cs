namespace Leetwars;

public class StockList {
	public static string StockSummary(string[] lstOfArt, string[] lstOf1stLetter) {
		Dictionary<char, int> stock = new Dictionary<char, int>();
		for (int letter = 0; letter < lstOf1stLetter.Length; letter++) {
			char currLetter = lstOf1stLetter[letter][0];
			for (int art = 0; art < lstOfArt.Length; art++) {
				int currNumber = int.Parse(lstOfArt[art].Split(" ")[1]);
				if (currLetter == lstOfArt[art][0]) {
					if (!stock.TryAdd(currLetter, currNumber)) {
						stock[currLetter] += currNumber;
					}
				}
			}
		}
		List<string> strings = new List<string>();
		foreach (KeyValuePair<char, int> kvp in stock) {
			strings.Add($"({kvp.Key} : {kvp.Value})");
		}

		return string.Join(" - ", strings.ToArray());
	}
}
