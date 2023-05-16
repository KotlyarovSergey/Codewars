// https://www.codewars.com/kata/52685f7382004e774f0001f7
class HumanReadableTime
{
    public static string GetReadableTime(int seconds)
    {
        return string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, seconds / 60 % 60, seconds % 60);
    }

	public static string Time(int seconds)
	{
		int sec = seconds % 60;
		int min = (seconds / 60) % 60;
		int hour = seconds / 3600;

		string time = (hour < 10) ? "0" + hour : "" + hour;
		time = min < 10 ? time + ":0" + min : time + ":" + min;
		time = sec < 10 ? time + ":0" + sec : time + ":" + sec;
		return time;
	}

    public static string Time2(int seconds)
	{
		int sec = seconds % 60;
		int min = (seconds / 60) % 60;
		int hour = seconds / 3600;

		return string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
	}
}