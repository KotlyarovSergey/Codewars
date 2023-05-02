using System;
using System.Linq;
using ChasersSchedule;
//namespace ChasersSchedule;

const int speed = 28;  // скорость
const int time = 20;   // интервалы времени

int maxDist = 0;

/*
for (int i = 0; i < (1 << time); i++)
{
    //Console.WriteLine(Convert.ToString(i, 2));
    if (Check(i, time))
    {
        //Console.WriteLine(Convert.ToString(i, 2));
        //Console.WriteLine(String.Format("{0:x4}", i));
        int distance = Diastance(speed, time, i);
        if (maxDist < distance) maxDist = distance;
    }
}
Console.WriteLine("way 1: " + maxDist);
*/

// Schedule sch = new Schedule(speed, time);
// int dist = sch.Distance();
// Console.WriteLine("way 2: " + "speed: " + speed + ", time: " + time + " " + new String(sch.bestSchedule) + " " + dist);


Schedule2 sch2 = new Schedule2(speed, time);
maxDist = sch2.Distance();
Console.WriteLine("way 3: " + "speed: " + speed + ", time: " + time + ", distance: " + maxDist);

maxDist = Chaser.SpeedAndTime(speed, time);
Console.WriteLine("way 4 (release): " + "speed: " + speed + ", time: " + time + ", distance: " + maxDist);


/*
static bool Check(int num, int digits)
{
    if (digits == 1) return true;
    //int template = 0b11;
    int template = 3;
    for (int i = 0; i < digits; i++)
    {
        int mask = template << i;
        //Console.WriteLine(Convert.ToString(mask, 2));

        if ((num & mask) == mask) return false;
    }
    return true;
}
*/
/*
static int Diastance(int speed, int time, int shedule)
{
    int dist = 0;

    string sched = Convert.ToString(shedule, 2);
    int addit = time - sched.Length;
    if (addit > 0) sched = new String('0', addit) + sched;
    //Console.WriteLine(sched);
    foreach (Char c in sched)
    {
        if (c == '0') dist += speed;
        if (c == '1')
        {
            dist += speed * 2;
            speed--;
        }

    }
    //Console.WriteLine(sched + " " + dist);

    return dist;
}
*/