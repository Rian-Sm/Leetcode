public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
            int[] concatArray = nums1.Concat(nums2).ToArray();
            Array.Sort(concatArray);

            double value = 0;

            if (concatArray.Length%2 == 0){
                value =  (double) ((double) concatArray[concatArray.Length/2-1]+ concatArray[concatArray.Length/2])/(double) 2;
            } else {
                value = concatArray[concatArray.Length/2];
            }
            
            return value;
    }
}