// 3 . Longest Substring Without Repeating Characters

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int finalCount = 0;

        Queue<char> pastChars = new Queue<char>();

        for(int i = 0; i < s.Length; i++){
            if (!pastChars.Contains(s[i])){
                pastChars.Enqueue(s[i]);

            } else {
                while(pastChars.Contains(s[i])){
                    pastChars.Dequeue();
                }
                pastChars.Enqueue(s[i]);
            }        
            finalCount = Math.Max(finalCount, pastChars.Count());
        }
        return finalCount;
    }
}