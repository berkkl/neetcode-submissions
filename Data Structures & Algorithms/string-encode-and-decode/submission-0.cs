public class Solution
{
    public string Encode(IList<string> strs)
    {
        string[] encodedStringList = new string[strs.Count];

        for (int i = 0; i < strs.Count; i++)
        {
            int strLen = strs[i].Length;
            encodedStringList[i] = $"{strLen}#{strs[i]}";
        }

        return string.Concat(encodedStringList);
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            while (s[j] != '#')
            {
                j++;
            }

            int len = int.Parse(s.Substring(i, j - i));
            int contentStart = j + 1;

            result.Add(s.Substring(contentStart, len));

            i = contentStart + len;
        }

        return result;
    }
}