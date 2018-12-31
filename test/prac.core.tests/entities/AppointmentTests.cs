using System;
using NUnit.Framework;
using prac.core.entities;

namespace prac.core.tests.entities
{
  [TestFixture]
  public class AppointmentTests
  {
    [Test]
    public void Start_returns_start_DateTime_of_dateTimeRange()
    {
      var dateTimeRange = new DateTimeRange(
        new DateTime(2018, 1, 1, 18, 0, 0),
        new DateTime(2018, 1, 1, 22, 0, 0));

      var resource = new Resource("Laptop OAP");

      var appointment = new Appointment(dateTimeRange, resource);

      Assert.That(appointment.Start, Is.EqualTo(dateTimeRange.Min));
    }

    [Test]
    public void End_returns_end_DateTime_of_dateTimeRange()
    {
      var dateTimeRange = new DateTimeRange(
        new DateTime(2018, 1, 1, 18, 0, 0),
        new DateTime(2018, 1, 1, 22, 0, 0));

      var resource = new Resource("Laptop OAP");

      var appointment = new Appointment(dateTimeRange, resource);

      Assert.That(appointment.End, Is.EqualTo(dateTimeRange.Max));
    }
  }
}