using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using prac.core;
using prac.core.entities;

namespace prac.core.tests
{
  public class SchedulerTests
  {
    private Calendar calendar;
    private DateTime startDate;
    private DateTime endDate;
    private Resource resource;
    private DateTimeRange dateTimeRange;

    [SetUp]
    public void Setup()
    {
      this.calendar = new Calendar("RHS FL 2018");
      this.startDate = new DateTime(2018, 1, 1, 18, 0, 0);
      this.endDate = new DateTime(2018, 1, 1, 21, 0, 0);
      this.resource = new Resource("Büchen Süd");
      this.dateTimeRange = new DateTimeRange(startDate, endDate);
    }

    [Test]
    public void Create_a_booking_adds_to_calendar()
    {
      Scheduler.Create(this.dateTimeRange, this.resource, this.calendar);

      var appointment = calendar.Appointments.First();
      var dateTimeRange = appointment.DateTimeRange;

      Assert.That(appointment.Resource.Name, Is.EqualTo("Büchen Süd"));
      Assert.That(
        dateTimeRange.Min.ToString(), Is.EqualTo(this.startDate.ToString()));
      Assert.That(
        dateTimeRange.Max.ToString(), Is.EqualTo(this.endDate.ToString()));
    }

    [Test]
    public void Create_a_booking_blocks_the_resource()
    {
      Scheduler.Create(this.dateTimeRange, this.resource, this.calendar);

      var appointment = calendar.Appointments.First();

      Assert.That(this.resource.IsBlocked(this.dateTimeRange), Is.True);
    }
  }
}