public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums.Length<2) {
            if(nums.Length==0) return 0;
            if(nums.Length==1) return (nums[0]>=target)? 0:1;
        }
        int min=0,max=nums.Length-1, mid;
        while(min<=max) {
            mid=(int)((min+max)/2);
            if(nums[mid]==target) return mid;
            else if(nums[mid]>target) {
                max=mid-1;
            }
            else if(nums[mid]<target) {
                min=mid+1;
            }
        }
        return min;
    }
}