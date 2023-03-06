using CodeKatas.Week2;
using FluentAssertions;

namespace CodeKatas.Test;

public class UnitTestWeek2
{
    [TestCase(0,0,0, LampState.Off, LampState.Off, LampState.Off, LampState.Off)]
    [TestCase(23,59,59, LampState.Yellow, LampState.Yellow, LampState.Yellow, LampState.Yellow)]
    [TestCase(12,32,0, LampState.Yellow, LampState.Yellow, LampState.Off, LampState.Off)]
    [TestCase(12,34,0, LampState.Yellow, LampState.Yellow, LampState.Yellow, LampState.Yellow)]
    [TestCase(12,35,0, LampState.Off, LampState.Off, LampState.Off, LampState.Off)]
    public void DigitalTimeToBerlinClock_SingleMinuteRow_Success(int hour, int minutes, int seconds, LampState expectedFirst, LampState expectedSecond, LampState expectedThird, LampState expectedFourth)
    {
        var digitalTime = new DateTime(2023, 3, 6, hour, minutes, seconds);

        var resultBerlinClock = BerlinClockConverter.ConvertDigitalTimeToBerlinClock(digitalTime);

        var expectedSingleMinuteRow = new SingleMinuteRow(expectedFirst, expectedSecond, expectedThird, expectedFourth);

        resultBerlinClock._singleMinuteRow.Should().BeEquivalentTo(expectedSingleMinuteRow);
    }
}