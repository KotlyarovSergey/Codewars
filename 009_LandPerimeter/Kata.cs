public class LandPerimeter
{
    public static string Calculate(string[] map)
    {
        int total = 0;
        int neighbours = 0;
        for (int i = 0; i < map.Length; i++)
        {
            for (int j = 0; j < map[i].Length; j++)
            {
                if (map[i][j] == 'X')
                {
                    total++;
                    if (i < map.Length - 1 && map[i + 1][j] == 'X') neighbours++;
                    if (j < map[i].Length - 1 && map[i][j + 1] == 'X') neighbours++;
                }
            }
        }
        int perimeter = total * 4 - neighbours * 2;
        return $"Total land perimeter: {perimeter}";
    }
}
