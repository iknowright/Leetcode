public class Solution {
    public bool IsPalindrome(string s) {
        int a=0, b=s.Length-1;
        while(a<b) {
            while(!char.IsLetterOrDigit(s[a]) && a<b) a++;
            while(!char.IsLetterOrDigit(s[b]) && a<b) b--;
            if(char.ToLower(s[a]) != char.ToLower(s[b])) return false;
            a++; b--;
        }
        return true;
    }
}