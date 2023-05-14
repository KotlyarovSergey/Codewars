// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

HRT();
IntToIP();



void HRT()
{
    int min = 5000000;
    Console.WriteLine(min.ToString("0 000"));


    int t = 5 * 3600 + 2 * 60 + 15;
    Console.WriteLine(HumanReadableTime.GetReadableTime(t));

    Console.WriteLine(HumanReadableTime.GetReadableTime(60));
    Console.WriteLine(HumanReadableTime.GetReadableTime(3600));
}

void IntToIP()
{
    Console.WriteLine(Int32ToIPv4.UInt32ToIP(178364215));
    Console.WriteLine(Int32ToIPv4.UInt32ToIP(256));
    Console.WriteLine(Int32ToIPv4.UInt32ToIP(256 * 256 + 256));
}