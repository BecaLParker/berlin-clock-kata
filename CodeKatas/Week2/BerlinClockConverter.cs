namespace CodeKatas.Week2;

public static class BerlinClockConverter
{
    public static BerlinClock ConvertDigitalTimeToBerlinClock(DateTime digitalTime)
    {
        var minutes = digitalTime.Minute;
        var remainder = minutes % 5;
        
        var singleMinuteRow = new SingleMinuteRow(
            remainder == 0 ? LampState.Off : LampState.Yellow,
            remainder <= 1 ? LampState.Off : LampState.Yellow,
            remainder <= 2 ? LampState.Off : LampState.Yellow,
            remainder <= 3 ? LampState.Off : LampState.Yellow);
        
        return new BerlinClock(singleMinuteRow);
    }
}