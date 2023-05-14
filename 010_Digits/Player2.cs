public class Player2
{
    static int[] answer;
    static int send;
    static int steps;
    static int[] exists;       // цифры, которые есть в коде
    static int missing;        // цифра, котроой нет в коде
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
            checkedPosition = -1;
            code = new int[4] { -1, -1, -1, -1 };
            missmatchIndex = new int[2];
        }

        if (steps == 1) // looking all exists digits and one missing
        {
            // if sending digit exist in conde, add it in "exists" array
            if (matches == 1) exists = exists.Append(send).ToArray();
            else if (missing == -1 && matches == 0) missing = send;

            // if finded all 4 digits, moving on to next step
            // if (exists.Length == 4 && mask != null)
            if (exists.Length == 4 && missing != -1) steps++;
            else    // send next digit on checking
            {
                send++;
                answer = new int[4].Select(x => x = send).ToArray();
            }
        }
        if (steps == 2) // send half code on checking
        {
            answer = new int[] { exists[0], exists[0], missing, missing };
            steps++;
        }
        else if (steps == 3 || steps == 5) // 12й заход
        {
            int pos = (steps == 3) ? 0 : 1;

            if (matches > 0) // совпадение в первой половине
            {
                answer = new int[] { exists[pos], missing, missing, missing };
                checkedPosition = 0;
            }
            else    // совпадание во второй половине
            {
                answer = new int[] { missing, missing, exists[pos], missing };
                checkedPosition = 2;
            }
            steps++;
        }
        else if (steps == 4 || steps == 6) // 13й заход
        {
            int pos = (steps == 4) ? 0 : 1;

            if (matches > 0) // совпадение 1 или 3
                code[checkedPosition] = exists[pos];
            else // совпадение 2 или 4
                code[checkedPosition + 1] = exists[pos];

            // send half code on checking again
            if(steps == 4) answer = new int[] { exists[1], exists[1], missing, missing };
            steps++;
        }
         if (steps == 7) // 
        {
            // найти инедксы оставшихся 2х неугаданных цифр
            int j = 0;
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == -1)
                {
                    missmatchIndex[j] = i;
                    j++;
                }
            }
            // проверить 3ю возможную цифру на одной из позиций
            answer = new int[] { missing, missing, missing, missing };
            answer[missmatchIndex[0]] = exists[2];
            steps++;
        }
        else if (steps == 8)
        {
            // послали в прошлый раз на проверку цифру exists[2] на позиции matchIndex[0]
            // проверяем результат
            if (matches > 0)
            {
                code[missmatchIndex[0]] = exists[2];
                code[missmatchIndex[1]] = exists[3];
            }
            else
            {
                code[missmatchIndex[0]] = exists[3];
                code[missmatchIndex[1]] = exists[2];
            }
            return code;
        }
        return answer;
    }
}