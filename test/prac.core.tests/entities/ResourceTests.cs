using System;
using NUnit.Framework;
using prac.core.entities;
using prac.core.Exceptions;

namespace prac.core.tests.entities
{
  [TestFixture]
  public class ResourceTests
  {
    [Test]
    public void IsAvailable()
    {
      var resource = new Resource("Trainig location");
      var dateTimeRangeToBlock = new DateTimeRange(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 16, 0, 0)
      );

      var dateTimeRangeToCheck = new DateTimeRange(
        new DateTime(2018, 2, 2, 10, 0, 0),
        new DateTime(2018, 2, 2, 16, 0, 0)
      );
      resource.Block(dateTimeRangeToBlock);

      Assert.That(resource.IsBlocked(dateTimeRangeToCheck), Is.False);
    }

    [Test]
    public void IsBlocked()
    {
      var resource = new Resource("Trainig location");
      var dateTimeRange = new DateTimeRange(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 16, 0, 0)
      );

      var dateTimeRangeToCheck = new DateTimeRange(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 16, 0, 0)
      );

      resource.Block(dateTimeRange);

      Assert.That(resource.IsBlocked(dateTimeRangeToCheck), Is.True);
    }

    [Test]
    public void Bookings_count()
    {
      var resource = new Resource("Bartelsdorf");
      var dateTimeRange = new DateTimeRange(
        new DateTime(2018, 1, 1, 18, 0, 0),
        new DateTime(2018, 1, 1, 22, 0, 0)
      );

      resource.Book(dateTimeRange);

      Assert.That(resource.BookingsCount, Is.EqualTo(1));
    }

    [Test]
    public void Booking_blocks()
    {
      var resource = new Resource("Bartelsdorf");
      var dateTimeRange = new DateTimeRange(
        new DateTime(2018, 1, 1, 18, 0, 0),
        new DateTime(2018, 1, 1, 22, 0, 0)
      );

      resource.Book(dateTimeRange);

      Assert.That(resource.IsBlocked(dateTimeRange), Is.True);
    }

    [Test]
    public void Booking_limit_exceeded()
    {
      var resource = new Resource("Bartelsdorf");
      resource.MaxBookings = 1;
      var dateTimeRange = new DateTimeRange(
        new DateTime(2018, 1, 1, 18, 0, 0),
        new DateTime(2018, 1, 1, 22, 0, 0)
      );

      resource.Book(dateTimeRange);
      
      var exception = Assert.Throws<BookingLimitExceededException>(
        () => resource.Book(dateTimeRange));
    }
  }
}