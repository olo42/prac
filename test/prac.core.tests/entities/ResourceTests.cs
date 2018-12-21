using System;
using com.github.olo42.prac.core.entities;
using NUnit.Framework;

namespace com.github.olo42.prac.core.tests.entities
{
  [TestFixture]
  public class ResourceTests
  {
    [Test]
    public void IsAvailable()
    {
      var resource = new Resource("Trainig location");
      var timeFrameToBlock = new TimeFrame(
        new DateTime(2018,1,1,10,0,0),
        new DateTime(2018,1,1,16,0,0)
      );

      var timeFrameToCheck = new TimeFrame(
        new DateTime(2018,1,1,10,0,0),
        new DateTime(2018,1,1,16,0,0)
      );
      resource.Block(timeFrameToBlock);

      Assert.That(resource.IsBlocked(timeFrameToCheck), Is.False);
    }

    [Test]
    public void IsBlocked()
    {
      var resource = new Resource("Trainig location");
      var timeFrame = new TimeFrame(
        new DateTime(2018,1,1,10,0,0),
        new DateTime(2018,1,1,16,0,0)
      );
      resource.Block(timeFrame);

      Assert.That(resource.IsBlocked(timeFrame), Is.True);
    }
  }
}