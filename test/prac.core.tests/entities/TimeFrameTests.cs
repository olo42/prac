using System;
using NUnit.Framework;
using prac.core.entities;

namespace prac.core.tests.entities
{
  [TestFixture]
  public class TimeFrameTests
  {
    [Test]
    public void Equals_if_dates_are_equal()
    {
      var timeFrameOne = new TimeFrame(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 18, 0, 0)
      );

      var timeFrameTwo = new TimeFrame(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 18, 0, 0)
      );

      Assert.That(timeFrameOne.Equals(timeFrameTwo), Is.True);
    }

    [Test]
    public void Equals_if_dates_are_not_equal()
    {
      var timeFrameOne = new TimeFrame(
        new DateTime(2018, 1, 1, 10, 0, 0),
        new DateTime(2018, 1, 1, 18, 0, 0)
      );

      var timeFrameTwo = new TimeFrame(
        new DateTime(2018, 2, 2, 10, 0, 0),
        new DateTime(2018, 2, 2, 18, 0, 0)
      );

      Assert.That(timeFrameOne.Equals(timeFrameTwo), Is.False);
    }
  }
}