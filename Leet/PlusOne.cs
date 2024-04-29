namespace Leet;
public class PlusOne {
    public int[] PlusOne2(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] != 9) {
                digits[i] = digits[i] + 1;
                break;
            } else {
                digits[i] = 0;
            }
        }
        return digits;
    }
}