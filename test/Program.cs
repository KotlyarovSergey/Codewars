// string sentence = {"Маша", "Паша", "Миша", "Оля", "Игорь", "Юля", "Геннадий"};
// string[] wrds = new string[] {"Маша", "Паша", "Миша", "Оля", "Игорь", "Юля", "Геннадий"};
//  var reversedWords = wrds.Select(word => word.Length >= 5 ? string.Concat(word.Reverse()) : word);
// Console.WriteLine(string.Join(" ", reversedWords));
// return;

string[] words = new string[] { "Маша", "Паша", "Миша", "Оля", "Игорь", "Юля", "Геннадий" };
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

int[] array = new int[] { 1, 6, 4, 1, 7, 1, 5, 2, 9 };
int[] a1 = array.Where(x => x > 4).ToArray();
Console.WriteLine(string.Join(' ', a1));


a1 = a1.Append(10).ToArray();
Console.WriteLine(string.Join(' ', a1));

// удалить элемент по индексу
a1 = array.Where((val, idx) => idx != 3).ToArray();
Console.WriteLine(string.Join(' ', a1));