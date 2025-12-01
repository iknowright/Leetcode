public class Solution {
    int Value(char c) => c switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => 0
    };
    public int RomanToInt(string s) {
        int res = 0, temp;
        for(int i=0; i<s.Length-1; i++) {
            temp = Value(s[i]);
            res += (temp<Value(s[i+1]))? -temp : temp;
        }
        return res + Value(s[s.Length-1]);
    }
}