namespace Merging;

public class Merge {
	public static int[] Exec(int[] array1, int[] array2) {
		int left = 0;
		int right = 0;
		int aux = 0;
		int[] new_array = new int[array1.Length + array2.Length];
		while (left < array1.Length && right < array2.Length) {
			if (array1[left] <= array2[right]) {
				new_array[aux] = array1[left];
				left++;
			} else {
				new_array[aux] = array2[right];
				right++;
			}
			aux++;
		}

		while (left < array1.Length) {
			new_array[aux] = array1[left];
			left++; aux++;
		}

		while (right < array2.Length) {
			new_array[aux] = array2[right];
			right++; aux++;
		}

		return new_array;
	}
}
