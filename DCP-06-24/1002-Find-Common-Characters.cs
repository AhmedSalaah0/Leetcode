public class Solution {
    public IList<string> CommonChars(string[] words) {
        List<string> list = new List<string>();
        int[] MinimumFreq = new int[26];

        Array.Fill(MinimumFreq, int.MaxValue);
        foreach (string word in words)
        {
            int[] count = new int[26];
            foreach (char c in word.ToCharArray())
        {
            count[c - 'a']++;
        }   
        for (int i = 0; i < 26; i++)
        {
            MinimumFreq[i] = Math.Min(MinimumFreq[i], count[i]);
        }
    }

    for (int i = 0; i < 26; i++)
    {
        while (MinimumFreq[i] > 0)
        {
            list.Add(((char)('a' + i)).ToString());
            MinimumFreq[i]--;
        }
    }
    return list;
    }
}