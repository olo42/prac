using System;

namespace com.github.olo42.prac.core.entities
{
  public class Appointment
  {
    public Appointment(TimeFrame timeFrame, Resource resource)
    {
      this.TimeFrame = timeFrame;
      this.Resource = resource;

    }
    public Resource Resource { get; }
    public TimeFrame TimeFrame { get; }
    public DateTime Start
    {
      get
      {
        return this.TimeFrame.Start;
      }
    }
    public DateTime End
    {
      get
      {
        return this.TimeFrame.End;
      }
    }
  }
}