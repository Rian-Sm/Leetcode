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

// two-pass hashtable solution

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i;
        int n = nums.Length;

        Hashtable ht = new Hashtable();
        
        for (i = 0 ; i < n ; i++ ){
            ht[nums[i]] = i;
        }

        for (i = 0 ; i < n ; i++ ){
            if (ht.Contains(target-nums[i]) && i != (int) ht[target-nums[i]] )
                return new int[] {i,(int) ht[target-nums[i]]};
        }
        return new int[] {};
    }
}
