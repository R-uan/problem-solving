namespace Leet;

public class FuckEyliria {
	public static bool Cry(string text) {
		if (text.Length % 2 != 0) return false;
		Dictionary<char, char> dor = new Dictionary<char, char>() { { '{', '}' }, { '[', ']' }, { '(', ')' } };
		Stack<char> order = new Stack<char>();
		for (int i = 0; i < text.Length; i++) {
			if ("{([".Contains(text[i])) {
				order.Push(dor[text[i]]);
			} else {
				if (text[i] == order.Peek()) order.Pop();
				else return false;
			}
		}
		return true;
	}
}