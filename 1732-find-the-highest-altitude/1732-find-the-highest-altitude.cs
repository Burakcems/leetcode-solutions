public class Solution {
    public int LargestAltitude(int[] gain) {

        int mevcutYukseklik = 0;
        int maxYukseklik = 0;

        for(int i= 0;i<gain.Length;i++)
        {
            mevcutYukseklik+=gain[i];

            maxYukseklik = Math.Max(maxYukseklik,mevcutYukseklik);
        }
        return maxYukseklik;
    }
}