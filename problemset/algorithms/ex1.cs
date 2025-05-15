// Longest Unequal Adjacent Groups Subsequence I

public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        
        int count = groups.Length;
        int index;
        List<string> output = new List<string>();


        for(index = 0 ; index < count; index++)
        {
            if (index == 0 ||  groups[index] != groups[index - 1])
                output.Add(words[index]);
        }
        return output;
    }
}