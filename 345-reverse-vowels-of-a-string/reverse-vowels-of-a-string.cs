public class Solution {
    public string ReverseVowels(string s) {
        char[] chars = s.ToCharArray();

        int left = 0;
        int right = s.Length-1;

        string vowels ="aeiouAEIOU";

        while ( left<right)
        {
            while (left < right && !vowels.Contains(chars[left]))
            {
                left++;
            }
            while (left < right && !vowels.Contains(chars[right])) {
                right--;
            }
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;
            left++;
            right--;
        }
        return new string(chars);
    }
}