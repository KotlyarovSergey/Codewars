//  O A W H
public class Kata
{
    public static char[,] SeparateLiquids(char[,] glass)
    {
        int row = glass.GetLength(0);
        int clmn = glass.GetLength(1);
        //char[, ] result = new char[rows, clmn];
        int[] support = new int[4];
        foreach (char itm in glass) switch (itm)
            {
                case 'O': support[0]++; break;
                case 'A': support[1]++; break;
                case 'W': support[2]++; break;
                case 'H': support[3]++; break;
            }
        int liquid = 0;

        // Console.WriteLine(string.Join(' ', support));
        for (int r = 0; r < row; r++)
        {
            for (int c = 0; c < clmn; c++)
            {
                while (support[liquid] == 0)
                {
                    liquid++;
                    if (liquid > 3) return glass;
                }
                switch (liquid)
                {
                    case 0: glass[r, c] = 'O'; break;
                    case 1: glass[r, c] = 'A'; break;
                    case 2: glass[r, c] = 'W'; break;
                    case 3: glass[r, c] = 'H'; break;
                }
                support[liquid]--;
            }
        }

        return glass;
    }

    public static char[,] SeparateLiquids2(char[,] glass)
    {
        char[] liquids = new char[]{'O', 'A', 'W', 'H'};
        // count liquids
        int[] all = new int[4];
        foreach (char itm in glass) switch (itm)
            {
                case 'O': all[0]++; break;
                case 'A': all[1]++; break;
                case 'W': all[2]++; break;
                case 'H': all[3]++; break;
            }
        // fill glass
        int liquid = 0;
        for (int r = 0; r < glass.GetLength(0); r++)
        {
            for (int c = 0; c < glass.GetLength(1); c++)
            {
                while (all[liquid] == 0) liquid++;
                glass[r, c] = liquids[liquid];
                all[liquid]--;
            }
        }

        return glass;
    }
}