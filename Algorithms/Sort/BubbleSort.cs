namespace DSnA;

public class BubbleSort {
	public static void Exec(int[] array) {
		for (int i = array.Length - 1; i > 0; i--) {
			bool swapped = false;
			for (int y = 0; y < i; y++) {
				if (array[y] > array[y + 1]) {
					(array[y], array[y + 1]) = (array[y + 1], array[y]);
					swapped = true;
				}
			}
			if (!swapped) break;
		}
	}
}
