
string ShowMatrix(char[,] matrix)
{
    string stringRepresentation = "{\n";

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        stringRepresentation += "  { ";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            stringRepresentation += matrix[i, j] + " ";
        }
        stringRepresentation += "}\n";
    }
    stringRepresentation += "}";

    return stringRepresentation;
}

// Should be able to sort 3 liquids
char[,] actual = Kata.SeparateLiquids2(new char[,] { { 'H', 'H', 'W', 'O' }, { 'W','W','O','W' }, { 'H','H','O','O' } });
char[,] expected = new char[,] { { 'O', 'O', 'O', 'O' }, { 'W','W','W','W' }, { 'H','H','H','H' } };
Console.WriteLine(ShowMatrix(actual));
Console.WriteLine(ShowMatrix(expected));
Console.WriteLine();

// Should be able to sort 4 liquids
actual = Kata.SeparateLiquids2(new char[,] { { 'A','A','O','H' }, { 'A','H','W','O' }, { 'W','W','A','W' }, { 'H','H','O','O' } });
expected = new char[,] { { 'O','O','O','O' }, { 'A','A','A','A' }, { 'W','W','W','W' }, { 'H','H','H','H'} };
Console.WriteLine(ShowMatrix(actual));
Console.WriteLine(ShowMatrix(expected));
Console.WriteLine();

// Should be able to handle one row
actual = Kata.SeparateLiquids2(new char[,] { { 'A','H','W','O' } });
expected = new char[,] { { 'O','A','W','H' } };
Console.WriteLine(ShowMatrix(actual));
Console.WriteLine(ShowMatrix(expected));
Console.WriteLine();


// Should be able to handle one column
actual = Kata.SeparateLiquids2(new char[,] { { 'A' }, { 'H' }, { 'W' }, { 'O' } });
expected = new char[,] { { 'O' }, { 'A' }, { 'W' }, { 'H' } };
Console.WriteLine(ShowMatrix(actual));
Console.WriteLine(ShowMatrix(expected));
Console.WriteLine();


// Should be able to handle empty array
actual = Kata.SeparateLiquids2(new char[,] { });
expected = new char[,] { };
Console.WriteLine(ShowMatrix(actual));
Console.WriteLine(ShowMatrix(expected));
Console.WriteLine();

actual = new char[,] { { 'A', 'O', 'W', 'O' }, { 'W','O','A','W' }, { 'O','O','A','W' } };
Console.WriteLine(ShowMatrix(actual));
actual = Kata.SeparateLiquids2(actual);
Console.WriteLine(ShowMatrix(actual));

