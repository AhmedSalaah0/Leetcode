public class Solution {
    public string AddBinary(string a, string b) {
    a = a.PadLeft(Math.Max(a.Length, b.Length), '0');
    b = b.PadLeft(Math.Max(a.Length, b.Length), '0');

    StringBuilder result = new StringBuilder();
    int carry = 0;

    for (int i = a.Length - 1;  i >= 0; i--)
    {
        int BitA = a[i] - '0';
        int BitB = b[i] - '0';

        int sum = BitA ^ BitB ^ carry;
        carry = (BitA & BitB) | (carry & (BitA ^ BitB));

        result.Insert(0, sum.ToString());
    }
    if (carry == 1) { 
        result.Insert(0, \1\);
    }
    return result.ToString();

    }
}
