public class Solution {
    public int HeightChecker(int[] heights) {
        int[] sorted = new int[heights.Length];
        Array.Copy(heights, sorted, sorted.Length);
        Array.Sort(sorted);
        int c = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != sorted[i])
                c++;
        }
        return c;
    }
}