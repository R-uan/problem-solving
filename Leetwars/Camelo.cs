namespace Leetwars;

public class Camelo {
	public static string CamelCase(string str) {
		if (str.Length == 0) return "";
		string b = new string(str);
		string[] a = b.Split(" ");
		for (int i = 0; i < a.Length; i++) {
			char first = char.ToUpper(a[i][0]);
			a[i] = $"{first}{a[i].Substring(1)}";
		}
		return string.Join("", a);
	}
}
