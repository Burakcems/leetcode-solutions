using System.Collections.Generic;
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        int maxCandies = 0;
        for(int i=0;i<candies.Length;i++)
        {
            if(candies[i]>maxCandies)
            {
                maxCandies = candies[i];
            }
        }
        List<bool> result = new List<bool>();

        for(int i=0;i<candies.Length;i++)
        {
            if(candies[i]+extraCandies>=maxCandies)
            {
                result.Add(true);
            }
            else{
                result.Add(false);
            }
        } 
       return result;
    }
    
}