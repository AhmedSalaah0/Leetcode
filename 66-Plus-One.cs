public class Solution {
    public int[] PlusOne(int[] digits) {
    int len = digits.Length;

    for (int i = len - 1; i >= 0; i--)
    {
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }
        int[] New = new int[len + 1];
        New[0] = 1;
        return New;
    }
}