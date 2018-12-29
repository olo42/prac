using System;
using System.Collections;
using System.Collections.Generic;
using prac.core.Exceptions;

namespace prac.core.entities
{
  public class Resource
  {
    private List<TimeFrame> bookings;
    private List<TimeFrame> blockings;

    public Resource(string name)
    {
      this.Name = name;
      this.blockings = new List<TimeFrame>();
      this.bookings = new List<TimeFrame>();
    }
    public string Name { get; set; }

    public int MaxBookings { get; set; }

    public bool IsBlocked(TimeFrame timeFrame)
    {
      if (this.blockings.Contains(timeFrame) == true ||
        this.bookings.Contains(timeFrame) == true)
      {
        return true;
      }

      return false;
    }

    public void Block(TimeFrame timeFrame)
    {
      this.blockings.Add(timeFrame);
    }

    public void Book(TimeFrame timeFrame)
    {
      if(this.MaxBookings > 0 && this.MaxBookings < this.bookings.Count +1)
      {
        throw new BookingLimitExceededException();
      }
      this.bookings.Add(timeFrame);
    }

    public int BookingsCount()
    {
      return this.bookings.Count;
    }
  }
}