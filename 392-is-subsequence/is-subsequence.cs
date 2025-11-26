public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        int sIndex = 0;
        int tIndex = 0;
        if (s.Length == 0) return true;

         while (tIndex < t.Length)
         {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }
            tIndex++;

            if (sIndex == s.Length)
            {
                return true;
            }
         }
         return false;  
    }
}