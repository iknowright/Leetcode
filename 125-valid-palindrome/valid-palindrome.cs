public class Solution {
    public bool IsPalindrome(string s) {
        // remove ' ', ',', ':', convert to lower
        var filtered = new string(
            s.Where(char.IsLetterOrDigit)
             .Select(char.ToLower)
             .ToArray()
        );

        return filtered.SequenceEqual(filtered.Reverse());
    }
}