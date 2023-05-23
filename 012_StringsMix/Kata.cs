using System.Linq;
using System.Collections.Generic;

public class Mixing
{
    public static string Mix(string s1, string s2)
    {
        char[] syms1 = s1.Where(c => (c >= 'a' && c <= 'z')).ToArray();
        char[] syms2 = s2.Where(c => (c >= 'a' && c <= 'z')).ToArray();

        int[] counter1 = new int['z' - 'a' + 1];
        int[] counter2 = new int['z' - 'a' + 1];
        foreach (char sym in syms1) counter1[sym - 'a']++;
        foreach (char sym in syms2) counter2[sym - 'a']++;

        for (int i = 0; i < counter1.Length; i++)
        {
            if (counter1[i] == 1) counter1[i] = 0;
            if (counter2[i] == 1) counter2[i] = 0;
            if (counter1[i] > counter2[i] && counter1[i] > 1) counter2[i] = 0;
            if (counter2[i] > counter1[i] && counter2[i] > 1) counter1[i] = 0;
        }

        string mix = string.Empty;
        int max1 = counter1.Max();
        int max2 = counter2.Max();
        int max = max1 > max2 ? max1 : max2;
        List<string> difference = new List<string>();
        while (max > 1)
        {
            for (int i = 0; i < counter1.Length; i++)
                if (counter1[i] == max && counter2[i] == 0)
                    difference.Add("1:" + new string((char)(i + 'a'), counter1[i]));

            for (int i = 0; i < counter1.Length; i++)
                if (counter2[i] == max && counter1[i] == 0)
                    difference.Add("2:" + new string((char)(i + 'a'), counter2[i]));

            for (int i = 0; i < counter1.Length; i++)
                if (counter1[i] == max && counter2[i] == max)
                    difference.Add("=:" + new string((char)(i + 'a'), counter1[i]));

            max--;
        }

        return string.Join('/', difference);
    }
}