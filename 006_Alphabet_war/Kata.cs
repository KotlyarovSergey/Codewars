public class Kata
{
    public static string AlphabetWar(string fight)
    {
        // left  w - 4   p - 3   b - 2   s - 1
        // right m - 4   q - 3   d - 2   z - 1

        int leftScore = 0;
        int rightScore = 0;
        foreach (char ch in fight)
        {
            switch (ch)
            {
                case 'w': leftScore += 4; break;
                case 'p': leftScore += 3; break;
                case 'b': leftScore += 2; break;
                case 's': leftScore++; break;
                case 'm': rightScore += 4; break;
                case 'q': rightScore += 3; break;
                case 'd': rightScore += 2; break;
                case 'z': rightScore++; break;
            }
        }
        if (leftScore == rightScore) return "Let's fight again!";
        else if (leftScore > rightScore) return "Left side wins!";
        else return "Right side wins!";
    }
}