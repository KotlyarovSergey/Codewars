using System.Collections.Generic;
using System.Data;

// string s = "abcd";
string s = "abccabdefgh";


DateTime dtStart = DateTime.Now;
List<string> all = Permutations.SinglePermutations(s);
DateTime dtEnd = DateTime.Now;
TimeSpan ts = dtEnd - dtStart;
Console.WriteLine($"My:    {s}: {all.Count} {(int)ts.TotalMilliseconds}ms");


dtStart = DateTime.Now;
all = Permutations1.SinglePermutations(s);
// dtEnd = DateTime.Now;
ts = DateTime.Now - dtStart;
Console.WriteLine($"Cdwr1: {s}: {all.Count} {(int)ts.TotalMilliseconds}ms");


dtStart = DateTime.Now;
all = Permutations2.SinglePermutations(s);
// dtEnd = DateTime.Now;
ts = DateTime.Now - dtStart;
Console.WriteLine($"Cdwr2: {s}: {all.Count} {(int)ts.TotalMilliseconds}ms");