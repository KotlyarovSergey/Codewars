using System.Collections.Generic;
using System.Linq;

// 0, 8
// 1, 2, 4
// 2, 1, 3, 5
// 3, 2, 6
// 4, 1, 5, 7
// 5, 2, 4 , 6, 8
// 6, 3, 5, 9
// 7, 4, 8
// 8, 5, 7, 9 ,0
// 9, 6, 8

string code = "369";
// code = "13";
// code = "8";
List<string> allPIN = Kata.GetPINs(code);
Console.Write(string.Join(" ", allPIN));

