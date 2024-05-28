public class Solution {
    public int RomanToInt(string s) {
        int intValue = 0;
    Dictionary<char, int> dict = new Dictionary<char, int>
    {
    {'I', 1},
    {'V', 5},
    {'X', 10},
    {'L', 50},
    {'C', 100},
    {'D', 500},
    {'M', 1000},
    }; 

    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (i > 0 && dict[s[i]] > dict[s[i - 1]])
        {
            intValue += dict[s[i]] - dict[s[i - 1]];
            i--;
        }   
        else
        {
            intValue += dict[s[i]];
        }
    }
    return intValue;
    }
}