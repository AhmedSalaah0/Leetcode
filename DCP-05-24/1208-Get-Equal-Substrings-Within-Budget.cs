public class Solution {
    public int EqualSubstring(string s, string t, int maxCost) {
        int l = 0, curr = 0, res = 0;
        for (int i = 0; i < s.Length; i++)
    {
        curr += Math.Abs(s[i] - t[i]);
        while (curr > maxCost)
        {
            curr -= Math.Abs(s[l] - t[l]);
            l++;
        }
        res = Math.Max(res, i - l + 1);
    }
    return res;
    }
}