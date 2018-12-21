using System;
using System.Collections;
using System.Collections.Generic;

namespace com.github.olo42.prac.core.entities
{
  public class Resource
  {
    private List<TimeFrame> bookings;

    public Resource(string name)
    {
      this.Name = name;
      this.bookings = new List<TimeFrame>();
    }
    public string Name { get; set; }

    public bool IsBlocked(TimeFrame timeFrame)
    {
      return this.bookings.Contains(timeFrame);
    }

    public void Block(TimeFrame timeFrame)
    {
      this.bookings.Add(timeFrame);
    }
  }
}