public class Kata
{
    private static List<string> allPINs;
    private static int[][] variants = new int[][]{new int[] {0, 8}, new int[] {1, 2, 4}, new int[] {2, 1, 3, 5}, new int[] {3, 2, 6},
                           new int[] {4, 1, 5, 7}, new int[] {5, 2, 4, 6, 8}, new int[] {6, 3, 5, 9}, new int[] {7, 4, 8},
                           new int[] {8, 5, 7, 9 ,0}, new int[] {9, 6, 8}};


    public static List<string> GetPINs(string observed)
    {
        allPINs = new List<string>();
        AllVariants(observed.ToCharArray(), 0);
        return allPINs;
    }

    static void AllVariants(char[] input, int num)
    {
        if (num < input.Length)
        {
            char[] next = new char[input.Length];
            input.CopyTo(next, 0);
            int n = input[num] - '0';

            foreach (int c in variants[n])
            {
                next[num] = (char)(c + '0');
                string s = new string(next);
                if (!allPINs.Contains(s)) allPINs.Add(s);
                AllVariants(next, num + 1);
            }
        }
    }
}