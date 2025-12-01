public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++) {
            int num = target - nums[i];
            
            if(dict.ContainsKey(num)) {
                return new  int[] {i, dict[num]};
            }
            else dict[nums[i]] = i;
        }

        return new int[] {0, 0};
    }
}