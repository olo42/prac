using System;

namespace prac.core.entities
{
  public class TimeFrame : IEquatable<TimeFrame> 
  {
    public TimeFrame(DateTime startDate, DateTime endDate)
    {
      this.Start = startDate;
      this.End = endDate;
    }

    public DateTime Start { get; }

    public DateTime End { get; }

    public bool Equals(TimeFrame other)
    {
      return this.Start == other.Start
        && this.End == other.End;
    }
  }
}