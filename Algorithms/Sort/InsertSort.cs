namespace DSnA;

public class InsertSort {
	public static void Do(int[] array) {
		for (int i = 1; i < array.Length; i++) {
			int aux = i;
			while (aux > 0 && array[aux] < array[aux - 1]) {
				int temp = array[aux];
				array[aux] = array[aux - 1];
				array[aux - 1] = temp;
				aux--;
			}
		}
	}
}
