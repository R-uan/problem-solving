using System.Text.RegularExpressions;

namespace Leetwars {
	public class BigThree {
		public static List<string> TopThree(string s) {
			string[] leaderboard = new string[3] { "", "", "" };
			List<int> occurences = new List<int>() { 0, 0, 0 };

			string rejex = @"(\w*'\w*'?)|\b\w+\b";
			string cry = s.Replace(";", " ").Replace("/", " ").Replace("-", " ").Replace(":", " ");
			string[] individual_words = cry.Split(" ");
			string track = "";
			foreach (string word in individual_words) {
				if (track.ToLower().Contains(word.ToLower())) continue;
				if (word == "") continue;
				Match valid_word = Regex.Match(word, rejex, RegexOptions.IgnoreCase);
				MatchCollection all_repetitions = Regex.Matches(s, @$"\b{valid_word}\b", RegexOptions.IgnoreCase | RegexOptions.Multiline);

				string current = word.ToLower();
				int current_ocurrences = all_repetitions.Count;
				for (int i = 0; i < 3; i++) {
					if (leaderboard[i].ToLower() == word) break;
					if (current_ocurrences > occurences[i]) {
						string temp = leaderboard[i];
						leaderboard[i] = current;
						current = temp;

						int temp2 = occurences[i];
						occurences[i] = current_ocurrences;
						current_ocurrences = temp2;
					}
				}
				track += word + " ";
			}
			return new List<string>(leaderboard.Where(val => val != "").ToArray());
		}
	}

}