//Prgr2.Start();

// int[] code = new int[] { 0, 1, 2, 3 };
// int[] code = new int[] { 0, 3, 1, 2 };
// int[] code = new int[] { 3, 1, 0, 2 };
// int[] code = new int[] { 3, 2, 1, 0 };

// int[] code = new int[] { 2, 9, 3, 4 };
int[] code = new int[] { 4, 9, 2, 3 };
// int[] code = new int[] { 4, 2, 6, 3 };
int matches = -1;
bool win = false;


for (int attempt = 0; attempt < 17; attempt++)
{
    //Console.WriteLine("attempt: " + (attempt+1) );
    int[] answer = Player4.TryToGuess(matches);
    Console.WriteLine("   >>" + (attempt+1) + ": [" + string.Join(' ', answer)+ "]\n");

    matches = 0;
    // Console.WriteLine(string.Join(' ', answer));
    for (int k = 0; k < 4; k++)
        if (answer[k] == code[k])
            matches++;
    // Console.WriteLine("matches: " + string.Join(' ', matches));
    if(matches==4) 
    {
        win = true;
        break;
    }
}

if(win) Console.WriteLine("Congratulation!");