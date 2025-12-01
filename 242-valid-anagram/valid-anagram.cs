public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int [] charArr = new int [26];
        for(int i=0; i<s.Length; i++) {
            charArr[s[i] - 'a']++;
            charArr[t[i] - 'a']--;
        }
        return charArr.All(x => x==0);
    }
}