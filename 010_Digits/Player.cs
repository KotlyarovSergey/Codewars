public class Player
{
    static int[] answer;
    static int send;
    static int steps;
    static int[] exists;       // цифры, которые встречаются в коде
    static int missing;        // цифра, котроой нет в коде
    // static int matchBin;
    static int[] missmatchIndex;
    static int checkedPosition;    // проверяемая цифра
    static int[] code;

    public static int[] TryToGuess(int matches)
    {
        // first pass
        if (matches == -1)
        {
            send = -1;
            steps = 1;
            exists = new int[0];
            missing = -1;
            // matchBin = 0;
            checkedPosition = -1;
            code = new int[4] { -1, -1, -1, -1 };
            missmatchIndex = new int[2];
        }


        if (steps == 1) // looking all exists digits
        {
            Console.WriteLine("steps: " + steps);
            // if sending digit exist in conde, add it in "exists" array
            if (matches == 1)
            {
                int[] na = new int[exists.Length + 1];
                exists.CopyTo(na, 0);
                na[exists.Length] = send;
                exists = na;
            }

            // if (mask == null && matches == 0)
            if (missing == -1 && matches == 0)
            {
                //mask = new int[4].Select(x => x = send).ToArray();
                missing = send;
            }

            // if finded all 4 digits, moving on to next step
            // if (exists.Length == 4 && mask != null)
            if (exists.Length == 4 && missing != -1)
            {
                steps++;
                // Console.WriteLine($"steps {steps}");
            }
            else    // send next digit on checking
            {
                send++;
                answer = new int[4].Select(x => x = send).ToArray();
            }

        }
        if (steps == 2) // 11й заход
        {
            Console.WriteLine("steps: " + steps);
            // Console.WriteLine("exist: " + string.Join(' ', exists));
            // Console.WriteLine("mask: " + string.Join(' ', mask));
            answer = new int[] { exists[0], exists[0], missing, missing };
            //Console.WriteLine("answer: " + string.Join(' ', answer));
            steps++;
        }
        else if (steps == 3) // 12й заход
        {
            Console.WriteLine("steps: " + steps);
            if (matches > 0) // совпадение в первой половине
            {
                answer = new int[] { exists[0], missing, missing, missing };
                checkedPosition = 0;
                // Console.WriteLine("checkedDigit: " + string.Join(' ', checkedDigit));
            }
            else    // совпадание во второй половине
            {
                answer = new int[] { missing, missing, exists[0], missing };
                checkedPosition = 2;

            }
            steps++;
        }
        else if (steps == 4) // 13й заход
        {
            Console.WriteLine("steps: " + steps);
            if (matches > 0) // совпадение 1 или 3
            {
                code[checkedPosition] = exists[0];
            }
            else // совпадение 2 или 4
            {
                code[checkedPosition + 1] = exists[0];
            }
            // steps++;
            Console.WriteLine("code: " + string.Join(' ', code));

            answer = new int[] { exists[1], exists[1], missing, missing };
            steps++;
        }

        else if (steps == 5) // 
        {
            Console.WriteLine("steps: " + steps);
            if (matches > 0) // совпадение в первой половине
            {
                answer = new int[] { exists[1], missing, missing, missing };
                checkedPosition = 0;
                // Console.WriteLine("checkedDigit: " + string.Join(' ', checkedDigit));
            }
            else    // совпадание во второй половине
            {
                answer = new int[] { missing, missing, exists[1], missing };
                checkedPosition = 2;
                // Console.WriteLine("checkedDigit: " + string.Join(' ', checkedDigit));
            }
            steps++;
        }
        else if (steps == 6) // 
        {
            Console.WriteLine("steps: " + steps);
            if (matches > 0) // совпадение 1 или 3
            {
                code[checkedPosition] = exists[1];
            }
            else // совпадение 2 или 4
            {
                code[checkedPosition + 1] = exists[1];
            }
            Console.WriteLine("code: " + string.Join(' ', code));

            steps++;
        }
        if (steps == 7) // 
        {
            Console.WriteLine("steps: " + steps);
            // найти инедксы оставшихся 2х неугаданных цифр
            int j = 0;
            for (int i = 0; i < code.Length; i++)
            {
                // if(code[i]!=-1) matchBin+= 1<<(3-i);
                if(code[i]==-1) 
                {
                    missmatchIndex[j] = i;
                    j++;
                }
            }
            // Console.WriteLine("matchBin: " + Convert.ToString(matchBin, 2));
            Console.WriteLine("matchIndex: " + string.Join(' ', missmatchIndex));

            // matchIndex = code.Where(x => x!=-1).ToArray();
            // Console.WriteLine("matchIndex: " + string.Join(' ', matchIndex));

            // проверить одну
            checkedPosition = missmatchIndex[0];
            answer = new int[] { missing, missing, missing, missing };
            answer[checkedPosition] = exists[2];
            
            // другую записать из оставшейся

            steps++;
        }
        else if (steps == 8)
        {
            // послали в прошлый раз на проверку цифру exists[2] на позиции matchIndex[0]
            // проверяем результат
            if(matches>0)
            {
                code[missmatchIndex[0]] = exists[2];
                code[missmatchIndex[1]] = exists[3];
            }
            else
            {
                code[missmatchIndex[0]] = exists[3];
                code[missmatchIndex[1]] = exists[2];
            }
            Console.WriteLine("code: " + string.Join(' ', code));
            return code;
        }

        // Console.WriteLine("answer: " + string.Join(' ', answer));
        return answer;
        // return new int[] { 4, 9, 3, 2 };
    }

}