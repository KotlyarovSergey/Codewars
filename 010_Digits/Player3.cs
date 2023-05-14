public class Player3
{
    // static int[] answer;
    static int steps;
    static int[] existsDigits;      // цифры, которые есть в коде
    static int absentDigit;         // цифра, котроой нет в коде
    static int number;
    static int position;
    static int[] code;
    // static int enter = 1;

    public static int[] TryToGuess(int matches)
    {
        //Console.WriteLine("\n  enter: " + (enter) );
        // enter++;

        // first enter. initialisation
        if (matches == -1)
        {
            number = -1;
            steps = 1;
            existsDigits = new int[0];
            absentDigit = -1;
            position = 0;
            // checkedPosition = -1;
            code = new int[4] { -1, -1, -1, -1 };
            // missmatchIndex = new int[2];
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
                // answer = new int[4].Select(x => x = number).ToArray();
                //Console.WriteLine("Check {0}", number);
                return new int[4].Select(x => x = number).ToArray();
            }
        }

        if (steps == 2)
        {
            // Console.WriteLine("Step: " + steps);
            number = 0;     // очередное число в existsDigits 
            position = 0;   // позиция в code
            steps++;
            // Console.WriteLine("  -----  Начинаем -----");
            //Console.WriteLine(">> Посылаем: " + string.Join(' ', new int[] { existsDigits[number], absentDigit, absentDigit, absentDigit}));
            return new int[] { existsDigits[number], absentDigit, absentDigit, absentDigit };
        }

        if (steps == 3) // проверяем по кругу все existsDigits
        {
            //Console.WriteLine($"match: {matches}, pos: {position}, number: {number}, exists: {string.Join(' ', existsDigits)}");
            if (matches == 1)  // угадали
            {
                // Console.WriteLine($"Угадали! pos: {position}, number: {number}, exists: {string.Join(' ', existsDigits)}");
                // вписать угаданную цифру в code
                code[position] = existsDigits[number];
                // удалить цифру из existsDigits
                existsDigits = existsDigits.Where((x, ind) => ind != number).ToArray();
                // увеличить position
                position++;
                // обнулить number(index в existsDigits)
                number = 0;
                // если в existsDigits осталась всего одна цифра и/или position == 3
                if (position == 3)
                {
                    // вписать ее в последнюю цифру кода
                    code[position] = existsDigits[number];
                    // конец
                    return code;
                }

                // послать новый пример на проверку
                int[] answer = new int[] { absentDigit, absentDigit, absentDigit, absentDigit };
                answer[position] = existsDigits[number];
                // Console.WriteLine(">> Посылаем: " + string.Join(' ', answer));
                return answer;
            }
            else    // если не угадали
            {
                // Console.WriteLine($"Не Угадали! pos: {position}, number: {number}, exists: {string.Join(' ', existsDigits)}");
                // увеличить number(index в existsDigits)
                number++;
                // если следующая цифра не последняя
                // if (number < existsDigits.Length - 1)
                // {
                    // взять следующую цифру из existsDigits

                    // послать новый пример на проверку
                // }
                if (number == existsDigits.Length - 1) // если последняя осталась  
                {
                                // Console.WriteLine("  === Было code: " + string.Join(' ', code));
                    // вписать ее по умолчанию
                    code[position] = existsDigits[number];
                                // Console.WriteLine("  === Стало code: " + string.Join(' ', code));
                    // удалить из списка existsDigits
                    existsDigits = existsDigits.Where((x, ind) => ind != number).ToArray();

                    position++; // номер искомой цифры code[position]
                    number = 0; // начинаем перебирать сначала в existsDigits
                    // если в existsDigits осталась всего одна цифра и/или position == 3
                    if (position == 3)
                    {
                        // вписать ее в последнюю цифру кода
                        code[position] = existsDigits[0];
                        // конец
                        return code;
                    }
                    // отправить на проверку
                }
                int[] answer = new int[] { absentDigit, absentDigit, absentDigit, absentDigit };
                // Console.WriteLine("code: " + string.Join(' ', code));
                // Console.WriteLine($"Pos: {position}, number: {number}");
                // Console.WriteLine("exist: " + string.Join(' ', existsDigits));
                answer[position] = existsDigits[number];
                // Console.WriteLine(">> Посылаем: " + string.Join(' ', answer));
                return answer;
            }












            //int[] answer = new int[4].Select(x => x=absentDigit).ToArray();
            // int[] answer = new int[]{absentDigit,absentDigit,absentDigit,absentDigit};
            // answer[position] = existsDigits[number];
            // return answer;

            /*
            // если угаданы 3 цифры, 4-ю пишем по остатку
            Console.WriteLine("Step: " + steps);
            if (matches == 0)
            {
                // если осталась одна цифра можно ее не угадывать
                Console.WriteLine("Matches: " + matches + ", number: " + number + ", position:" + position);
                if (number >= existsDigits.Length - 2)
                {
                    code[position] = existsDigits[number + 1];
                    Console.WriteLine(string.Join(' ', code));
                    // existsDigits = RemoveAt(existsDigits, number);
                    existsDigits = existsDigits.Where((val, idx) => idx != number).ToArray();
                    position++;
                    number = 0;
                    
                    // посылаем следующую
                    int[] arr = new int[] { absentDigit, absentDigit, absentDigit, absentDigit };
                    arr[position] = existsDigits[number];
                    return arr;

                }
                else
                {
                    number++;
                    int[] arr = new int[] { absentDigit, absentDigit, absentDigit, absentDigit };
                    arr[position] = existsDigits[number];
                    return arr;
                }
            }
            else    // если угадали
            {
                Console.WriteLine($"Угадали {position}-ю цифру");
                code[position] = existsDigits[number];
                Console.WriteLine(string.Join(' ', code));
                // надо удалить угаданную цифру
                // existsDigits = RemoveAt(existsDigits, number);
                existsDigits = existsDigits.Where((val, idx) => idx != number).ToArray();
                position++;
                number = 0;

            }
            */
            //steps++;
            // answer = new int[] { exists[0], exists[0], missing, missing };

        }
        return new int[] { 0, 0, 0, 0 };
    }

    // private static int[] RemoveAt(int[] array, int index)
    // {
    //     int[] result = new int[array.Length-1];
    //     int j = 0;
    //     for (int i = 0; i < array.Length; i++, j++)
    //     {
    //         if(i==index) i++;
    //         result[j] = array[i];
    //     }
    //     return result;
    // }
}