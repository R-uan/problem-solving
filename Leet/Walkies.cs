namespace Leet;

class Walkies {
	public static bool Walk(char[] directions) {
		Dictionary<char, int> mapping = new Dictionary<char, int> { { 'n', 1 }, { 's', -1 }, { 'w', 1 }, { 'e', -1 } };
		if (directions.Length != 10) return false;
		int y = 0;
		int x = 0;
		for (int i = 0; i < directions.Length; i++) {
			if (directions[i] == 'n' || directions[i] == 's') {
				y += mapping[directions[i]];
			} else {
				x += mapping[directions[i]];
			}
		}
		return x == 0 && y == 0;
	}
}