public class Solution {
    public int CountTriplets(int[] arr) {
    int[] prefix = new int[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        prefix[i + 1] = prefix[i] ^ arr[i];
    }
    int c = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int k = i + 1; k < arr.Length; k++)
        {
            if (prefix[i] == prefix[k + 1]) {
                c += (k - i);
            }
        }
    }
    return c;
    }
}