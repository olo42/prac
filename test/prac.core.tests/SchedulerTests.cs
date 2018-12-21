using NUnit.Framework;
using com.github.olo42.prac.core;
using System.Linq;
using System;
using com.github.olo42.prac.core.entities;

namespace com.github.olo42.prac.core.tests
{
  public class SchedulerTests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Create_a_booking()
    {
      var calendar = new Calendar("Plan for 2018");
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
  }
}