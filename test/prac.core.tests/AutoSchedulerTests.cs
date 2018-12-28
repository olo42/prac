using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using prac.core.entities;

namespace prac.core.tests
{
  [TestFixture]
  public class AutoSchedulerTests
  {
    [Test]
    public void Creates_appointments_for_a_list_of_timeFrames()
    {
      var timeFrames = new List<TimeFrame>();
      timeFrames.Add(new TimeFrame(
        new DateTime(2018, 1, 1, 18, 0, 0),
        new DateTime(2018, 1, 1, 22, 0, 0)
      ));

      IEnumerable<Appointment> appointments = AutoScheduler.Generate(timeFrames);

      Assert.That(
        appointments.First().Start,
        Is.EqualTo(new DateTime(2018, 1, 1, 18, 0, 0)));
    }
  }
}