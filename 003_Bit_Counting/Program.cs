int CountBits(int n)
{
    int res = 0;
    string s = string.Empty;
    while(n > 0)
    {
        int bite = n % 2;
        s = bite.ToString() + s;
        res += bite;
        n /= 2;
    }
    Console.WriteLine(s);
    return res;
}


int num = 123;
Console.WriteLine(CountBits(num));

//string s = "ddfdf";
Console.WriteLine(Convert.ToString(num, 2));
// num = s.Count()

