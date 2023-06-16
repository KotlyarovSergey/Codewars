using System;
using System.Collections.Generic;
class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        List<string> result = new List<string>();
        char[] charSet = s.ToCharArray();
        Array.Sort(charSet);
        result.Add(new string(charSet));
        while(Next(charSet))
        {
            result.Add(new string(charSet));
        }
        
        return result;
    }

    static bool Next(char[] array)
	{
		int last = array.Length - 1;
		// 1. i - самый правый элемент, у который меньше следющего
		int i = last - 1;
		while (i >= 0)
		{
			if (array[i] < array[i + 1])
			{
				break;
			}
			i--;
		}
		if (i < 0) return false; // максимальная перестановка

		// 2.   j - самый минимальный справа, кторый больше array[i]
		// 2.1. сначала найдём первый больший i
		int j = last;
		while (j > i)
		{
			if (array[j] > array[i]) break;
			j--;
		}
		// 2.2 дальше ищем минимальный из больших i
		int minLargeIndex = j;
		while (j > i)
		{
			if (array[j] < array[i] && array[j] < array[minLargeIndex]) minLargeIndex = j;
			j--;
		}

		// 3. меняем местами i и minLargeIndex
		(array[i], array[minLargeIndex]) = (array[minLargeIndex], array[i]);

		// 4. разворачиваем хвост
		Array.Reverse(array, i + 1, last - i);

		return true;
	}
}

