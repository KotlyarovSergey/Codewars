using System.Collections.Generic;
using System.Linq;
using System;

Console.WriteLine(Kata.SpinWords("Each time you complete a kata you will be shown the solution of other Code warriors"));

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string[] list = sentence.Split();
    for(int i = 0; i< list.Length; i++)
    {
        if(list[i].Length >= 5)
            list[i] = Reverse(list[i]);
    }

    return String.Join(" ", list);
  }
  static string Reverse(string input)
  {
    string result = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        result = input[i] + result;
    }
    return result;
  }
}


