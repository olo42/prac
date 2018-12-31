using System;

namespace prac.core.entities
{
  public class DateTimeRange : Range<DateTime>, IEquatable<DateTimeRange>
  {

    public DateTimeRange(DateTime min, DateTime max) : base(min, max) { }
    
    public bool Equals(DateTimeRange other)
    {
      return this.Min == other.Min &&
        this.Max == other.Max;
    }
  }
}