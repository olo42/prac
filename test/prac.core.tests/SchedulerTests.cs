using NUnit.Framework;
using com.github.olo42.prac.core;
using System.Linq;
using System;
using com.github.olo42.prac.core.entities;

namespace com.github.olo42.prac.core.tests
{
  public class SchedulerTests
  {
    private Calendar calendar;

    [SetUp]
    public void Setup()
    {
      this.calendar = new Calendar("RHS FL 2018");
    }

    [Test]
    public void Create_a_booking_adds_to_calendar()
    {
      var startDate = new DateTime(2018, 1, 1, 18, 0, 0);
      var endDate = new DateTime(2018, 1, 1, 21, 0, 0);
      var resource = new Resource("Büchen Süd");
      var timeframe = new TimeFrame(startDate, endDate);

      Scheduler.Create(timeframe, resource, calendar);

      var appointment = calendar.Appointments.First();

      Assert.That(appointment.Resource.Name, Is.EqualTo("Büchen Süd"));
      Assert.That(appointment.TimeFrame.Start.ToString(), Is.EqualTo(startDate.ToString()));
      Assert.That(appointment.TimeFrame.End.ToString(), Is.EqualTo(endDate.ToString()));
    }

    [Test]
    public void Create_a_booking_blocks_the_resource()
    {
      var startDate = new DateTime(2018, 1, 1, 18, 0, 0);
      var endDate = new DateTime(2018, 1, 1, 21, 0, 0);
      var resource = new Resource("Büchen Süd");
      var timeframe = new TimeFrame(startDate, endDate);

      Scheduler.Create(timeframe, resource, calendar);

      var appointment = calendar.Appointments.First();

      Assert.That(resource.IsBlocked(timeframe), Is.True);
    }
  }
}