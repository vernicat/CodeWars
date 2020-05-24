public static class TimeFormat
{
    public static string num(int val)
    {
        return val < 10 ? '0' + val.ToString() : val.ToString();
    }
    public static string GetReadableTime(int seconds)
    {
        int hours = seconds / 3600;
        int minuts = ( seconds / 60 ) - ( hours * 60 );
        seconds = seconds - ( hours * 3600 ) - ( minuts * 60 );

        return num(hours)+":"+num(minuts)+":"+num(seconds);
    }
}