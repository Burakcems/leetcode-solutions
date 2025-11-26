public class Solution {
    public int Compress(char[] chars) {
        
        int writeIdx = 0;
        int readIdx = 0;
        int n = chars.Length;

        while (readIdx < n)
        {
             char currentChar = chars[readIdx];
             int count = 0;

            while(readIdx < n && chars[readIdx] == currentChar)
            {
                readIdx++;
                count++;
            }
            chars[writeIdx] = currentChar;
            writeIdx++;

            if (count > 1)
            {
                foreach (char digit in count.ToString())
                {
                    chars[writeIdx] = digit;
                    writeIdx++;
                }
            }
        }
        return writeIdx;
    }
}