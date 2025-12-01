public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) return false;
        // convert to string and reverse and return if both same
        return x.ToString() == new string(x.ToString().Reverse().ToArray());
    }
}