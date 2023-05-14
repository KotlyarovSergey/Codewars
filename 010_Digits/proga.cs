using System;
using System.Linq;

// namespace Digits;

public static class Prgr
{
    static int[] dictonary = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2 };
    static int tryCount = 0;
    
    public static void Start()
    {
        int[] code = Generate();
        //code = new int[]{2,8,1,4};
        //code = new int[]{2,8,0,5};
        //code = new int[]{2,6,7,5};
        Console.WriteLine("code:");
        Console.WriteLine(String.Join(' ', code));
        int[] attempt = new int[4];

        int[,] matchArray = new int[0, 4];
        int[,] missMatchArray = new int[0, 4];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 4; j++) attempt[j] = dictonary[i + j];
            //Console.WriteLine(String.Join(' ', attempt) + " match: " + Match(attempt, code).ToString());
            int m = Match(attempt, code);
            if (m > 0)
            {
                while (m > 0)
                {
                    AddMatch(ref matchArray, attempt);
                    m--;
                }
            }
            else AddMatch(ref missMatchArray, attempt);
        }

        //
        Console.WriteLine("matches:");
        for (int r = 0; r < matchArray.GetLength(0); r++)
        {
            for (int c = 0; c < matchArray.GetLength(1); c++)
                Console.Write(matchArray[r, c] + " ");
            Console.WriteLine();
        }
        //


        Console.WriteLine("missings:");
        for (int r = 0; r < missMatchArray.GetLength(0); r++)
        {
            for (int c = 0; c < missMatchArray.GetLength(1); c++)
                Console.Write(missMatchArray[r, c] + " ");
            Console.WriteLine();
        }

        Console.WriteLine("attempts: " + tryCount);

        Console.WriteLine("\nmask1:");
        attempt = GetRow(matchArray, 0);
        int[] mask = GetMask(missMatchArray, attempt);
        Console.WriteLine(string.Join(' ', mask));

        //int[] answer = new int[]{-1, -1, -1, -1};
        int[] answer = new int[4];
        int answMask = 0;

        // ---------  1 -------------
        // маскируем 3,4 цифры
        attempt = new int[4] { matchArray[0, 0], matchArray[0, 1], mask[2], mask[3] };
        if (Match(attempt, code) > 0)
        {
            // совпадение в певых 2х цифрах
            // маскируем вторую
            attempt = new int[4] { matchArray[0, 0], mask[1], mask[2], mask[3] };
            if (Match(attempt, code) > 0)
            {
                // первая цифра совпала
                answer[0] = matchArray[0, 0];
                answMask += 0b1000;
            }
            else
            {
                // вторая цифра совпала
                answer[1] = matchArray[0, 1];
                answMask += 0b0100;
            }
        }
        else
        {
            // совпадение в 3,4 цифрах
            // маскируем четвертую
            attempt = new int[4] { mask[0], mask[1], matchArray[0, 2], mask[3] };
            if (Match(attempt, code) > 0)
            {
                // третья цифра совпала
                answer[2] = matchArray[0, 2];
                answMask += 0b0010;
            }
            else
            {
                // четвёртая цифра совпала
                answer[3] = matchArray[0, 3];
                answMask += 0b0001;
            }
        }

        Console.WriteLine(String.Join(' ', answer));
        Console.WriteLine(Convert.ToString(answMask, 2));
        Console.WriteLine("attempts: " + tryCount);




        Console.WriteLine("\nmask2:");
        attempt = GetRow(matchArray, 1);
        mask = GetMask(missMatchArray, attempt);
        Console.WriteLine(string.Join(' ', mask));

        // ---------  2 ---------------
        // если первая угад цифра в первой половине
        if (answMask > 0b0010)
        {
            // маскируем первую половину
            attempt = new int[4] { mask[0], mask[1], matchArray[1, 2], matchArray[1, 3] };
            if (Match(attempt, code) > 0)
            {       // совпаде6ие во втрой половине
                    // маскируем 4ю цифру
                attempt = new int[4] { mask[0], mask[1], matchArray[1, 2], mask[3] };
                if (Match(attempt, code) > 0)
                {
                    // угадана 3я цифра
                    answer[2] = matchArray[1, 2];
                    answMask += 0b0010;
                }
                else
                {
                    // угадана 4я цифра
                    answer[3] = matchArray[1, 3];
                    answMask += 0b0001;
                }
            }
            else
            {
                // совпад в первой полов
                if (answMask == 0b1000)
                {
                    // раньше угадали 1ю цифру, теперь вторкю
                    answer[1] = matchArray[1, 1];
                    answMask += 0b0100;
                }
                else
                {
                    answer[0] = matchArray[1, 0];
                    answMask += 0b1000;
                }

            }

        }
        else // если первая угад цифра во второй половине
        {

            // маскируем вторую половину
            attempt = new int[4] { matchArray[1, 0], matchArray[1, 1], mask[2], mask[3] };
            if (Match(attempt, code) > 0)
            {
                // маскируем пераую цифру
                attempt = new int[4] { mask[0], matchArray[1, 1], mask[2], mask[3] };
                if (Match(attempt, code) > 0)
                {
                    // угпдага 2я цифра
                    answer[1] = matchArray[1, 1];
                    answMask += 0b0100;
                }
                else
                {
                    //угадана 1я цифра
                    answer[0] = matchArray[1, 0];
                    answMask += 0b1000;
                }


            }
            else    // совпадение в первой половине
            {

                // угадали 
                if (answMask == 0b0001)
                {
                    // раньше угадали 4ю цифру, теперь 3ю
                    answer[2] = matchArray[1, 2];
                    answMask += 0b0010;
                }
                else
                {
                    answer[3] = matchArray[1, 3];
                    answMask += 0b0001;
                }
            }
        }


        Console.WriteLine(String.Join(' ', answer));
        Console.WriteLine(Convert.ToString(answMask, 2));
        Console.WriteLine("attempts: " + tryCount);


        // ---------  3 -------------
        mask = GetMask(missMatchArray, GetRow(matchArray, 2));

        int t = answMask;
        int third=0, fourth=1, count=3;
        while(t>0)
        {
            if(t%2==0 && fourth==1) fourth = count;
            else if(t%2==0 && fourth!=1) third = count;
            count--;
            t/=2;
        }
        Console.WriteLine($"mask={Convert.ToString(answMask,2)}, th={third}, fr={fourth}");
        // маскируем third, проверяем fourth
        attempt = new int[4]{mask[0], mask[1], mask[2], mask[3]};
        attempt[fourth] = matchArray[2, fourth];
        // проверяемь
        if(Match(attempt, code)>0)
        {
            // fouth цифра правильная
            answer[fourth] = matchArray[2, fourth];
            // и оставшаяся
            answer[third] = matchArray[3, third];
        }
        else
        {
            // fouth цифра неправильная, занчит third - правильная
            answer[third] = matchArray[2, third];
            answer[fourth] = matchArray[3, fourth];
        }
        
        Console.WriteLine($"  код: {string.Join(' ', code)}");
        Console.WriteLine($"ответ: {string.Join(' ', answer)}");
        Console.WriteLine("attempts: " + tryCount);
    }

    static int[] GetRow(int[,] matrix, int row)
    {
        int[] redult = new int[matrix.GetLength(1)];
        if (row >= matrix.GetLength(0)) return redult;

        for (int i = 0; i < redult.Length; i++)
            redult[i] = matrix[row, i];
        return redult;
    }

    static int[] GetMask(int[,] mismatchArray, int[] attempt)
    {
        int[] mask = new int[attempt.Length];

        for (int row = 0; row < mismatchArray.GetLength(0); row++)
        {
            bool next = false;
            for (int i = 0; i < mismatchArray.GetLength(1); i++)
            {
                for (int j = 0; j < attempt.Length; j++)
                {
                    if (mismatchArray[row, i] == attempt[j])
                    {
                        next = true;
                        continue;
                    }
                }
                if (next) continue;
            }
            if (!next)
            {
                for (int i = 0; i < mismatchArray.GetLength(1); i++)
                    mask[i] = mismatchArray[row, i];
                return mask;
            }
        }
        return mask;
    }

    static void AddMatch(ref int[,] matchArray, int[] attempt)
    {
        int row = matchArray.GetLength(0);
        int clmn = matchArray.GetLength(1);
        int[,] result = new int[row + 1, clmn];
        for (int r = 0; r < row; r++)
            for (int c = 0; c < clmn; c++)
                result[r, c] = matchArray[r, c];

        for (int c = 0; c < clmn; c++)
            result[row, c] = attempt[c];

        matchArray = result;
    }

    static int Match(int[] attempt, int[] code)
    {
        tryCount++;
        int match = 0;
        for (int i = 0; i < code.Length; i++)
        {
            if (attempt[i] == code[i]) match++;
        }
        return match;
    }

    static int[] Generate()
    {
        Random rnd = new();
        int[] result = new int[4];
        result[0] = rnd.Next(10);
        while (true)
        {
            result[1] = rnd.Next(10);
            if (result[0] != result[1]) break;
        }
        while (true)
        {
            result[2] = rnd.Next(10);
            if (result[0] != result[2] &&
               result[1] != result[2]) break;
        }
        while (true)
        {
            result[3] = rnd.Next(10);
            if (result[0] != result[3] &&
               result[1] != result[3] &&
               result[2] != result[3]) break;
        }

        return result;
    }
}
