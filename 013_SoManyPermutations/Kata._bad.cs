class Permutations_bad
{
    static HashSet<string> uniques;
    public static List<string> SinglePermutations(string s)
    {
        uniques = new();
        char[] charSet = s.ToCharArray();
        Permutation(ref charSet, charSet.Length);
        return new List<string>(uniques);
    }

    static void Permutation(ref char[] data, int n)
    {
        if (n == 0)
            uniques.Add(new string(data));
        else
        {
            for (int i = 0; i < n; i++)
            {
                Permutation(ref data, n - 1);
                if (n % 2 == 0)
                    (data[i], data[n-1]) = (data[n-1], data[i]);
                else
                    (data[0], data[n-1]) = (data[n-1], data[0]);
            }
        }
    }
}