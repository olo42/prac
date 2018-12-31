using System;
using NUnit.Framework;
using prac.core.entities;

namespace prac.core.tests.entities
{
  [TestFixture]
  public class dateTimeRangeTests
  {
    [Test]
    public void Equals_if_dates_are_equal()
    {
      var dateTimeRangeOne = new DateTimeRange(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 18, 0, 0)
      );

      var dateTimeRangeTwo = new DateTimeRange(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 18, 0, 0)
      );

      Assert.That(dateTimeRangeOne.Equals(dateTimeRangeTwo), Is.True);
    }

    [Test]
    public void Equals_if_dates_are_not_equal()
    {
      var dateTimeRangeOne = new DateTimeRange(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 18, 0, 0)
      );

      var dateTimeRangeTwo = new DateTimeRange(
        new DateTime(2018, 2, 2, 10, 0, 0),
        new DateTime(2018, 2, 2, 18, 0, 0)
      );

      Assert.That(dateTimeRangeOne.Equals(dateTimeRangeTwo), Is.False);
    }

    [Test]
    public void Overlapping_dateTimeRanges()
    {
      var dateTimeRangeOne = new DateTimeRange(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 18, 0, 0)
      );

      var dateTimeRangeTwo = new DateTimeRange(
        new DateTime(2018, 1, 1, 15, 0, 0),
        new DateTime(2018, 1, 1, 22, 0, 0)
      );

      Assert.That(dateTimeRangeOne.IsOverlapped(dateTimeRangeTwo), Is.True);
    }
  }
}