namespace DSnA;

public class QuickSort {

	public static void Sort(int[] array, int start, int end) {
		if (start < end) {
			int pivot = Partition(array, start, end);
			Sort(array, start, pivot);
			Sort(array, pivot + 1, end);
		}
	}

	public static int Partition(int[] array, int start, int end) {
		int pivot = array[start];
		int aux = start;

		for (int i = start + 1; i < end; i++) {
			if (array[i] <= pivot) {
				aux++;
				(array[aux], array[i]) = (array[i], array[aux]);
			}
		}
		(array[aux], array[start]) = (array[start], array[aux]);
		return aux;
	}
}
