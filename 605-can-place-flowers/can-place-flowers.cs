public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        if(n==0)
        {
            return true;
        }
        int length = flowerbed.Length;

        for(int i = 0;i<length;i++)
        {
            if(flowerbed[i]==0)
            {
                bool leftempty=(i==0 || flowerbed[i-1]==0);

                bool rightempty=(i==length-1 || flowerbed[i+1]==0);
            
            if(leftempty==true && rightempty==true)
            {
                flowerbed[i]=1;
                n--;
            }
            }
            if(n==0)
            {
                return true;
            }
        }
        return n==0;
    }
    
}