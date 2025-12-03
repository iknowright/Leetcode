public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle.Length==0 || haystack==needle) return 0;
        int j=0;
        for(int i=0; i<=haystack.Length-needle.Length; i++) {
            if(haystack[i]==needle[0]) {
                while(j<needle.Length && haystack[i+j]==needle[j]) {
                    j++;
                }
                if(j==needle.Length) return i;
                else j=0;
            }
        }
        return -1;
    }
}