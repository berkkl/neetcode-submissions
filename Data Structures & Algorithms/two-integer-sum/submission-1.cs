public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> gt = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(gt.ContainsKey(nums[i])){
                return new int[] { gt[nums[i]], i };
            }
            else{
                gt[target-nums[i]] = i;
            }
        }
        return new int[0];
    }
}
