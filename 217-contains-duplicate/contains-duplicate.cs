public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var arr = new HashSet<int>();
        // Using HashSet for O(n) time and space
        foreach(int num in nums) {
            if(!arr.Add(num)) return true;
        }
        return false;
    }
}