public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] charArray = s.ToCharArray();
        Array.Sort(charArray);
        s = new string(charArray);

        char[] charArrayt = t.ToCharArray();
        Array.Sort(charArrayt);
        t = new string(charArrayt);

        if (s == t)
            return true;
        else
            return false;
    }
}
