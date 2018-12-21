using System;
using System.Collections.Generic;

namespace com.github.olo42.prac.core.entities
{
  public class Calendar
  {
    public Calendar(string name)
    {
      this.Name = name;
      this.Appointments = new List<Appointment>();
    }
    public string Name { get; set; }
    public List<Appointment> Appointments { get; }

    public void Add(Appointment appointment)
    {
      this.Appointments.Add(appointment);
    }
  }
}
