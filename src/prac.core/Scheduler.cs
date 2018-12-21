using System;
using System.Collections.Generic;
using com.github.olo42.prac.core.entities;

namespace com.github.olo42.prac.core
{
  public static class Scheduler
  {
    public static void Create(TimeFrame timeFrame, Resource resource, Calendar calendar)
    {
      var appointment = new Appointment(timeFrame, resource);

      calendar.Add(appointment);
    }
  }
}