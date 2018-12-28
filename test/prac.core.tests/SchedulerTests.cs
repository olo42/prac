using NUnit.Framework;
using com.github.olo42.prac.core;
using System.Linq;
using System;
using com.github.olo42.prac.core.entities;
using System.Collections.Generic;

namespace com.github.olo42.prac.core.tests
{
  public class SchedulerTests
  {
    private Calendar calendar;
    private DateTime startDate;
    private DateTime endDate;
    private Resource resource;
    private TimeFrame timeFrame;

    [SetUp]
    public void Setup()
    {
      this.calendar = new Calendar("RHS FL 2018");
      this.startDate = new DateTime(2018, 1, 1, 18, 0, 0);
      this.endDate = new DateTime(2018, 1, 1, 21, 0, 0);
      this.resource = new Resource("Büchen Süd");
      this.timeFrame = new TimeFrame(startDate, endDate);
    }

    [Test]
    public void Create_a_booking_adds_to_calendar()
    {
      Scheduler.Create(this.timeFrame, this.resource, this.calendar);

      var appointment = calendar.Appointments.First();
      var timeFrame = appointment.TimeFrame;

      Assert.That(appointment.Resource.Name, Is.EqualTo("Büchen Süd"));
      Assert.That(
        timeFrame.Start.ToString(), Is.EqualTo(this.startDate.ToString()));
      Assert.That(
        timeFrame.End.ToString(), Is.EqualTo(this.endDate.ToString()));
    }

    [Test]
    public void Create_a_booking_blocks_the_resource()
    {
      Scheduler.Create(this.timeFrame, this.resource, this.calendar);

      var appointment = calendar.Appointments.First();

      Assert.That(this.resource.IsBlocked(this.timeFrame), Is.True);
    }
  }
}