using System;

namespace prac.core.entities
{
  public class Appointment
  {
    public Appointment(DateTimeRange dateTimeRange, Resource resource)
    {
      this.DateTimeRange = dateTimeRange;
      this.Resource = resource;

    }
    public Resource Resource { get; }
    public DateTimeRange DateTimeRange { get; }
    public DateTime Start
    {
      get
      {
        return this.DateTimeRange.Min;
      }
    }
    public DateTime End
    {
      get
      {
        return this.DateTimeRange.Max;
      }
    }
  }
}