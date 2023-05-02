// string sentence = {"Маша", "Паша", "Миша", "Оля", "Игорь", "Юля", "Геннадий"};
// string[] wrds = new string[] {"Маша", "Паша", "Миша", "Оля", "Игорь", "Юля", "Геннадий"};
//  var reversedWords = wrds.Select(word => word.Length >= 5 ? string.Concat(word.Reverse()) : word);
// Console.WriteLine(string.Join(" ", reversedWords));
// return;

string[] words = new string[] {"Маша", "Паша", "Миша", "Оля", "Игорь", "Юля", "Геннадий"};
var nW = words.Select(s => s = (s.Length > 4) ? "---" : s);
//var nW = words.Select(s => s[1] + s[3]);
Console.WriteLine(string.Join(" ", nW));

string[] arr = nW.ToArray();
Console.WriteLine(string.Join(" ", arr));

IEnumerable<int> nI = words.Select(s => s.Length);
foreach (var result in nI)
{
    Console.WriteLine(result);
}


// return;

// string[] greetings = new string[] { "hi", "hello", "hey", "howdy" };

// var results = greetings.Select(
//     s => s[0].ToString().ToUpper() + s.Substring(1)
// );

// foreach (var result in results)
// {
//     Console.WriteLine(result);
// }