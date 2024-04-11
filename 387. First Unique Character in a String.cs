public class Solution
{
    // Solution 2
    public int FirstUniqChar(string s)
    {
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++)
            count[s[i] - 97]++;
        for (int i = 0; i < s.Length; i++)
            if (count[s[i] - 97] == 1)
                return i;
        return -1;
    }

    // Solution 1
    /*
    public int FirstUniqChar(string s)
    {
        int[] count = new int[26];
        int next = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int index = s[i] - 97;
            count[index]++;
            if (count[index] > 1)
            {
                while (count[s[next] - 97] > 1 && next != s.Length - 1)
                    next++;
            }
        }
        if (count[s[next] - 97] == 1)
            return next;
        else
            return -1;
    }
    */
}
