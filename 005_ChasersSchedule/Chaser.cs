using System;
using System.Linq;

namespace ChasersSchedule;

public class Chaser
{
	public static int SpeedAndTime(int s, int t)
	{
		char[] schedule = new char[t].Select(itm => itm = 'R').ToArray();
		int maxDistance = t * s;
		for (int i = schedule.Length - 1; i >= 0; i -= 2)
		{
			schedule[i] = 'S';
			int distance = 0;
			int speed = s;
			foreach (char c in schedule)
			{
				if (c == 'R') distance += speed;
				if (c == 'S')
				{
					distance += speed * 2;
					speed--;
					if (speed == 0) break;
				}
			}
			if (distance > maxDistance) maxDistance = distance;
			else break;
		}
		return maxDistance;
	}
}