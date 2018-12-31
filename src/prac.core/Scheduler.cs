using System;
using System.Collections.Generic;
using prac.core.entities;

namespace prac.core
{
  public static class Scheduler
  {
    public static void Create(
      DateTimeRange dateTimeRange, 
      Resource resource, 
      Calendar calendar)
    {
      var appointment = new Appointment(dateTimeRange, resource);

      calendar.Add(appointment);
      resource.Block(dateTimeRange);
    }
  }
}