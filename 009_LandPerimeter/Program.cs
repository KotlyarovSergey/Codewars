int Total(string[] map)
{
    int total = 0;
    for (int i = 0; i < map.Length; i++)
    {
        for (int j = 0; j < map[i].Length; j++)
        {
            if (map[i][j] == 'X') total++;
        }
    }
    return total;
}

int Neighbours(string[] map)    //  неправильно!!!! не считает соседй у крайних строки и столбца
{
    int neighbours = 0;
    for (int i = 0; i < map.Length - 1; i++)
    {
        for (int j = 0; j < map[i].Length - 1; j++)
        {
            if (map[i][j] == 'X')
            {
                if (map[i + 1][j] == 'X') neighbours++;
                if (map[i][j + 1] == 'X') neighbours++;

            }
        }
    }

    return neighbours;
}

int Perimeter(string[] map)
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
                if (i < map.Length -1 && map[i + 1][j] == 'X') neighbours++;
                if (j < map[i].Length-1 && map[i][j + 1] == 'X') neighbours++;
            }
        }
    }
    int perimeter = total * 4 - neighbours * 2;
    Console.WriteLine($"Total={total}, neighb={neighbours}, perim={perimeter}");
    return perimeter;
}

// 52
//string[] map = new string[]{"OXOOO", "OOXXX", "OXXOO", "XOOOO", "XOOOO", "XXXOO", "XOXOO", "OOOXO", "OXOOX", "XOOOO", "OOOXO"};

// 60
//string[] map = new string[] { "OXOOOX", "OXOXOO", "XXOOOX", "OXXXOO", "OOXOOX", "OXOOOO", "OOXOOX", "OOXOOO", "OXOOOO", "OXOOXX" };

// 40
//string[] map = new string[]{"XXXXXOOO", "OOXOOOOO", "OOOOOOXO", "XXXOOOXO", "OXOXXOOX"};

// 18
 string[] map = new string[]{"XOOO", "XOXO", "XOXO", "OOXX", "OOOO"};

// string[] map = new string[]{};
// string[] map = new string[]{"O"};
// string[] map = new string[]{"X"};
// string[] map = new string[]{"XX", "XX"};

Console.WriteLine(LandPerimeter.Calculate(map));


// Console.WriteLine($"total = {Total(map)}");
// Console.WriteLine($"neighbours = {Neighbours(map)}");
// Perimeter(map);

