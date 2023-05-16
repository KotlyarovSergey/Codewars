// https://www.codewars.com/kata/52e88b39ffb6ac53a400022e
class Int32ToIPv4
{
    public static string UInt32ToIP(uint ip)
    {
        int[] octets = new int[4];
        for (int i = 3; ip > 0; i--)
        {
            octets[i] = (int)(ip % 256);
            ip /= 256;
        }
        return string.Join('.', octets);
    }
}