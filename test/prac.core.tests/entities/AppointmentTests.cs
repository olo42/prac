using System;
using com.github.olo42.prac.core.entities;
using NUnit.Framework;

namespace com.github.olo42.prac.core.tests.entities
{
  [TestFixture]
  public class AppointmentTests
  {
    [Test]
    public void Start_returns_start_DateTime_of_timeframe()
    {
      var timeFrame = new TimeFrame(
        new DateTime(2018,1,1,18,0,0),
        new DateTime(2018,1,1,22,0,0));

        var resource = new Resource("Laptop OAP");

        var appointment = new Appointment(timeFrame, resource);

        Assert.That(appointment.Start, Is.EqualTo(timeFrame.Start)); 
    }

    [Test]
    public void End_returns_end_DateTime_of_timeframe()
    {
      var timeFrame = new TimeFrame(
        new DateTime(2018,1,1,18,0,0),
        new DateTime(2018,1,1,22,0,0));

        var resource = new Resource("Laptop OAP");

        var appointment = new Appointment(timeFrame, resource);

        Assert.That(appointment.End, Is.EqualTo(timeFrame.End)); 
    }
  }
}