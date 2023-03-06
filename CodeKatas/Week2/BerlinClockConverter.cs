namespace CodeKatas.Week2;

public static class BerlinClockConverter
{
    public static BerlinClock ConvertDigitalTimeToBerlinClock(DateTime digitalTime)
    {
        var singleMinuteRow = new SingleMinuteRow(LampState.Off, LampState.Off, LampState.Off, LampState.Off);
        return new BerlinClock(singleMinuteRow);
    }
}