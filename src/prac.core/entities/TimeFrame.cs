using System;

namespace com.github.olo42.prac.core.entities
{
  public class TimeFrame
  {
    public TimeFrame(DateTime startDate, DateTime endDate)
    {
      this.Start = startDate;
      this.End = endDate;
    }

    public DateTime Start { get; }

    public DateTime End { get; }
  }
}