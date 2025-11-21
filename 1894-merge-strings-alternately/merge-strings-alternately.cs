public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder sonuc = new StringBuilder(word1.Length + word2.Length);

        int i=0 ;
        
        while (i < word1.Length || i < word2.Length)
        {
            if(i<word1.Length)
            {
                sonuc.Append(word1[i]);
            }
            if(i<word2.Length)
            {
                sonuc.Append(word2[i]);
            }
            i++;
        }
        return sonuc.ToString();
    }
}