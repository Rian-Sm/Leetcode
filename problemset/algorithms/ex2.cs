// 1. Two Sum

// Brute force solution
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i;
        int j;
        
        for(i = 0 ; i <= nums.Length - 2 ; i++){
            for(j = i + 1 ; j <= nums.Length - 1 ; j++){
                if (nums[i] + nums[j] == target){
                    return new int[] {i, j};
                    break;
                }
            }
        }
        return new int[] {};
    }
}
