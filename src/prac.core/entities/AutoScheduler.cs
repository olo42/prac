using System;
using System.Collections.Generic;

namespace prac.core.entities
{
  public class AutoScheduler
  {
    public static IEnumerable<Appointment> Generate(List<TimeFrame> timeFrames)
    {
      var appointments = new List<Appointment>();

      foreach (var timeFrame in timeFrames)
      {
        var appointment = new Appointment(timeFrame, null);
        appointments.Add(appointment);
      }

      return appointments;
    }
  }
}