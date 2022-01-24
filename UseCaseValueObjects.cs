namespace Records;

using System;
using Shouldly;
using Xunit;

public class UseCaseValueObjects
{
    // YOINK! https://github.com/ardalis/pluralsight-ddd-fundamentals/blob/main/SharedKernel/src/PluralsightDdd.SharedKernel/DateTimeRange.cs
    public readonly record struct DateTimeRange
    {
        public DateTimeRange(DateTime start, TimeSpan duration) : this(start, start.Add(duration)) { }

        public DateTimeRange(DateTime start, DateTime end)
        {
            if (end - start <= TimeSpan.Zero) { throw new ArgumentOutOfRangeException(nameof(start)); }

            Start = start;
            End = end;
        }

        public DateTime Start { get; }
        public DateTime End { get; }

        public int DurationInMinutes() => (int)Math.Round((End - Start).TotalMinutes, 0);

        public DateTimeRange NewDuration(TimeSpan newDuration) => new(Start, newDuration);

        public DateTimeRange NewEnd(DateTime newEnd) => new(Start, newEnd);

        public DateTimeRange NewStart(DateTime newStart) => new(newStart, End);

        public static DateTimeRange CreateOneDayRange(DateTime day) => new(day, day.AddDays(1));

        public static DateTimeRange CreateOneWeekRange(DateTime startDay) => new(startDay, startDay.AddDays(7));

        public bool Overlaps(DateTimeRange dateTimeRange) =>
            Start < dateTimeRange.End &&
            End > dateTimeRange.Start;


    }

    [Fact]
    public void Eq()
    {
        var today = DateTime.Today;
        var tomorrow = today.AddDays(1);
        new DateTimeRange(today, tomorrow).ShouldBe(new(today, tomorrow));
    }

}