using System;
using System.Collections;
using System.Collections.Generic;
using prac.core.Exceptions;

namespace prac.core.entities
{
  public class Resource
  {
    private List<DateTimeRange> bookings;
    private List<DateTimeRange> blockings;

    public Resource(string name)
    {
      this.Name = name;
      this.blockings = new List<DateTimeRange>();
      this.bookings = new List<DateTimeRange>();
    }
    public string Name { get; set; }

    public int MaxBookings { get; set; }

    public bool IsBlocked(DateTimeRange dateTimeRange)
    {
      if (this.blockings.Contains(dateTimeRange) == true ||
        this.bookings.Contains(dateTimeRange) == true)
      {
        return true;
      }

      return false;
    }

    public void Block(DateTimeRange dateTimeRange)
    {
      this.blockings.Add(dateTimeRange);
    }

    public void Book(DateTimeRange dateTimeRange)
    {
      if(this.MaxBookings > 0 && this.MaxBookings < this.bookings.Count +1)
      {
        throw new BookingLimitExceededException();
      }
      this.bookings.Add(dateTimeRange);
    }

    public int BookingsCount()
    {
      return this.bookings.Count;
    }
  }
}