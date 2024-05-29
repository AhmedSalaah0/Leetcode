public class Solution {
    public int NumSteps(string s) {
        int steps = 0;

while (s != "1")
{
    steps++;
    if (s[s.Length - 1] == '0')
    {
        // Divide by 2
        s = s.Substring(0, s.Length - 1);
    }
    else
    {
        // Add 1
        char[] chars = s.ToCharArray();
        bool carry = true;
        for (int i = s.Length - 1; i >= 0 && carry; i--)
        {
            if (chars[i] == '0')
            {
                chars[i] = '1';
                carry = false;
            }
            else
            {
                chars[i] = '0';
            }
        }
        if (carry)
        {
            s = "1" + new string(chars);
        }
        else
        {
            s = new string(chars);
        }
    }
}
return steps;
    }
}