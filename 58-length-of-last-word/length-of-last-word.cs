public class Solution {
    public int LengthOfLastWord(string s) {
        var parts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return parts[parts.Length - 1].Length;
    }
}