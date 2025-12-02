public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] table = new int[26];
        foreach(char c in magazine) {
            table[c-'a']++;
        }
        foreach(char c in ransomNote) {
            table[c-'a']--;
        }
        return table.All(x => x>=0);
    }
}