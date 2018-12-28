using System;
using System.Collections.Generic;
using prac.core.entities;

namespace prac.core
{
  public static class Scheduler
  {
    public static void Create(TimeFrame timeFrame, Resource resource, Calendar calendar)
    {
      var appointment = new Appointment(timeFrame, resource);

      calendar.Add(appointment);
      resource.Block(timeFrame);
    }
  }
}