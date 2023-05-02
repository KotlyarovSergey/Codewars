using System;
using System.Linq;

namespace ChasersSchedule;

public class Schedule2
{
    int speedBase;
    int time;
    public int maxDistance;
    public char[] bestSchedule;

    public Schedule2(int speed, int time)
    {
        this.speedBase = speed;
        this.time = time;
        this.maxDistance = 0;
        //this.bestSchedule = new char[time]('S');
        this.bestSchedule = new char[time].Select(itm => itm = 'R').ToArray();
    }

    public int Distance()
    {
        char[] schedule = new char[time].Select(itm => itm = 'R').ToArray();
        //Console.WriteLine(new string(schedule));
        int distance = Calculate(schedule);
        this.maxDistance = distance;
        
		for (int i = schedule.Length-1; i >= 0; i-=2)
        {
            schedule[i] = 'S';
			distance = Calculate(schedule);
			if(distance > maxDistance)
			{
				maxDistance = distance;
				schedule.CopyTo(bestSchedule, 0);
			}
			else
				break;
        }
        return maxDistance;
    }
	
	/*
    private void NextSched(ref char[] input)
    {
        int last = input.Length - 1;
        if (input[last] == 'R') input[last] = 'S';
        else
        {
            input[last] = 'R';
            HightBit(ref input, last - 1);
        }
    }
	*/
	/*
    private void HightBit(ref char[] input, int bit)
    {
        if (input[bit] == 'R') input[bit] = 'S';
        else
        {
            input[bit] = 'R';
            if (bit > 0) HightBit(ref input, bit - 1);
        }
    }
	*/
	
    private int Calculate(char[] schedule)
    {
        int dist = 0;
		int speed = this.speedBase;
        //string sched = Convert.ToString(shedule, 2);
        //int addit = time - sched.Length;
        //if (addit > 0) sched = new String('0', addit) + sched;
        //Console.WriteLine(sched);
        foreach (Char c in schedule)
        {
			
            if (c == 'R') dist += speed;
            if (c == 'S')
            {
                dist += speed * 2;
                speed--;
				if(speed == 0) break;
            }
			// Console.Write(dist + " ");
        }
        // Console.WriteLine(new string(schedule) + " " + dist);

        return dist;
    }
	/*
    private bool Check(char[] schedule)
    {
		for(int i = 0; i < schedule.Length - 1; i++)
		{
			if(schedule[i] == 'S' && schedule[i+1] == 'S')
				return false;
		}
        return true;
    }
	*/
}