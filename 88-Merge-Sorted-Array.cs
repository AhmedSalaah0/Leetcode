public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
   if (n == 0)
    return;
else if (m == 0)
{
    for (int s = 0; s < n; s++)
    {
        nums1[s] = nums2[s];
    }
    return;
}
    int i = m - 1, j = n - 1, k = m + n - 1;
    while (i >= 0 && j >= 0) {
            if (nums1[i] > nums2[j]) {
                nums1[k--] = nums1[i--];
            } else {
                nums1[k--] = nums2[j--];
            }
        }
          while (j >= 0) {
            nums1[k--] = nums2[j--];
        }
    
    }
}