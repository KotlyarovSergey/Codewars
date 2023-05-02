List<Object> listOfItems = new List<object> { 1, 3, 3, "gf", 5, "jhg", 6 };

// 1.
List<int> nl = new List<int>();
foreach (object ob in listOfItems)
{
    if (ob.GetType() == typeof(int))
        nl.Add((int)ob);
}
Console.WriteLine(string.Join(' ', nl));

// 2.
IEnumerable<int> ieInt =
        from obj in listOfItems
        where obj.GetType() == typeof(int)
        select (int)obj;

Console.WriteLine(string.Join(' ', ieInt));

// 3.
IEnumerable<int> ieInt2 = listOfItems.OfType<int>();
Console.WriteLine(string.Join(' ', ieInt2));
