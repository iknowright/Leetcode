public class Solution {
    public int TitleToNumber(string columnTitle) {
        int res=0;
        foreach(char c in columnTitle) {
            res*=26;
            res+=charToValue(c);
        }
        return res;
    }

    private int charToValue(char c) {
        return c - 'A' + 1;
    }
}