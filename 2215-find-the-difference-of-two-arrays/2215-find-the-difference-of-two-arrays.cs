public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);

        // set1den set2de olan elemanları çıkar.
        IEnumerable<int> distinctInNums1Only = set1.Except(set2);
        // set2den set1de olan elemanları çıkarır.
        IEnumerable<int> distinctInNums2Only = set2.Except(set1);

        IList<IList<int>> answer = new List<IList<int>>();

        answer.Add(distinctInNums1Only.ToList());
        answer.Add(distinctInNums2Only.ToList());

        return answer;
    }
}