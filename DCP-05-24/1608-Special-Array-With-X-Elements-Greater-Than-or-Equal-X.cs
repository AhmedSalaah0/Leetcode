public class Solution {
    public int SpecialArray(int[] nums) {
    for (int i = 0; i <= nums.Length; i++)
   {
       int c = 0;
       for (int j = 0; j < nums.Length; j++)
       {
           if (nums[j] >= i) {
               c++;
           }
       }
       if (c == i)
       {
           return i;
       }
   }
    return -1;
    }
}