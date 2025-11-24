public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int small = int.MaxValue;
        int middle = int.MaxValue;

        foreach (int num in nums)
        {
             if (num <= small)
             {
                small = num;
             }
             else if (num <= middle)
             {
                middle = num;
             }
             else
             {
                return true;
             }
        }
        return false;
    }
}