namespace DSnA;

public class SelectionSort {
	public static void Do(int[] array) {
		for (int i = 0; i < array.Length; i++) {
			int lowest = i;
			for (int j = i + 1; j < array.Length; j++) {
				if (array[j] < array[lowest]) {
					lowest = j;
				}
			}
			int temp = array[i];
			array[i] = array[lowest];
			array[lowest] = temp;
		}
	}
}
