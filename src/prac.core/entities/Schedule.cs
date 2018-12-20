using System;
using System.Collections.Generic;

namespace com.github.olo42.prac.core.entities
{
  public class Schedule
  {
    public Schedule(string name)
    {
      this.Name = name;
      this.Bookings = new List<Appoinmtment>();
    }
    public string Name { get; set; }
    public List<Appoinmtment> Bookings { get; set; }

    public void Book(DateTime startDate, DateTime endDate, Resource resource)
    {
      Appoinmtment appoinmtment = new Appoinmtment(startDate, endDate, resource);

      this.Bookings.Add(appoinmtment);
    }
  }
}
