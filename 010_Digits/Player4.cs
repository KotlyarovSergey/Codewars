public class Player4
{
    static int steps;
    static int[] existsDigits;      // the numbers that are in the code
    static int absentDigit;         // a number that is not in the code
    static int number;
    static int position;
    static int[] code;

    public static int[] TryToGuess(int matches)
    {
        // first enter. initialisation
        if (matches == -1)
        {
            number = -1;
            steps = 1;
            existsDigits = new int[0];
            absentDigit = -1;
            position = 0;
            code = new int[4] { -1, -1, -1, -1 };
        }
        if (steps == 1) // looking all exists digits and one missing
        {
            // if sending digit exist in conde, add it in "exists" array
            if (matches == 1) existsDigits = existsDigits.Append(number).ToArray();
            else if (absentDigit == -1 && matches == 0) absentDigit = number;

            // if finded all 4 digits and absentDigit, moving on to next step
            if (existsDigits.Length == 4 && absentDigit != -1)
            {
                steps++;
            }
            else    // send next digit on checking
            {
                number++;
                return new int[4].Select(x => x = number).ToArray();
            }
        }

        if (steps == 2)
        {
            number = 0;     // очередное число в existsDigits 
            position = 0;   // позиция в code
            steps++;
            return new int[] { existsDigits[number], absentDigit, absentDigit, absentDigit };
        }

        if (steps == 3) // проверяем по кругу все existsDigits
        {
            if (matches == 1)  // угадали
            {
                code[position] = existsDigits[number];
                existsDigits = existsDigits.Where((x, ind) => ind != number).ToArray();
                position++;
                number = 0;
                if (position == 3)
                {
                    code[position] = existsDigits[number];
                    return code;
                }

                int[] answer = new int[] { absentDigit, absentDigit, absentDigit, absentDigit };
                answer[position] = existsDigits[number];
                return answer;
            }
            else    // если не угадали
            {
                number++;
                if (number == existsDigits.Length - 1) // если последняя осталась  
                {
                    code[position] = existsDigits[number];
                    existsDigits = existsDigits.Where((x, ind) => ind != number).ToArray();

                    position++; // номер искомой цифры code[position]
                    number = 0; // начинаем перебирать сначала в existsDigits
                    // если в existsDigits осталась всего одна цифра и/или position == 3
                    if (position == 3)
                    {
                        code[position] = existsDigits[0];
                        return code;
                    }
                }
                int[] answer = new int[] { absentDigit, absentDigit, absentDigit, absentDigit };
                answer[position] = existsDigits[number];
                return answer;
            }
        }
        // return new int[] { 0, 0, 0, 0 };
        return new int[] { 1,2, 3, 4 };
    }
}