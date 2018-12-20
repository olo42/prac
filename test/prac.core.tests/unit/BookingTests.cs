using NUnit.Framework;
using com.github.olo42.prac.core;
using System.Linq;
using System;
using com.github.olo42.prac.core.entities;

namespace com.github.olo42.prac.core.tests.unit
{
  public class BookingTests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Create_a_booking()
    {
      Schedule schedule = new Schedule("Plan for 2018");

      DateTime startDate = new DateTime(2018, 1, 1, 18, 0, 0);
      DateTime endDate = new DateTime(2018, 1, 1, 21, 0, 0);

      Resource resource = new Resource("Büchen Süd");

      schedule.Book(startDate, endDate, resource);

      Appoinmtment appointment = schedule.Bookings.First();

      Assert.That(appointment.StartDate.ToString, Is.EqualTo(startDate.ToString()));
      Assert.That(appointment.EndDate.ToString, Is.EqualTo(endDate.ToString()));
      Assert.That(appointment.Resource.Name, Is.EqualTo("Büchen Süd"));
    }
  }
}