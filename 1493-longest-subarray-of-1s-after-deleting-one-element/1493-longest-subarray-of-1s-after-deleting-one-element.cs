public class Solution {
    public int LongestSubarray(int[] nums) {
        
        int left = 0;
        int right = 0;
        int zeroCount =0;
        int maxLength = 0;

        for(right = 0;right<nums.Length;right++)
        {
            if(nums[right]==0)
            {
                zeroCount++;
            }
            while(zeroCount>1)
            {
                if (nums[left]==0)
                {
                    zeroCount--;
                }
                left++;
            }
            maxLength = Math.Max(maxLength,right-left);
        }
        return maxLength;
    }
}